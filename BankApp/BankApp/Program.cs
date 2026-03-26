using BankApp;
using System.Security.Principal;
using System.Transactions;
using Transaction = BankApp.Transaction;

public class Program
{
    static void Main(string[] args)
    {
        var account = new Account();
        Seed(account);

        var exporter = new CsvExporter();
        var feature = new ExportFeature(account, exporter);

        feature.Execute();
    }

    static void Seed(Account account)
    {
        account.AddTransaction(new Transaction(new DateTime(2022, 1, 10), 1000, Currency.EUR, Category.Salary));
        account.AddTransaction(new Transaction(new DateTime(2022, 2, 15), -50, Currency.EUR, Category.Food));
        account.AddTransaction(new Transaction(new DateTime(2022, 3, 01), -20, Currency.USD, Category.Transport));
        account.AddTransaction(new Transaction(new DateTime(2022, 6, 1), 200, Currency.EUR, Category.Other));
        account.AddTransaction(new Transaction(new DateTime(2023, 1, 20), -100, Currency.EUR, Category.Leisure));
    }
} 