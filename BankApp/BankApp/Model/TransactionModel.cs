using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankApp.Model
{

    // =========================
    // ENUMS
    // =========================
    public enum Category
    {
        Food,
        Transport,
        Salary,
        Leisure,
        Other
    }

    public enum Currency
    {
        EUR,
        USD
    }

    // =========================
    // MODELE
    // =========================
    public class TransactionModel
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public Currency Currency { get; }
        public Category Category { get; }

        public TransactionModel(DateTime date, decimal amount, Currency currency, Category category)
        {
            Date = date;
            Amount = amount;
            Currency = currency;
            Category = category;
        }
    }
}