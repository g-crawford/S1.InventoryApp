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
    public partial class ModifyProductScreen : Form
    {
        // Attributes --------------------------------------------------------------------------------------------------------------------------
        public MainScreen mainScreen;
        public static BindingList<Part> partsToAssociate { get; set; }
        public int currentCandidatePartIndex { get; set; }
        public Part currentCandidatePart { get; set; }
        public int currentAssociatedPartIndex { get; set; }
        public Part currentAssociatedPart { get; set; }

        public bool validID = false;
        public bool validName = false;
        public bool validInventory = false;
        public bool validPrice = false;
        public bool validMin = false;
        public bool validMax = false;


        // Constructors ------------------------------------------------------------------------------------------------------------------------
        public ModifyProductScreen(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            CandidatePartsDataGrid.DataSource = Inventory.AllParts;
            AssociatedPartsDataGrid.DataSource = mainScreen.currentSelectedProduct.AssociatedParts;
            ID_Textbox.Text = mainScreen.currentSelectedProduct.ProductID.ToString();
            NameTextbox.Text = mainScreen.currentSelectedProduct.Name;
            InventoryTextbox.Text = mainScreen.currentSelectedProduct.InStock.ToString();
            PriceTextbox.Text = mainScreen.currentSelectedProduct.Price.ToString();
            MinTextbox.Text = mainScreen.currentSelectedProduct.Min.ToString();
            MaxTextbox.Text = mainScreen.currentSelectedProduct.Max.ToString();
            partsToAssociate = mainScreen.currentSelectedProduct.AssociatedParts;
        }


        // Methods -----------------------------------------------------------------------------------------------------------------------------
        private bool allowSave(bool validID, bool validName, bool validInventory, bool validPrice, bool validMin, bool validMax)
        {
            return (validID &&
                validName &&
                validInventory &&
                validPrice &&
                validMin &&
                validMax);
        }

        private void CandidatePartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentCandidatePartIndex = CandidatePartsDataGrid.CurrentCell.RowIndex;
            currentCandidatePart = Inventory.AllParts[currentCandidatePartIndex];
        }

        private void AssociatedPartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentAssociatedPartIndex = AssociatedPartsDataGrid.CurrentCell.RowIndex;
            currentAssociatedPart = partsToAssociate[currentAssociatedPartIndex];
        }

        private void CandidatePartsSearchButton_Click(object sender, EventArgs e)
        {
            CandidatePartsDataGrid.ClearSelection();
            CandidatePartsDataGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (CandidatePartsTextbox.Text == "")
            {
                MessageBox.Show("No Part name was input. Please input a part name to search.", "Part Name Not Entered");
            }
            else
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(CandidatePartsTextbox.Text.ToUpper()))
                    {
                        CandidatePartsDataGrid.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No part with matching name was found.", "No Part Found");
                }
            }
        }

        private void CandidatePartsAddButton_Click(object sender, EventArgs e)
        {
            if (currentCandidatePart == null)
            {
                MessageBox.Show("A candidate part was not selected. Please click on row containing candidate part.", "No Candidate Part Selected");
            }
            else
            {
                partsToAssociate.Add(currentCandidatePart);
            }
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

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameTextbox.Text))
            {
                NameTextbox.BackColor = Color.Salmon;
                validName = false;
            }
            else
            {
                NameTextbox.BackColor = Color.White;
                validName = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
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

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
        }

        private void PriceTextbox_TextChanged(object sender, EventArgs e)
        {
            decimal PriceNumber;

            if (string.IsNullOrWhiteSpace(PriceTextbox.Text) || (!decimal.TryParse(PriceTextbox.Text, out PriceNumber)))
            {
                PriceTextbox.BackColor = Color.Salmon;
                validPrice = false;
            }
            else
            {
                PriceTextbox.BackColor = Color.White;
                validPrice = true;
            }

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
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

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
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

            SaveButton.Enabled = allowSave(validID, validName, validInventory, validPrice, validMin, validMax);
        }

        private void AssociatedPartsDeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                partsToAssociate.RemoveAt(currentAssociatedPartIndex);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int ProductID = (int.Parse(ID_Textbox.Text));
            string Name = NameTextbox.Text;
            decimal Price = (decimal.Parse(PriceTextbox.Text));
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
            else
            {
                Product newProduct = new Product(ProductID, Name, Price, InStock, Min, Max);
                Inventory.removeProduct(mainScreen.currentSelectedProduct.ProductID);
                Inventory.Products.Add(newProduct);
                foreach (Part part in partsToAssociate)
                {
                    newProduct.AssociatedParts.Add(part);
                }
                mainScreen.Show();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
            this.Close();
        }

        private void AssociatedPartsSearchButton_Click(object sender, EventArgs e)
        {
            AssociatedPartsDataGrid.ClearSelection();
            AssociatedPartsDataGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (AssociatedPartsTextbox.Text == "")
            {
                MessageBox.Show("No Part name was input. Please input a part name to search.", "Part Name Not Entered");
            }
            else
            {
                for (int i = 0; i < partsToAssociate.Count; i++)
                {
                    if (partsToAssociate[i].Name.ToUpper().Contains(AssociatedPartsTextbox.Text.ToUpper()))
                    {
                        AssociatedPartsDataGrid.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No part with matching name was found.", "No Part Found");
                }
            }
        }
    }
}