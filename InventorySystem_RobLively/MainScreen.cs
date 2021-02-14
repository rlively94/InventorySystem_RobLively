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
    public partial class MainScreen : Form
    {
        public static int PartIndex { get; set; }

        public static int ProductIndex { get; set; }

        public static bool ModifyPart;

        public static bool ModifyProduct;
        public MainScreen()
        {
            InitializeComponent();
            formatDGV(partsDGV);
            formatDGV(productsDGV);
            populatepartsGrid();
            populateproductsGrid();
            ProductIndex = -1;
            PartIndex = -1;
        }

        private void formatDGV(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgv.RowHeadersVisible = false;
        }

        private void populatepartsGrid() // re-populate dgv
        {
            partsDGV.AutoGenerateColumns = false;
            partsDGV.DataSource = Inventory.Parts;
            partsDGV.ClearSelection();
        }

        private void populateproductsGrid() // re-populate dgv
        {
            productsDGV.AutoGenerateColumns = false;
            productsDGV.DataSource = Inventory.Products;
            productsDGV.ClearSelection();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            populatepartsGrid();
            populateproductsGrid();
        }

        private void appexitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void partsdeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partId = (int)partsDGV.Rows[PartIndex].Cells[0].Value;
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?", "Confirm action", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        Inventory.RemovePart(partId);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Select an entry.");
                    }
                    partsDGV.ClearSelection();
                    PartIndex = -1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entry.");
            }
        }


        private void productsdeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = (int)productsDGV.Rows[ProductIndex].Cells[0].Value;
                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm action",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (Inventory.CurrentProduct.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot remove a product with associated parts.");
                    }
                    else
                    {
                        Inventory.RemoveProduct(productId);
                        productsDGV.ClearSelection();
                        ProductIndex = -1;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entry.");
            }
        }

        private void productsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIndex = e.RowIndex;
            Inventory.CurrentProdId = (int)productsDGV.Rows[ProductIndex].Cells[0].Value;
            Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProdId);
        }
        private void partsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PartIndex = e.RowIndex;
            Inventory.CurrentPartId = (int)partsDGV.Rows[PartIndex].Cells[0].Value;
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartId);
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

        private void productssearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> productSearch = new BindingList<Product>();
            bool productFound = false;

            if (productssearchtextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(productssearchtextBox.Text.ToUpper()))
                    {
                        productSearch.Add(Inventory.Products[i]);
                        productFound = true;
                    }
                }

                if (productFound)
                {
                    productsDGV.DataSource = productSearch;
                }
            }

            if (!productFound)
            {
                MessageBox.Show("No results.");
                productsDGV.DataSource = Inventory.Products;
            }
        }

        private void partssearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partssearchButton_Click(sender, e);
            }
        }

        private void productssearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productssearchButton_Click(sender, e);
            }
        }

        private void partsmodifyButton_Click(object sender, EventArgs e)
        {
            if (PartIndex >= 0)
            {
                ModifyPart = true;
                this.Hide();
                UpdateParts updateScreen = new UpdateParts();
                updateScreen.Show();
            }
        }

        private void partsaddButton_Click(object sender, EventArgs e)
        {
            ModifyPart = false;
            this.Hide();
            UpdateParts updateScreen = new UpdateParts();
            updateScreen.Show();
        }

        private void productsaddButton_Click(object sender, EventArgs e)
        {
            ModifyProduct = false;
            this.Hide();
            UpdateProducts addPRoductScreen = new UpdateProducts();
            addPRoductScreen.Show();
        }

        private void productsmodifyButton_Click(object sender, EventArgs e)
        {
            if (ProductIndex >= 0)
            {
                ModifyProduct = true;
                this.Hide();
                UpdateProducts modifyProductScreen = new UpdateProducts(Inventory.CurrentProduct);
                modifyProductScreen.Show();
            }
        }
    }
    }

