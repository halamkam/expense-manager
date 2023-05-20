using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessContext.Enums;

namespace BusinessContext.Models;

public class Transaction
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("User")]
    public string Username { get; set; }
    public int Amount { get; set; }
    public PaymentMethod Method { get; set; }
    public DateTime Date { get; set; }
    public string Counterparty { get; set; }
    public Category Category { get; set; }
    public User User { get; set; }  // navigation property

    public Transaction() { }

    public Transaction(string user, int amount, PaymentMethod method, DateTime date, string counterparty, Category category)
    {
        Amount = amount;
        Method = method;
        Date = date;
        Username = user;
        Counterparty = counterparty;
        Category = category;
    }
}