using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5;

namespace Workshop_5
{
    internal class BankAccount
    {
        private string accountNumber;
        private int balance;

        public BankAccount(string accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string AccountNumber { 
            get{ return accountNumber; } 
        }

        public int Balance {
            get{ return balance; }
            private set { 
                if (balance <= 0)
                {
                    throw new ArgumentException("Value cannot be negative");
                } 
                balance += value;
            
            }
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive!");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive!");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Error: Insufficient balance!");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }

        // Display account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"\nAccount Number: {AccountNumber}");
            Console.WriteLine($"Current Balance: ${Balance:F2}");
        }
    }
}


   