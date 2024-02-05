using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankingTransaction.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
    public class TransactionModel
    {
        public TransactionType Type { get;  set; }
        public decimal Amount { get;  set; }
        public DateTime Timestamp { get;  set; }

        public TransactionModel(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
            Timestamp = DateTime.Now;
        }
    }
}
