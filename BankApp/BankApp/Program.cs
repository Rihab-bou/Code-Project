using BankApp;
using BankApp.FileExporter;
using BankApp.Model;
using BankApp.Repository;
using System.Security.Principal;
using System.Transactions;
using TransactionModel = BankApp.Model.TransactionModel;

public class Program
{
    static void Main(string[] args)
    {
        var account = new AccountRepository();
        var seed = new Seed();
        seed.SeedAccount(account);
        var exporter = new CsvExporter();
        var feature = new ExportFeature(account, exporter);

        feature.Execute();
    }

    
} 