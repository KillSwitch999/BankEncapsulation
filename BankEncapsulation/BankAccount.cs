namespace BankEncapsulation
{
    public class BankAccount
    {
        // Private field to store balance
        private double balance = 0;

        // Method to deposit money
        public void Deposit(double amount)
        {
            balance += amount;
        }

        // Method to retrieve balance
        public double GetBalance()
        {
            return balance;
        }
    }
}