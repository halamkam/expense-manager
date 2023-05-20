using BusinessContext.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessContext.Database;

public sealed class DatabaseContext : DbContext
{
    private const string ConnectionString = @"server=(localdb)\MSSQLLocalDB; Initial Catalog=TransactionDB; Integrated Security=true";

    public DbSet<User>? Users { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }

    public DatabaseContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User("root", "root"));

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.User)
            .WithMany(u => u.Transactions)
            .HasForeignKey(t => t.Username);

        base.OnModelCreating(modelBuilder);
    }
}