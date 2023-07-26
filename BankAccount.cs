using System;


namespace ConAppAssignment16
{
    public class BankAccount
    {
        private static int nextAccountNumber = 01; // To automatically generate account numbers
        private readonly int accountNumber; // Read-only property
        private string accountHolderName;
        private double balance;

        // Properties
        public int AccountNumber => accountNumber;
        public string AccountHolderName
        {
            get => accountHolderName;
            set => accountHolderName = value;
        }

        // Balance cannot be directly accessed; only through deposit and withdrawal methods
        public double Balance => balance;

        // Constructor
        public BankAccount(string accountHolderName)
        {
            this.accountNumber = nextAccountNumber++;
            this.AccountHolderName = accountHolderName;
            this.balance = 0;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. Current balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. Current balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero and less than or equal to the balance.");
            }
        }
    }

}
