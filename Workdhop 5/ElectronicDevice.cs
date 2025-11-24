using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Constructor
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method
        public abstract void ShowInfo();

    }
}
