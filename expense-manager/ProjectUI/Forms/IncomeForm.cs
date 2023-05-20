using BusinessContext.Enums;
using BusinessContext.Helpers;

namespace ProjectUI.Forms;

public partial class IncomeForm : Form
{
    public IncomeForm()
    {
        InitializeComponent();
    }

    private void IncomeForm_Load(object sender, EventArgs e)
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

        for (var i = 7; i < itemNames.Length; i++)
        {
            CategoryDropdownMenu.Items.Add(new ToolStripMenuItem(itemNames[i]));
        }
    }

    private void PaymentMethodButton_Click(object sender, EventArgs e)
    {
        PaymentMethodDDMenu.Show(CategoryButton, CategoryButton.Width, 0);
    }

    private void CategoryButton_Click(object sender, EventArgs e)
    {
        CategoryDropdownMenu.Show(CategoryButton, CategoryButton.Width, 0);
    }

    private async void AddIncomeButton_Click(object sender, EventArgs e)
    {
        var amount = AmountTextBox.Text;
        var from = FromTextBox.Text;
        var paymentMethod = PaymentMethodButton.Text;
        var date = DatePicker.Value;
        var category = CategoryButton.Text;
        var income = TransactionHelper.CreateTransaction(amount, from, paymentMethod, date, category, false);
        if (income == null)
        {
            return;
        }
        await DatabaseHelper.AddTransactionAsync(income);
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