using BusinessContext.Database;
using BusinessContext.Enums;
using BusinessContext.Models;

namespace BusinessContext.Helpers;

public static class UserHelper
{
    public static async Task<Input> RegisterUser(string username, string password, string confirmPassword)
    {
        if (password != confirmPassword)
        {
            return Input.IncorrectConfirmPassword;
        }

        await using (var db = new DatabaseContext())
        {
            if (await db.Users!.FindAsync(username) != null)
            {
                return Input.UserAlreadyExists;
            }
        }

        var user = new User(username, password);
        await DatabaseHelper.AddUserAsync(user);
        TransactionHelper.CurrentUser = user;

        return Input.None;
    }

    public static async Task<Input> AuthenticateUser(string username, string password)
    {
        await using (var db = new DatabaseContext())
        {
            var user = await db.Users!.FindAsync(username);

            if (user == null)
            {
                return Input.UserNotFound;
            }

            if (user.Password != password)
            {
                return Input.IncorrectPassword;
            }

            TransactionHelper.CurrentUser = user;
        }

        return username == "root" ? Input.Admin : Input.None;
    }
}