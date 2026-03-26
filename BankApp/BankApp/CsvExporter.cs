using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BankApp
{
    public class CsvExporter
    {
        public void Export(string filePath, List<Transaction> transactions)
        {
            using var writer = new StreamWriter(filePath);

            writer.WriteLine("Date;Montant;Devise;Categorie");

            foreach (var t in transactions)
            {
                writer.WriteLine($"{t.Date:yyyy-MM-dd};{t.Amount};{t.Currency};{t.Category}");
            }
        }
    }
}
