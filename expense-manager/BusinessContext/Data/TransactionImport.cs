using CsvHelper;
using System.Globalization;
using BusinessContext.Helpers;
using BusinessContext.Models;

namespace BusinessContext.Data;

public static class TransactionImport
{
    public static async Task ImportFromCsv(string path)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<TransactionMap>();
        var records = csv.GetRecords<Transaction>();

        var transactions = records as Transaction[] ?? records.ToArray();
        if (transactions.Any(t => t.Username != TransactionHelper.CurrentUser!.Username))
        {
            return;
        }

        await DatabaseHelper.ImportTransactionsAsync(transactions);
    }
}