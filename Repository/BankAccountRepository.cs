using System;
using System.Collections.Generic;
using SimpleBankingTransaction.Models;

namespace SimpleBankingTransaction.Repository
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public decimal _balance;
        public List<TransactionModel> _transactionHistory;

        public BankAccountRepository(decimal initialBalance)
        {
            _balance = initialBalance;
            _transactionHistory = new List<TransactionModel>();
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            if (amount > 2500)
                throw new ArgumentException("Cannot deposit more than 2500.");

            _balance += amount;
            _transactionHistory.Add(new TransactionModel(TransactionType.Deposit, amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds.");

            _balance -= amount;
            _transactionHistory.Add(new TransactionModel(TransactionType.Withdrawal, amount));
        }

        public IEnumerable<TransactionModel> GetTransactionHistory()
        {
            return _transactionHistory;
        }
    }
}
