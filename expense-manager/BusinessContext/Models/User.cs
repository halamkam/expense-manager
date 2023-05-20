using System.ComponentModel.DataAnnotations;

namespace BusinessContext.Models;

public class User
{
    [Key]
    [Required]
    [MaxLength(30)]
    public string Username { get; set; }
    public string Password { get; set; }
    public ICollection<Transaction>? Transactions { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}