namespace ProjectUI.Forms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            AdminLogButton = new FontAwesome.Sharp.IconButton();
            LogoutButton = new FontAwesome.Sharp.IconButton();
            HistoryButton = new FontAwesome.Sharp.IconButton();
            IncomeButton = new FontAwesome.Sharp.IconButton();
            ExpenseButton = new FontAwesome.Sharp.IconButton();
            BalanceButton = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            HomeButton = new FontAwesome.Sharp.IconPictureBox();
            panelTitle = new Panel();
            titleOfChildForm = new Label();
            currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            ImportButton = new UIComponents.CustomButton();
            ExportButton = new UIComponents.CustomButton();
            WelcomeLabel = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ImportFileDialog = new OpenFileDialog();
            ExportBrowserDialog = new FolderBrowserDialog();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeButton).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentChildFormIcon).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(AdminLogButton);
            panelMenu.Controls.Add(LogoutButton);
            panelMenu.Controls.Add(HistoryButton);
            panelMenu.Controls.Add(IncomeButton);
            panelMenu.Controls.Add(ExpenseButton);
            panelMenu.Controls.Add(BalanceButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 561);
            panelMenu.TabIndex = 0;
            // 
            // AdminLogButton
            // 
            AdminLogButton.Dock = DockStyle.Top;
            AdminLogButton.FlatAppearance.BorderSize = 0;
            AdminLogButton.FlatStyle = FlatStyle.Flat;
            AdminLogButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLogButton.ForeColor = Color.Gainsboro;
            AdminLogButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            AdminLogButton.IconColor = Color.Gainsboro;
            AdminLogButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AdminLogButton.IconSize = 32;
            AdminLogButton.ImageAlign = ContentAlignment.MiddleLeft;
            AdminLogButton.Location = new Point(0, 465);
            AdminLogButton.Name = "AdminLogButton";
            AdminLogButton.Padding = new Padding(10, 0, 20, 0);
            AdminLogButton.Size = new Size(220, 65);
            AdminLogButton.TabIndex = 6;
            AdminLogButton.Text = "Users";
            AdminLogButton.TextAlign = ContentAlignment.MiddleLeft;
            AdminLogButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AdminLogButton.UseVisualStyleBackColor = true;
            AdminLogButton.Click += AdminLogButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Dock = DockStyle.Top;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.Gainsboro;
            LogoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            LogoutButton.IconColor = Color.Gainsboro;
            LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutButton.IconSize = 32;
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(0, 400);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Padding = new Padding(10, 0, 20, 0);
            LogoutButton.Size = new Size(220, 65);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Log Out";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.Dock = DockStyle.Top;
            HistoryButton.FlatAppearance.BorderSize = 0;
            HistoryButton.FlatStyle = FlatStyle.Flat;
            HistoryButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryButton.ForeColor = Color.Gainsboro;
            HistoryButton.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            HistoryButton.IconColor = Color.Gainsboro;
            HistoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HistoryButton.IconSize = 32;
            HistoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            HistoryButton.Location = new Point(0, 335);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Padding = new Padding(10, 0, 20, 0);
            HistoryButton.Size = new Size(220, 65);
            HistoryButton.TabIndex = 4;
            HistoryButton.Text = "History";
            HistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            HistoryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // IncomeButton
            // 
            IncomeButton.Dock = DockStyle.Top;
            IncomeButton.FlatAppearance.BorderSize = 0;
            IncomeButton.FlatStyle = FlatStyle.Flat;
            IncomeButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            IncomeButton.ForeColor = Color.Gainsboro;
            IncomeButton.IconChar = FontAwesome.Sharp.IconChar.Coins;
            IncomeButton.IconColor = Color.Gainsboro;
            IncomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IncomeButton.IconSize = 32;
            IncomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            IncomeButton.Location = new Point(0, 270);
            IncomeButton.Name = "IncomeButton";
            IncomeButton.Padding = new Padding(10, 0, 20, 0);
            IncomeButton.Size = new Size(220, 65);
            IncomeButton.TabIndex = 3;
            IncomeButton.Text = "Add Income";
            IncomeButton.TextAlign = ContentAlignment.MiddleLeft;
            IncomeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            IncomeButton.UseVisualStyleBackColor = true;
            IncomeButton.Click += IncomeButton_Click;
            // 
            // ExpenseButton
            // 
            ExpenseButton.Dock = DockStyle.Top;
            ExpenseButton.FlatAppearance.BorderSize = 0;
            ExpenseButton.FlatStyle = FlatStyle.Flat;
            ExpenseButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExpenseButton.ForeColor = Color.Gainsboro;
            ExpenseButton.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            ExpenseButton.IconColor = Color.Gainsboro;
            ExpenseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExpenseButton.IconSize = 32;
            ExpenseButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExpenseButton.Location = new Point(0, 205);
            ExpenseButton.Name = "ExpenseButton";
            ExpenseButton.Padding = new Padding(10, 0, 20, 0);
            ExpenseButton.Size = new Size(220, 65);
            ExpenseButton.TabIndex = 2;
            ExpenseButton.Text = "Add Expense";
            ExpenseButton.TextAlign = ContentAlignment.MiddleLeft;
            ExpenseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExpenseButton.UseVisualStyleBackColor = true;
            ExpenseButton.Click += ExpenseButton_Click;
            // 
            // BalanceButton
            // 
            BalanceButton.Dock = DockStyle.Top;
            BalanceButton.FlatAppearance.BorderSize = 0;
            BalanceButton.FlatStyle = FlatStyle.Flat;
            BalanceButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceButton.ForeColor = Color.Gainsboro;
            BalanceButton.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            BalanceButton.IconColor = Color.Gainsboro;
            BalanceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BalanceButton.IconSize = 32;
            BalanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            BalanceButton.Location = new Point(0, 140);
            BalanceButton.Name = "BalanceButton";
            BalanceButton.Padding = new Padding(10, 0, 20, 0);
            BalanceButton.Size = new Size(220, 65);
            BalanceButton.TabIndex = 1;
            BalanceButton.Text = "Balance";
            BalanceButton.TextAlign = ContentAlignment.MiddleLeft;
            BalanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BalanceButton.UseVisualStyleBackColor = true;
            BalanceButton.Click += DashboardButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(HomeButton);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(31, 30, 68);
            HomeButton.ForeColor = Color.Gainsboro;
            HomeButton.IconChar = FontAwesome.Sharp.IconChar.University;
            HomeButton.IconColor = Color.Gainsboro;
            HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeButton.IconSize = 80;
            HomeButton.Location = new Point(72, 30);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(80, 80);
            HomeButton.TabIndex = 1;
            HomeButton.TabStop = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(26, 25, 62);
            panelTitle.Controls.Add(titleOfChildForm);
            panelTitle.Controls.Add(currentChildFormIcon);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(564, 75);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += PanelTitle_MouseDown;
            // 
            // titleOfChildForm
            // 
            titleOfChildForm.AutoSize = true;
            titleOfChildForm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleOfChildForm.ForeColor = Color.Gainsboro;
            titleOfChildForm.Location = new Point(44, 36);
            titleOfChildForm.Name = "titleOfChildForm";
            titleOfChildForm.Size = new Size(45, 17);
            titleOfChildForm.TabIndex = 8;
            titleOfChildForm.Text = "Home";
            // 
            // currentChildFormIcon
            // 
            currentChildFormIcon.BackColor = Color.FromArgb(26, 25, 62);
            currentChildFormIcon.ForeColor = Color.MediumPurple;
            currentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            currentChildFormIcon.IconColor = Color.MediumPurple;
            currentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentChildFormIcon.Location = new Point(6, 30);
            currentChildFormIcon.Name = "currentChildFormIcon";
            currentChildFormIcon.Size = new Size(32, 32);
            currentChildFormIcon.TabIndex = 7;
            currentChildFormIcon.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(564, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(ImportButton);
            panelDesktop.Controls.Add(ExportButton);
            panelDesktop.Controls.Add(WelcomeLabel);
            panelDesktop.Controls.Add(iconPictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(564, 477);
            panelDesktop.TabIndex = 3;
            // 
            // ImportButton
            // 
            ImportButton.Anchor = AnchorStyles.None;
            ImportButton.BackColor = Color.MediumSlateBlue;
            ImportButton.BackgroundColor = Color.MediumSlateBlue;
            ImportButton.BorderColor = Color.PaleVioletRed;
            ImportButton.BorderRadius = 20;
            ImportButton.BorderSize = 0;
            ImportButton.FlatAppearance.BorderSize = 0;
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.ForeColor = Color.White;
            ImportButton.Location = new Point(90, 381);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(150, 40);
            ImportButton.TabIndex = 5;
            ImportButton.Text = "Import data (CSV)";
            ImportButton.TextColor = Color.White;
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Anchor = AnchorStyles.None;
            ExportButton.BackColor = Color.MediumSlateBlue;
            ExportButton.BackgroundColor = Color.MediumSlateBlue;
            ExportButton.BorderColor = Color.PaleVioletRed;
            ExportButton.BorderRadius = 20;
            ExportButton.BorderSize = 0;
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.ForeColor = Color.White;
            ExportButton.Location = new Point(332, 381);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(150, 40);
            ExportButton.TabIndex = 4;
            ExportButton.Text = "Export data (CSV)";
            ExportButton.TextColor = Color.White;
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.None;
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = Color.Gainsboro;
            WelcomeLabel.Location = new Point(44, 296);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(483, 45);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "Welcome to Expense Manager!";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.FromArgb(34, 33, 74);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.University;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 200;
            iconPictureBox1.Location = new Point(181, 56);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(200, 200);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // ImportFileDialog
            // 
            ImportFileDialog.DefaultExt = "csv";
            ImportFileDialog.Filter = "CSV files (*.csv)|*.csv";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            MinimumSize = new Size(800, 600);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Manager";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HomeButton).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentChildFormIcon).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton BalanceButton;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton AdminLogButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private FontAwesome.Sharp.IconButton HistoryButton;
        private FontAwesome.Sharp.IconButton IncomeButton;
        private FontAwesome.Sharp.IconButton ExpenseButton;
        private FontAwesome.Sharp.IconPictureBox HomeButton;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private Label titleOfChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Label WelcomeLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private UIComponents.CustomButton ExportButton;
        private UIComponents.CustomButton ImportButton;
        private OpenFileDialog ImportFileDialog;
        private FolderBrowserDialog ExportBrowserDialog;
    }
}