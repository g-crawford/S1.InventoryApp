using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___Inventory_Application
{
    public abstract class Part
    {
        // Attributes ----------------------------------------------------------------------------------------------------
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }


    // Derived Classes ---------------------------------------------------------------------------------------------------
    public class Inhouse : Part
    {
        // Attributes ----------------------------------------------------------------------------------------------------
        public int MachineID { get; set; }


        // Constructor ---------------------------------------------------------------------------------------------------
        public Inhouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.MachineID = MachineID;
        }
    }

    public class Outsourced : Part
    {
        // Attributes ----------------------------------------------------------------------------------------------------
        public string CompanyName { get; set; }


        // Constructor ---------------------------------------------------------------------------------------------------
        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
    }
}
