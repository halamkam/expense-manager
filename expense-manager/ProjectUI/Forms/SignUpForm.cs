using BusinessContext.Enums;
using BusinessContext.Helpers;

namespace ProjectUI.Forms;

public partial class SignUpForm : Form
{

    public SignUpForm()
    {
        InitializeComponent();
    }

    private async void SignUpButton_Click(object sender, EventArgs e)
    {
        var error = await UserHelper.RegisterUser(UsernameTextBox.Text, PasswordTextBox.Text,
            ConfirmPasswordTextBox.Text);

        if (error == Input.None)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        if (error == Input.IncorrectConfirmPassword)
        {
            MessageBox.Show(@"Passwords don't match.");
        }

        if (error == Input.UserAlreadyExists)
        {
            MessageBox.Show($@"User {UsernameTextBox.Text} already exists.");
        }
    }
}