using System.Runtime.InteropServices;
using BusinessContext.Data;
using BusinessContext.Helpers;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace ProjectUI.Forms;

public partial class MainMenuForm : Form
{
    private IconButton? _currentBtn;
    private readonly Panel _leftBorderBtn;
    private Form? _currentChildForm;

    public MainMenuForm(bool isAdmin)
    {
        InitializeComponent();
        _leftBorderBtn = new Panel
        {
            Size = new Size(7, 60)
        };
        panelMenu.Controls.Add(_leftBorderBtn);

        if (!isAdmin)
        {
            AdminLogButton.Hide();
        }
    }

    private readonly struct RgbColors
    {
        public static readonly Color Color1 = Color.FromArgb(172, 126, 241);
        public static readonly Color Color2 = Color.FromArgb(249, 118, 176);
        public static readonly Color Color3 = Color.FromArgb(253, 138, 114);
        public static readonly Color Color4 = Color.FromArgb(95, 77, 221);
        public static readonly Color Color5 = Color.FromArgb(249, 88, 155);
        public static readonly Color Color6 = Color.FromArgb(24, 161, 251);
    }

    private void ActivateButton(object senderBtn, Color color)
    {
        DisableButton();
        // Button
        _currentBtn = (IconButton)senderBtn;
        _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
        _currentBtn.ForeColor = color;
        _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
        _currentBtn.IconColor = color;
        _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
        _currentBtn.ImageAlign = ContentAlignment.MiddleRight;

        // Left border button
        _leftBorderBtn.BackColor = color;
        _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
        _leftBorderBtn.Visible = true;
        _leftBorderBtn.BringToFront();

        // Icon Current Child Form
        currentChildFormIcon.IconChar = _currentBtn.IconChar;
        currentChildFormIcon.IconColor = color;
    }

    private void DisableButton()
    {
        if (_currentBtn == null) return;
        _currentBtn.BackColor = Color.FromArgb(31, 30, 68);
        _currentBtn.ForeColor = Color.Gainsboro;
        _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
        _currentBtn.IconColor = Color.Gainsboro;
        _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
        _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
    }

    private void OpenChildForm(Form childForm)
    {
        _currentChildForm?.Close();

        _currentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        titleOfChildForm.Text = childForm.Text;
    }

    private void DashboardButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color1);
        OpenChildForm(new DashboardForm());
    }

    private void ExpenseButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color2);
        OpenChildForm(new ExpenseForm());
    }

    private void IncomeButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color3);
        OpenChildForm(new IncomeForm());
    }

    private void HistoryButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color4);
        OpenChildForm(new HistoryForm());
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color5);
        Application.Restart();
    }

    private void AdminLogButton_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RgbColors.Color6);
        OpenChildForm(new AdminUserForm());
    }

    private void HomeButton_Click(object sender, EventArgs e)
    {
        if (_currentChildForm == null) return;
        _currentChildForm.Close();
        Reset();
    }

    private void Reset()
    {
        DisableButton();
        _leftBorderBtn.Visible = false;
        currentChildFormIcon.IconChar = IconChar.Home;
        currentChildFormIcon.IconColor = Color.MediumPurple;
        titleOfChildForm.Text = @"Home";
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        Application.Exit();
    }

    // Drag form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private async void ExportButton_Click(object sender, EventArgs e)
    {
        var user = TransactionHelper.CurrentUser;

        if (ExportBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            await TransactionExport.ExportToCsv(await DatabaseHelper.GetTransactionsAsync(user!), user!.Username, ExportBrowserDialog.SelectedPath);
        }
    }

    private async void ImportButton_Click(object sender, EventArgs e)
    {
        if (ImportFileDialog.ShowDialog() == DialogResult.OK)
        {
            await TransactionImport.ImportFromCsv($"{ImportFileDialog.FileName}");
        }
    }
}