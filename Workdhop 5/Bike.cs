using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Bike : VehicleAbstract
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}
