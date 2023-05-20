using BusinessContext.Database;
using BusinessContext.Helpers;

namespace ProjectUI.Forms;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
        InitializeBalance();
    }

    private void InitializeBalance()
    {
        using var db = new DatabaseContext();

        var balance = db.Transactions!
            .Where(t => t.User.Username == TransactionHelper.CurrentUser!.Username)
            .Select(t => t.Amount)
            .Sum();

        BalanceLabel.Text = $@"Current balance: {balance}";
    }
}
