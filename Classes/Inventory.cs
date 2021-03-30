using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___Inventory_Application
{
    public static class Inventory
    {
        // Attributes ----------------------------------------------------------------------------------------------------
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


        // Methods -------------------------------------------------------------------------------------------------------
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int productID)
        {
            Product productToRemove = lookupProduct(productID);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void updateProduct(int productID, Product updatedProduct)
        {
            removeProduct(productID);
            addProduct(updatedProduct);
        }
        public static void addPart(Part newPart)
        {
            AllParts.Add(newPart);
        }
        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static bool deletePart(int partID)
        {
            Part partToRemove = lookupPart(partID);
            if (partToRemove != null)
            {
                AllParts.Remove(partToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void updatePart(int partID, Part updatedPart)
        {
            deletePart(partID);
            addPart(updatedPart);
        }

    }
}
