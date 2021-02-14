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
    public partial class UpdateParts : Form
    {
        public bool inhousePart;
        public UpdateParts()
        {
            InitializeComponent();
            if (MainScreen.ModifyPart)
            {
                populateFields();
            }
            else
            {
                idtextBox.Text = Inventory.PartId.ToString();
                inhousePart = true;
                inhouseradioButton.Checked = true;
            }
        }

        public void populateFields()
        {
            idtextBox.Text = Inventory.CurrentPart.PartId.ToString();
            nametextBox.Text = Inventory.CurrentPart.Name;
            invtextBox.Text = Inventory.CurrentPart.InStock.ToString();
            pricetextBox.Text = Inventory.CurrentPart.Price.ToString();
            mintextBox.Text = Inventory.CurrentPart.Min.ToString();
            maxtextBox.Text = Inventory.CurrentPart.Max.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse currentPart = (Inhouse) Inventory.CurrentPart;
                variabletextBox.Text = currentPart.MachineId.ToString();
                inhousePart = true;
                inhouseradioButton.Checked = true;
            }
            else
            {
                Outsourced currentPart = (Outsourced) Inventory.CurrentPart;
                variabletextBox.Text = currentPart.CompanyName;
                inhousePart = false;
                outsourcedradioButton.Checked = true;
            }
        }
        private void UpdateParts_Load(object sender, EventArgs e)
        {

        }
        
        private void inhouseradioButton_CheckedChanged(object sender, EventArgs e)
        {
            variableLabel.Text = "Machine ID";
            inhousePart = true;
            ValidateRBSwitch();
        }

        private void outsourcedradioButton_CheckedChanged(object sender, EventArgs e)
        {
            variableLabel.Text = "Company Name";
            inhousePart = false;
            ValidateRBSwitch();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainScreen.ModifyPart)
                {
                    if (inhousePart)
                    {
                        Part updatedPart = new Inhouse(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                            Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                            Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text),
                            Convert.ToInt32(variabletextBox.Text));
                        Inventory.UpdatePart(updatedPart);
                    }
                    else
                    {
                        Part updatedPart = new Outsourced(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                            Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                            Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text),
                            (variabletextBox.Text));
                        Inventory.UpdatePart(updatedPart);
                    }
                }
                else
                {
                    if (inhousePart)
                    {
                        Part newPart = new Inhouse(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                            Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                            Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text),
                            Convert.ToInt32(variabletextBox.Text));
                        Inventory.AddPart(newPart);
                    }
                    else
                    {
                        Part newPart = new Outsourced(Convert.ToInt32(idtextBox.Text), nametextBox.Text,
                            Convert.ToDecimal(pricetextBox.Text), Convert.ToInt32(maxtextBox.Text),
                            Convert.ToInt32(mintextBox.Text), Convert.ToInt32(invtextBox.Text),
                            (variabletextBox.Text));
                        Inventory.AddPart(newPart);
                        Inventory.PartId++;
                    }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private bool allowSave()
        {
            int number;
            decimal price;
            return (!string.IsNullOrWhiteSpace(nametextBox.Text)) &&
                   (!(string.IsNullOrWhiteSpace(variabletextBox.Text) || (inhousePart && !Int32.TryParse(variabletextBox.Text, out number)))) && (Int32.TryParse(invtextBox.Text, out number)) && (Int32.TryParse(mintextBox.Text, out number)) && (Int32.TryParse(maxtextBox.Text, out number)) && (Decimal.TryParse(pricetextBox.Text, out price));
        }

        private void ValidateRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(variabletextBox.Text) || (inhousePart && !Int32.TryParse(variabletextBox.Text, out number)))
            {
                variabletextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                variabletextBox.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = allowSave();
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

        private void variabletextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateRBSwitch();
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
