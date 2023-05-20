using ProjectUI.UIComponents;

namespace ProjectUI.Forms
{
    partial class LoginForm
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
            LoginPanel = new Panel();
            BottomPanel = new Panel();
            RightDividerLabel = new Label();
            LeftDividerLabel = new Label();
            LabelOR = new Label();
            RightPanel = new Panel();
            LeftPanel = new Panel();
            UpperPanel = new Panel();
            LoginLabel = new Label();
            SignUpButton = new UIComponents.CustomButton();
            LoginButton = new UIComponents.CustomButton();
            PasswordTextBox = new CustomTextBox();
            UsernameTextBox = new CustomTextBox();
            LoginPanel.SuspendLayout();
            UpperPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(34, 33, 74);
            LoginPanel.Controls.Add(BottomPanel);
            LoginPanel.Controls.Add(RightDividerLabel);
            LoginPanel.Controls.Add(LeftDividerLabel);
            LoginPanel.Controls.Add(LabelOR);
            LoginPanel.Controls.Add(RightPanel);
            LoginPanel.Controls.Add(LeftPanel);
            LoginPanel.Controls.Add(UpperPanel);
            LoginPanel.Controls.Add(SignUpButton);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(PasswordTextBox);
            LoginPanel.Controls.Add(UsernameTextBox);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(784, 561);
            LoginPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.FromArgb(31, 30, 68);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(80, 481);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(624, 80);
            BottomPanel.TabIndex = 11;
            // 
            // RightDividerLabel
            // 
            RightDividerLabel.BorderStyle = BorderStyle.Fixed3D;
            RightDividerLabel.ForeColor = Color.White;
            RightDividerLabel.Location = new Point(420, 357);
            RightDividerLabel.Name = "RightDividerLabel";
            RightDividerLabel.Size = new Size(120, 2);
            RightDividerLabel.TabIndex = 10;
            RightDividerLabel.Text = "label2";
            // 
            // LeftDividerLabel
            // 
            LeftDividerLabel.BorderStyle = BorderStyle.Fixed3D;
            LeftDividerLabel.ForeColor = Color.White;
            LeftDividerLabel.Location = new Point(259, 357);
            LeftDividerLabel.Name = "LeftDividerLabel";
            LeftDividerLabel.Size = new Size(120, 2);
            LeftDividerLabel.TabIndex = 9;
            LeftDividerLabel.Text = "label1";
            // 
            // LabelOR
            // 
            LabelOR.AutoSize = true;
            LabelOR.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOR.ForeColor = Color.White;
            LabelOR.Location = new Point(384, 347);
            LabelOR.Name = "LabelOR";
            LabelOR.Size = new Size(30, 20);
            LabelOR.TabIndex = 8;
            LabelOR.Text = "OR";
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(31, 30, 68);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(704, 80);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(80, 481);
            RightPanel.TabIndex = 7;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(31, 30, 68);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 80);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(80, 481);
            LeftPanel.TabIndex = 6;
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.FromArgb(31, 30, 68);
            UpperPanel.Controls.Add(LoginLabel);
            UpperPanel.Dock = DockStyle.Top;
            UpperPanel.Location = new Point(0, 0);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(784, 80);
            UpperPanel.TabIndex = 5;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(350, 25);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(78, 32);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Login";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.MediumSlateBlue;
            SignUpButton.BackgroundColor = Color.MediumSlateBlue;
            SignUpButton.BorderColor = Color.PaleVioletRed;
            SignUpButton.BorderRadius = 20;
            SignUpButton.BorderSize = 0;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(290, 391);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(220, 40);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign Up";
            SignUpButton.TextColor = Color.White;
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.MediumSlateBlue;
            LoginButton.BackgroundColor = Color.MediumSlateBlue;
            LoginButton.BorderColor = Color.PaleVioletRed;
            LoginButton.BorderRadius = 20;
            LoginButton.BorderSize = 0;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(290, 280);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(220, 40);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.TextColor = Color.White;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(34, 33, 74);
            PasswordTextBox.BorderColor = Color.White;
            PasswordTextBox.BorderFocusColor = Color.MediumSlateBlue;
            PasswordTextBox.BorderRadius = 0;
            PasswordTextBox.BorderSize = 2;
            PasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(290, 203);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(10, 7, 10, 7);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.DarkGray;
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(220, 32);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UnderlinedStyle = true;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.FromArgb(34, 33, 74);
            UsernameTextBox.BorderColor = Color.White;
            UsernameTextBox.BorderFocusColor = Color.MediumSlateBlue;
            UsernameTextBox.BorderRadius = 0;
            UsernameTextBox.BorderSize = 2;
            UsernameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextBox.ForeColor = Color.White;
            UsernameTextBox.Location = new Point(290, 139);
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Padding = new Padding(10, 7, 10, 7);
            UsernameTextBox.PasswordChar = false;
            UsernameTextBox.PlaceholderColor = Color.DarkGray;
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new Size(220, 32);
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.UnderlinedStyle = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(LoginPanel);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            UpperPanel.ResumeLayout(false);
            UpperPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private CustomTextBox UsernameTextBox;
        private CustomTextBox PasswordTextBox;
        private CustomButton SignUpButton;
        private CustomButton LoginButton;
        private Panel UpperPanel;
        private Label LoginLabel;
        private Panel RightPanel;
        private Panel LeftPanel;
        private Label LabelOR;
        private Label RightDividerLabel;
        private Label LeftDividerLabel;
        private Panel BottomPanel;
    }
}