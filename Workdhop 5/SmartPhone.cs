using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class SmartPhone : ElectronicDevice
    {
        public SmartPhone(string brand, double price) : base(brand, price)
        {
        }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
        }
    }
}
