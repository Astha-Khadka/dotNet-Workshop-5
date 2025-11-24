using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5;

namespace Workshop_5
{
    internal class Car : Vehicle
    {
        // Unique field
        public int Seats { get; set; }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base method
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
