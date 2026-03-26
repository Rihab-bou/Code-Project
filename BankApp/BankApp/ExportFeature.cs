using BankApp;
using System.Globalization;

// =========================
// FEATURE
// =========================

public class ExportFeature
{
        private readonly Account _account;
        private readonly CsvExporter _exporter;

        public ExportFeature(Account account, CsvExporter exporter)
        {
            _account = account;
            _exporter = exporter;
        }

        public void Execute()
        {
            Console.Write("Date de début (yyyy-MM-dd) : ");
            var startInput = Console.ReadLine();

            Console.Write("Date de fin (yyyy-MM-dd) : ");
            var endInput = Console.ReadLine();

            Console.Write("Devise (EUR/USD) : ");
            var currencyInput = Console.ReadLine();

            if (!DateTime.TryParseExact(startInput, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime start) ||
                !DateTime.TryParseExact(endInput, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime end))
            {
                Console.WriteLine("Format de date invalide.");
                return;
            }

            if (!Enum.TryParse(currencyInput, true, out Currency currency))
            {
                Console.WriteLine("Devise invalide.");
                return;
            }

            if (start > end)
            {
                Console.WriteLine("La date de début doit être avant la date de fin.");
                return;
            }

            var transactions = _account.GetTransactionsBetween(start, end)
                .Where(t => t.Currency == currency)
                .ToList();

            var balance = _account.GetBalanceBetween(start, end, currency);

            Console.WriteLine($"Transactions trouvées : {transactions.Count}");
            Console.WriteLine($"Solde ({currency}) : {balance:F2}");

            var filePath = "transactions.csv";
            _exporter.Export(filePath, transactions);

            Console.WriteLine($"Export CSV généré : {filePath}");
        }
}
