using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Repository
{
    public class Seed
    {
        public Seed() { }
        public void SeedAccount(AccountRepository account)
        {
            account.AddTransaction(new TransactionModel(new DateTime(2022, 1, 10), 1000, Currency.EUR, Category.Salary));
            account.AddTransaction(new TransactionModel(new DateTime(2022, 2, 15), -50, Currency.EUR, Category.Food));
            account.AddTransaction(new TransactionModel(new DateTime(2022, 3, 01), -20, Currency.USD, Category.Transport));
            account.AddTransaction(new TransactionModel(new DateTime(2022, 6, 1), 200, Currency.EUR, Category.Other));
            account.AddTransaction(new TransactionModel(new DateTime(2023, 1, 20), -100, Currency.EUR, Category.Leisure));
        }
    }
}
