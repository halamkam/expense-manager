using BusinessContext.Database;
using BusinessContext.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessContext.Helpers;

public static class DatabaseHelper
{
    public static async Task AddUserAsync(User user)
    {
        await using var dbContext = new DatabaseContext();
        dbContext.Users!.Add(user);
        await dbContext.SaveChangesAsync();
    }

    public static async Task AddTransactionAsync(Transaction transaction)
    {
        await using var dbContext = new DatabaseContext();
        await dbContext.Transactions!.AddAsync(transaction);
        await dbContext.SaveChangesAsync();
    }

    public static async Task<IEnumerable<Transaction>> GetTransactionsAsync(User user)
    {
        await using var dbContext = new DatabaseContext();
        return await dbContext.Transactions!
            .Where(t => t.Username == user.Username)
            .ToListAsync();
    }

    public static async Task ImportTransactionsAsync(IEnumerable<Transaction> transactions)
    {
        await using var dbContext = new DatabaseContext();

        foreach (var transaction in transactions)
        {
            await dbContext.Transactions!.AddAsync(transaction);
        }

        await dbContext.SaveChangesAsync();
    }
}