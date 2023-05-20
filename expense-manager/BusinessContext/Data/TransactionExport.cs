using CsvHelper;
using System.Globalization;
using BusinessContext.Models;

namespace BusinessContext.Data;

public static class TransactionExport
{
    public static async Task ExportToCsv(IEnumerable<Transaction> transactions, string user, string path)
    {
        var records = transactions.Select(t => new
        {
            t.Username,
            t.Amount,
            t.Counterparty,
            Date = t.Date.ToString("MM'/'dd'/'yyyy", CultureInfo.InvariantCulture),
            PaymentMethod = t.Method,
            t.Category
        });
        await using var writer = new StreamWriter(path + $"\\{user}_transactions.csv");
        await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        await csv.WriteRecordsAsync(records);
    }
}