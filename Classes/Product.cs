using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___Inventory_Application
{
    public class Product
    {
        // Attributes ----------------------------------------------------------------------------------------------------
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        // Methods -------------------------------------------------------------------------------------------------------
        public void addAssociatedPart(Part part) {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID) {
            Part partToRemove = lookupAssociatedPart(partID);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part lookupAssociatedPart(int partID) {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }


        // Constructor ---------------------------------------------------------------------------------------------------
        public Product(int ProductID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;

        }
    }
}
