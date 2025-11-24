using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Motercycle : Vehicle
    {
        // Unique field
        public bool HasCarrier { get; set; }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base method
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }

    }
}
