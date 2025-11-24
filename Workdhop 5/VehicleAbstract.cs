using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal abstract class VehicleAbstract
    {
        // Abstract methods (must be implemented in derived classes)
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
