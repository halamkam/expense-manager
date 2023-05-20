using ProjectUI.Forms;

namespace ProjectUI;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        var loginForm = new LoginForm();

        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            Application.Run(new MainMenuForm(loginForm.IsAdmin));
        }
    }
}
