using BusinessContext.Enums;
using BusinessContext.Helpers;

namespace ProjectUI.Forms;

public partial class ExpenseForm : Form
{
    public ExpenseForm()
    {
        InitializeComponent();
    }

    private void ExpenseForm_Load(object sender, EventArgs e)
    {
        CategoryDropdownMenu.IsMainMenu = true;
        PaymentMethodDDMenu.IsMainMenu = true;
        DatePicker.MaxDate = DateTime.Today;
        DatePicker.Value = DateTime.Today;
        FillPaymentDropdown();
        FillCategoryDropdown();
    }

    private void FillPaymentDropdown()
    {
        var itemNames = Enum.GetNames(typeof(PaymentMethod));

        foreach (var t in itemNames)
        {
            PaymentMethodDDMenu.Items.Add(new ToolStripMenuItem(t));
        }
    }

    private void FillCategoryDropdown()
    {
        var itemNames = Enum.GetNames(typeof(Category));

        for (var i = 0; i < 7; i++)
        {
            CategoryDropdownMenu.Items.Add(new ToolStripMenuItem(itemNames[i]));
        }
    }

    private void CategoryButton_Click_1(object sender, EventArgs e)
    {
        CategoryDropdownMenu.Show(CategoryButton, CategoryButton.Width, 0);
    }

    private void PaymentMethodButton_Click(object sender, EventArgs e)
    {
        PaymentMethodDDMenu.Show(CategoryButton, CategoryButton.Width, 0);
    }

    private async void AddExpenseButton_Click(object sender, EventArgs e)
    {
        var amount = AmountTextBox.Text;
        var to = ToTextBox.Text;
        var paymentMethod = PaymentMethodButton.Text;
        var date = DatePicker.Value;
        var category = CategoryButton.Text;
        var expense = TransactionHelper.CreateTransaction(amount, to, paymentMethod, date, category, true);
        if (expense == null)
        {
            return;
        }
        await DatabaseHelper.AddTransactionAsync(expense);
    }

    private void CategoryDropdownMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        CategoryButton.Text = e.ClickedItem.Text;
    }

    private void PaymentMethodDDMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        PaymentMethodButton.Text = e.ClickedItem.Text;
    }
}