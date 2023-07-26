using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            BankAccount account = new BankAccount(accountHolderName);

            PrintAccountDetails(account);

            // Deposit
            Console.Write("Enter the amount to deposit: ");
            if (double.TryParse(Console.ReadLine(), out double depositAmount))
            {
                account.Deposit(depositAmount);
                PrintAccountDetails(account);
            }
            else
            {
                Console.WriteLine("Invalid input for deposit amount.");
            }

            // Withdraw
            Console.Write("Enter the amount to withdraw: ");
            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
            {
                account.Withdraw(withdrawAmount);
                PrintAccountDetails(account);
            }
            else
            {
                Console.WriteLine("Invalid input for withdrawal amount.");
            }
            Console.ReadKey();

        }

        static void PrintAccountDetails(BankAccount account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Account Holder: {account.AccountHolderName}, Balance: {account.Balance:C}");
        }
        
    }
}

