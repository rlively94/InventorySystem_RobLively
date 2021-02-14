using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_RobLively
{
    public partial class UpdateProducts : Form
    {
        public static BindingList<Part> AssocParts = new BindingList<Part>();

        public int AvailPartIndex { get; set; }
        public int AssocPartIndex { get; set; }
        public UpdateProducts() //constructor for add new product
        {
            InitializeComponent();
            PopulatePartsGrid();
            formatDGV(partsDGV);
            formatDGV(assocpartsDGV);
            partsDGV.ClearSelection();
            assocpartsDGV.ClearSelection();
            AssocParts = new BindingList<Part>();
            AvailPartIndex = -1;
            AssocPartIndex = -1;
            idtextBox.Text = Inventory.ProductId.ToString();
        }

        private bool allowSave()
        {
            int number;
            decimal price;
            return (!string.IsNullOrWhiteSpace(nametextBox.Text)) && (Int32.TryParse(invtextBox.Text, out number)) && (Int32.TryParse(mintextBox.Text, out number)) && (Int32.TryParse(maxtextBox.Text, out number)) && (Decimal.TryParse(pricetextBox.Text, out price));
        }

        public UpdateProducts(Product modifyProduct) //constructor modify existing product
        {
            InitializeComponent();
            formatDGV(partsDGV);
            formatDGV(assocpartsDGV);
            partsDGV.ClearSelection();
            assocpartsDGV.ClearSelection();
            AssocParts = modifyProduct.AssociatedParts;
            PopulatePartsGrid();
            PopulateAssocPartsGrid();
            PopulateTextbox();
            AvailPartIndex = -1;
            AssocPartIndex = -1;
        }

    private void formatDGV(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgv.RowHeadersVisible = false;
        }

        private void PopulatePartsGrid() // re-populate dgv
        {
            partsDGV.AutoGenerateColumns = false;
            partsDGV.DataSource = Inventory.Parts;
            partsDGV.ClearSelection();
        }

        private void PopulateAssocPartsGrid() // re-populate assocpart dgv if modifying existing product
        {
            assocpartsDGV.AutoGenerateColumns = false;
            assocpartsDGV.DataSource = AssocParts;
            assocpartsDGV.ClearSelection();
        }

        private void PopulateTextbox() //populate textbox values when modifying existing product
        {
            idtextBox.Text = Inventory.CurrentProduct.ProductId.ToString();
            nametextBox.Text = Inventory.CurrentProduct.Name;
            invtextBox.Text = Inventory.CurrentProduct.InStock.ToString();
            pricetextBox.Text = Inventory.CurrentProduct.Price.ToString();
            mintextBox.Text = Inventory.CurrentProduct.Min.ToString();
            maxtextBox.Text = Inventory.CurrentProduct.Max.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void partssearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> partSearch = new BindingList<Part>();
            bool partFound = false;

            if (partssearchtextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Parts.Count; i++)
                {
                    if (Inventory.Parts[i].Name.ToUpper().Contains(partssearchtextBox.Text.ToUpper()))
                    {
                        partSearch.Add(Inventory.Parts[i]);
                        partFound = true;
                    }
                }

                if (partFound)
                {
                    partsDGV.DataSource = partSearch;
                }
            }

            if (!partFound)
            {
                MessageBox.Show("No results.");
                partsDGV.DataSource = Inventory.Parts;
            }
        }

        private void partssearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partssearchButton_Click(sender, e);
            }
        }

        private void partsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AvailPartIndex = e.RowIndex;
        }

        private void assocpartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssocPartIndex = e.RowIndex;
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            PopulatePartsGrid();
            PopulateAssocPartsGrid();
        }

        private void addpartButton_Click(object sender, EventArgs e)
        {
            if (AvailPartIndex >= 0)
            {
                Part NewAssocPart = (Part)partsDGV.CurrentRow.DataBoundItem;
                AssocParts.Add(NewAssocPart);
                assocpartsDGV.ClearSelection();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainScreen.ModifyProduct)
                {
                    Product updatedProduct = new Product(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                        Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                        Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text), AssocParts);
                    Inventory.UpdateProduct(Inventory.CurrentProdId, updatedProduct);
                }
                else
                {
                    Product newProduct = new Product(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                        Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                        Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text), AssocParts);
                    Inventory.AddProduct(newProduct);
                    Inventory.ProductId++;
                }

                this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Failed to save: {exception.Message}");
            }
        }

        private void deleteassocpartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partId = (int) assocpartsDGV.Rows[AssocPartIndex].Cells[0].Value;
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm action",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    AssocParts.RemoveAt(AssocPartIndex);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a part to remove.");
            }
            assocpartsDGV.ClearSelection();
            AssocPartIndex = -1;
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametextBox.Text))
            {
                nametextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                nametextBox.BackColor = System.Drawing.Color.White;
            }

            saveButton.Enabled = allowSave();
        }

        private void invtextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(invtextBox.Text, out number))
            {
                invtextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                invtextBox.BackColor = System.Drawing.Color.White;
            }

            saveButton.Enabled = allowSave();
        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {
            decimal number;
            if (!Decimal.TryParse(pricetextBox.Text, out number))
            {
                pricetextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                pricetextBox.BackColor = System.Drawing.Color.White;
            }

            saveButton.Enabled = allowSave();
        }

        private void mintextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(mintextBox.Text, out number))
            {
                mintextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                mintextBox.BackColor = System.Drawing.Color.White;
            }

            saveButton.Enabled = allowSave();
        }

        private void maxtextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(maxtextBox.Text, out number))
            {
                maxtextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                maxtextBox.BackColor = System.Drawing.Color.White;
            }

            saveButton.Enabled = allowSave();
        }
    }

}