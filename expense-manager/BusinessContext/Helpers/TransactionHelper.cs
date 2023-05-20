using BusinessContext.Enums;
using BusinessContext.Models;

namespace BusinessContext.Helpers;

public static class TransactionHelper
{
    public static User? CurrentUser { get; set; }

    public static Transaction? CreateTransaction(string amount, string counterparty, string paymentMethod, DateTime date,
        string category, bool isExpense)
    {
        if (!int.TryParse(amount, out var actualAmount))
        {
            return null;
        }

        if (!Enum.TryParse(paymentMethod, out PaymentMethod actualPaymentMethod))
        {
            return null;
        }

        if (!Enum.TryParse(category, out Category actualCategory))
        {
            return null;
        }

        if (isExpense)
        {
            actualAmount = -actualAmount;
        }

        return new Transaction(CurrentUser!.Username, actualAmount, actualPaymentMethod, date, counterparty, actualCategory);
    }
}