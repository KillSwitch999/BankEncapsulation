using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new bank account
            BankAccount myAccount = new BankAccount();

            // Ask user for deposit
            Console.WriteLine("Welcome to the Bank! How much would you like to deposit?");
            string input = Console.ReadLine();

            // Try to parse input and deposit it
            if (double.TryParse(input, out double depositAmount))
            {
                myAccount.Deposit(depositAmount);
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
            }

            // Retrieve balance
            double balance = myAccount.GetBalance();
            Console.WriteLine($"Your current balance is: ${balance:F2}");
        }
    }
}