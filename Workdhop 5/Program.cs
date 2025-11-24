using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-01 (Encapsulation)
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("------------------------------Encapsulation--------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");

            // Create BankAccount object
            BankAccount account = new BankAccount("ACC7980345210098", 50000);

            // Displaying the account number
            Console.WriteLine("Account Number: " + account.AccountNumber);

            // Depositing money into account
            account.Deposit(20000);

            // Withdrawing money from account
            account.Withdraw(15000);

            // Printing remaining balance
            Console.WriteLine("Remaining Balance: " + account.Balance);
            Console.WriteLine();


            //Task-02 (Inheritance)
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("------------------------------Inheritance----------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");

            // Create Car object
            Car car = new Car();
            car.Brand = "Hero Honda";
            car.Speed = 1060;
            car.Seats = 5;
            Console.WriteLine();


            // Create Motorcycle object
            Motercycle bike = new Motercycle();
            bike.Brand = "Toyota";
            bike.Speed = 560;
            bike.HasCarrier = true;
            Console.WriteLine();

            // Call methods for Car
            car.Start();
            car.DisplayInfo();
            car.Stop();
            Console.WriteLine();

            // Call methods for Motorcycle
            bike.Start();
            bike.DisplayInfo();
            bike.Stop();
            Console.WriteLine();


            // Task-03 (Polymorphism)
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("------------------------------Polymorphism---------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            Printer printer = new Printer();

            // Call Print(string)
            printer.Print("Hello I am Astha Khadka");

            // Call Print(int)
            printer.Print(12345);

            // Call Print(string, int)
            printer.Print("Repeat Message: My Name", 3);
            Console.WriteLine();


            // NepaliTeacher object
            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Name = "Astha Khadka";
            Console.WriteLine("Name: " + nepaliTeacher.Name);
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();
            Console.WriteLine();


            // EnglishTeacher object
            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Name = "Yuna Karki";
            Console.WriteLine("Name: " + englishTeacher.Name);
            englishTeacher.Teaching();  // Uses base class method
            englishTeacher.SalaryInfo();
            Console.WriteLine();

            // Task-04 (Abstraction)
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("------------------------------Abstraction----------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            //Car object
            CarAbstract cars = new CarAbstract();
            cars.Display();       
            cars.StartEngine();   // Abstract method implemented in Car
            cars.StopEngine();    // Abstract method implemented in Car
            Console.WriteLine();


            // Bike object
            Bike bikes = new Bike();
            bikes.Display();      
            bikes.StartEngine();  // Abstract method implemented in Bike
            bikes.StopEngine();   // Abstract method implemented in Bike
            Console.WriteLine();

            // Task-05 (OOP)
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------OOP-----------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            //Creating object of Electronic Store
            ElectronicsStore store = new ElectronicsStore();

            // Creating objects
            Laptop laptop = new Laptop("Lenovo", 120000);
            SmartPhone smartphone = new SmartPhone("Samsung", 85000);

            // Adding them to store
            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            // Showing all details and child-specific behavior
            store.ShowAllDeviceDetails();

        }
    }
}
