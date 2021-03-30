using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C968___Inventory_Application
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Inhouse wheel = new Inhouse(1, "Wheel", 19.99m, 8, 2, 50, 3);
            Outsourced pedal = new Outsourced(2, "Pedal", 9.99m, 2, 1, 25, "ABC, LLC");
            Inhouse chain = new Inhouse(3, "Chain", 24.99m, 7, 3, 30, 42);
            Outsourced seat = new Outsourced(4, "Seat", 49.99m, 16, 4, 100, "Radical Labs, INC");

            Inventory.AllParts.Add(wheel);
            Inventory.AllParts.Add(pedal);
            Inventory.AllParts.Add(chain);
            Inventory.AllParts.Add(seat);

            Product redBike = new Product(1, "Red Bicycle", 11.45m, 10, 1, 50);
            Product yellowBike = new Product(2, "Yellow Bicycle", 12.45m, 11, 1, 25);
            Product blueBike = new Product(3, "Blue Bicycle", 14.45m, 7, 1, 20);
            Product greenBike = new Product(4, "Green Bicycle", 17.45m, 4, 1, 7);

            Inventory.Products.Add(redBike);
            Inventory.Products.Add(yellowBike);
            Inventory.Products.Add(blueBike);
            Inventory.Products.Add(greenBike);

            redBike.AssociatedParts.Add(wheel);
            redBike.AssociatedParts.Add(pedal);
            redBike.AssociatedParts.Add(chain);

            blueBike.AssociatedParts.Add(wheel);
            blueBike.AssociatedParts.Add(seat);

            yellowBike.AssociatedParts.Add(wheel);
            yellowBike.AssociatedParts.Add(chain);
            yellowBike.AssociatedParts.Add(seat);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}