using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankApp
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
    public class Transaction
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public Currency Currency { get; }
        public Category Category { get; }

        public Transaction(DateTime date, decimal amount, Currency currency, Category category)
        {
            Date = date;
            Amount = amount;
            Currency = currency;
            Category = category;
        }
    }
}