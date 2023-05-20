using BusinessContext.Models;
using CsvHelper.Configuration;

namespace BusinessContext.Data;

public sealed class TransactionMap : ClassMap<Transaction>
{
    public TransactionMap()
    {
        Map(t => t.Username).Name("Username");
        Map(t => t.Amount).Name("Amount");
        Map(t => t.Counterparty).Name("Counterparty");
        Map(t => t.Date).Name("Date");
        Map(t => t.Method).Name("PaymentMethod");
        Map(t => t.Category).Name("Category");
    }
}