using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
        }

        public void ShowAllDeviceDetails()
        {
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcasting to call child-specific methods
                if (device is Laptop)
                {
                    ((Laptop)device).TurnOnBattery();
                }
                else if (device is SmartPhone)
                {
                    ((SmartPhone)device).EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
