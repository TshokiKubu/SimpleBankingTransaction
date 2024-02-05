using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBankingTransaction.Models;


namespace SimpleBankingTransaction.Repository
{
    public interface IBankAccountRepository
    {
        decimal GetBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        IEnumerable<TransactionModel> GetTransactionHistory();
        //  List<Transaction> GetTransactionHistory();
    }
}
