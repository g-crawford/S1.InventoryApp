using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_Application
{
    public partial class ModifyPartScreen : Form
    {
        // Attributes --------------------------------------------------------------------------------------------------------------------------
        public MainScreen mainScreen;

        public bool validID = false;
        public bool validName = false;
        public bool validInventory = false;
        public bool validPrice = false;
        public bool validMin = false;
        public bool validMax = false;
        public bool validIO = false;


        // Constructors ------------------------------------------------------------------------------------------------------------------------
        public ModifyPartScreen(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            ID_Textbox.Text = mainScreen.currentSelectedPart.PartID.ToString();
            NameTextbox.Text = mainScreen.currentSelectedPart.Name;
            PriceCostTextbox.Text = mainScreen.currentSelectedPart.Price.ToString();
            InventoryTextbox.Text = mainScreen.currentSelectedPart.InStock.ToString();
            MinTextbox.Text = mainScreen.currentSelectedPart.Min.ToString();
            MaxTextbox.Text = mainScreen.currentSelectedPart.Max.ToString();

            if (mainScreen.currentSelectedPart is Inhouse)
            {
                Inhouse part = (Inhouse)mainScreen.currentSelectedPart;
                InHouseRadioButton.Checked = true;
                IO_Textbox.Text = part.MachineID.ToString();
            } 
            else
            {
                Outsourced part = (Outsourced)mainScreen.currentSelectedPart;
                OutsourcedRadioButton.Checked = true;
                IO_Textbox.Text = part.CompanyName;
            }
        }


        // Methods -----------------------------------------------------------------------------------------------------------------------------

        private bool allowSave(bool validID, bool validName, bool validInventory, bool validPrice, bool validMin, bool validMax, bool validIO)
        {
            return (validID &&
                validName &&
                validInventory &&
                validPrice &&
                validMin &&
                validMax &&
                validIO);
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IO_Label.Text = "Machine ID";
            IO_Textbox.Clear();
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IO_Label.Text = "Company Name";
            IO_Textbox.Clear();
        }

        private void ID_Textbox_TextChanged(object sender, EventArgs e)
        {
            int ID_Number;

            if (string.IsNullOrWhiteSpace(ID_Textbox.Text) || (!int.TryParse(ID_Textbox.Text, out ID_Number)))
            {
                ID_Textbox.BackColor = Color.Salmon;
                validID = false;
            }
            else
            {
                ID_Textbox.BackColor = Color.White;
                validID = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextbox.Text))
            {
                NameTextbox.BackColor = Color.Salmon;
                validName = false;
            }
            else
            {
                NameTextbox.BackColor = Color.White;
                validName = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void InventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            int inventoryNumber;

            if (string.IsNullOrWhiteSpace(InventoryTextbox.Text) || (!int.TryParse(InventoryTextbox.Text, out inventoryNumber)))
            {
                InventoryTextbox.BackColor = Color.Salmon;
                validInventory = false;
            }
            else
            {
                InventoryTextbox.BackColor = Color.White;
                validInventory = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void PriceCostTextbox_TextChanged(object sender, EventArgs e)
        {
            decimal PriceNumber;

            if (string.IsNullOrWhiteSpace(PriceCostTextbox.Text) || (!decimal.TryParse(PriceCostTextbox.Text, out PriceNumber)))
            {
                PriceCostTextbox.BackColor = Color.Salmon;
                validPrice = false;
            }
            else
            {
                PriceCostTextbox.BackColor = Color.White;
                validPrice = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void MinTextbox_TextChanged(object sender, EventArgs e)
        {
            int MinNumber;

            if (string.IsNullOrWhiteSpace(MinTextbox.Text) || (!int.TryParse(MinTextbox.Text, out MinNumber)))
            {
                MinTextbox.BackColor = Color.Salmon;
                validMin = false;
            }
            else
            {
                MinTextbox.BackColor = Color.White;
                validMin = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void MaxTextbox_TextChanged(object sender, EventArgs e)
        {
            int MaxNumber;

            if (string.IsNullOrWhiteSpace(MaxTextbox.Text) || (!int.TryParse(MaxTextbox.Text, out MaxNumber)) || MaxTextbox.Text == "0")
            {
                MaxTextbox.BackColor = Color.Salmon;
                validMax = false;
            }
            else
            {
                MaxTextbox.BackColor = Color.White;
                validMax = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
        }

        private void IO_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (IO_Label.Text == "Company Name")
            {
                if (string.IsNullOrWhiteSpace(IO_Textbox.Text))
                {
                    IO_Textbox.BackColor = Color.Salmon;
                    validIO = false;
                }
                else
                {
                    IO_Textbox.BackColor = Color.White;
                    validIO = true;
                }

                SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
            }
            else
            {
                int MachineID;

                if (string.IsNullOrWhiteSpace(IO_Textbox.Text) || (!int.TryParse(IO_Textbox.Text, out MachineID)))
                {
                    IO_Textbox.BackColor = Color.Salmon;
                    validIO = false;
                }
                else
                {
                    IO_Textbox.BackColor = Color.White;
                    validIO = true;
                }

                SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax, validIO);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int Min = (int.Parse(MinTextbox.Text));
            int Max = (int.Parse(MaxTextbox.Text));
            int InStock = (int.Parse(InventoryTextbox.Text));

            if (Min > Max)
            {
                MessageBox.Show("Minimum cannot be larger than Maximum.", "Minimum Larger Than Maximum");
            }
            else if (InStock > Max || InStock < Min)
            {
                MessageBox.Show("Inventory number must be a value between Minimum and Maximum.", "Invalid Inventory Number");
            }
            else if (IO_Label.Text == "Company Name")
            {
                int PartID = (int.Parse(ID_Textbox.Text));
                string Name = NameTextbox.Text;
                decimal Price = (decimal.Parse(PriceCostTextbox.Text));
                string IO = IO_Textbox.Text;
                Outsourced newPart = new Outsourced(PartID, Name, Price, InStock, Min, Max, IO);
                Inventory.deletePart(mainScreen.currentSelectedPart.PartID);
                Inventory.addPart(newPart);
                mainScreen.Show();
                this.Close();
            } 
            else
            {
                int PartID = (int.Parse(ID_Textbox.Text));
                string Name = NameTextbox.Text;
                decimal Price = (decimal.Parse(PriceCostTextbox.Text));
                int IO = (int.Parse(IO_Textbox.Text));
                Inhouse newPart = new Inhouse(PartID, Name, Price, InStock, Min, Max, IO);
                Inventory.deletePart(mainScreen.currentSelectedPart.PartID);
                Inventory.addPart(newPart);
                mainScreen.Show();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
            this.Close();
        }

    }
}
