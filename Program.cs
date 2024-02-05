using System;
using SimpleBankingTransaction.Models;
using SimpleBankingTransaction.Repository; // Import the namespace for Transaction model


namespace SimpleBankingTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Banking Transaction");
            Console.WriteLine("-------------------------------------");

          
            IBankAccountRepository account = new BankAccountRepository(0);


            try
            {
                Console.WriteLine($"Initial Balance: ${account.GetBalance():R}");

                // deposit
                Console.Write("Enter deposit amount: ");
                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                account.Deposit(depositAmount);
                Console.WriteLine($"Current Balance after deposit: ${account.GetBalance():R}");

                // withdrawal
                Console.Write("Enter withdrawal amount: ");
                decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(withdrawalAmount);
                Console.WriteLine($"Current Balance after withdrawal: ${account.GetBalance():R}");

                // Display transaction history
                Console.WriteLine("\nTransaction History:");
                Console.WriteLine("----------------------");
                
                foreach (var transaction in account.GetTransactionHistory())
                {
                     Console.WriteLine($"{transaction.Timestamp} - {transaction.Type}: ${transaction.Amount:R}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
