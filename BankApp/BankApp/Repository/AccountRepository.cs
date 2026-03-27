using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankApp.Repository
{
    public class AccountRepository
    {
        private readonly List<TransactionModel> _transactions = new();

        public void AddTransaction(TransactionModel transaction)
        {
            _transactions.Add(transaction);
        }

        public List<TransactionModel> GetTransactionsBetween(DateTime start, DateTime end)
        {
            return _transactions
                .Where(t => t.Date >= start && t.Date <= end)
                .OrderBy(t => t.Date)
                .ToList();
        }

        public decimal GetBalanceBetween(DateTime start, DateTime end, Currency currency)
        {
            return GetTransactionsBetween(start, end)
                .Where(t => t.Currency == currency)
                .Sum(t => t.Amount);
        }
    }

}


