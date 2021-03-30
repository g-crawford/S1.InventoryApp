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
    public partial class MainScreen : Form
    {
        // Attributes --------------------------------------------------------------------------------------------------------------------------

        public int currentSelectedPartIndex { get; set; }
        public Part currentSelectedPart { get; set; }
        public int currentSelectedProductIndex { get; set; }
        public Product currentSelectedProduct { get; set; }


        // Constructors ------------------------------------------------------------------------------------------------------------------------
        public MainScreen()
        {
            InitializeComponent();
            PartsDataGridView.DataSource = Inventory.AllParts;
            ProductsDataGridView.DataSource = Inventory.Products;
        }


        //Methods ------------------------------------------------------------------------------------------------------------------------------
        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            PartsDataGridView.ClearSelection();
            PartsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (PartsSearchBox.Text == "")
            {
                MessageBox.Show("No Part name was input. Please input a part name to search.", "Part Name Not Entered");
            }
            else
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(PartsSearchBox.Text.ToUpper()))
                    {
                        PartsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No part with matching name was found.", "No Part Found");
                }
            }
        }

        private void PartsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedPartIndex = PartsDataGridView.CurrentCell.RowIndex;
            currentSelectedPart = Inventory.AllParts[currentSelectedPartIndex];
        }

        private void PartsAddButton_Click(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen = new AddPartScreen(this);
            addPartScreen.Show();
            this.Hide();
        }

        private void PartsModifyButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedPart == null)
            {
                MessageBox.Show("No part was selected. Please select a part to modify.", "No Part Selected");
            }
            else
            {
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen(this);
                modifyPartScreen.Show();
                this.Hide();
            }
        }

        private void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedPart == null)
            {
                MessageBox.Show("Part not selected. Please click on row containing a part.", "Part Not Selected");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Inventory.AllParts.Remove(currentSelectedPart);
                }
            }
        }

        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            ProductsDataGridView.ClearSelection();
            ProductsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (ProductsSearchBar.Text == "")
            {
                MessageBox.Show("No Product name was input. Please input a product name to search.", "Product Name Not Entered");
            }
            else
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(ProductsSearchBar.Text.ToUpper()))
                    {
                        ProductsDataGridView.Rows[i].Selected = true;
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No product with matching name was found.", "No Product Found");
                }
            }
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedProductIndex = ProductsDataGridView.CurrentCell.RowIndex;
            currentSelectedProduct = Inventory.Products[currentSelectedProductIndex];
        }

        private void ProductsAddButton_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen(this);
            addProductScreen.Show();
            this.Hide();
        }

        private void ProductsModifyButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedProduct == null)
            {
                MessageBox.Show("No product selected. Please select product to modify.", "No Product Selected");
            }
            else
            {
                ModifyProductScreen modifyProductScreen = new ModifyProductScreen(this);
                modifyProductScreen.Show();
                this.Hide();
            }
        }

        private void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedProduct == null)
            {
                MessageBox.Show("Product not selected. Please click on row containing a product.", "Product Not Selected");
            }
            else
            {
                if (currentSelectedProduct.AssociatedParts.Count != 0)
                {
                    MessageBox.Show("Selected product has associated parts. Cannot delete product with associated parts.", "Product Has Associated Parts");
                }
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Inventory.Products.Remove(currentSelectedProduct);
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}