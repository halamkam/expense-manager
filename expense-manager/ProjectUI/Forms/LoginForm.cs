using BusinessContext.Enums;
using BusinessContext.Helpers;

namespace ProjectUI.Forms;

public partial class LoginForm : Form
{
    public bool IsAdmin { get; private set; }

    public LoginForm()
    {
        InitializeComponent();
    }

    private async void LoginButton_Click(object sender, EventArgs e)
    {
        var evaluation = await UserHelper.AuthenticateUser(UsernameTextBox.Text, PasswordTextBox.Text);

        if (evaluation == Input.Admin)
        {
            DialogResult = DialogResult.OK;
            IsAdmin = true;
            Close();
        }

        if (evaluation == Input.None)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        if (evaluation == Input.UserNotFound)
        {
            MessageBox.Show($@"User {UsernameTextBox.Text} does not exist.");
        }

        if (evaluation == Input.IncorrectPassword)
        {
            MessageBox.Show(@"Incorrect password");
        }
    }

    private void SignUpButton_Click(object sender, EventArgs e)
    {
        Hide();
        var signUpForm = new SignUpForm();
        signUpForm.ShowDialog();

        if (signUpForm.DialogResult == DialogResult.Cancel)
        {
            Show();
        }

        if (signUpForm.DialogResult == DialogResult.OK)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}