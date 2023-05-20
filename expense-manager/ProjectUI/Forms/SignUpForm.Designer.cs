using ProjectUI.UIComponents;

namespace ProjectUI.Forms
{
    partial class SignUpForm
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
            SignUpPanel = new Panel();
            SignUpButton = new UIComponents.CustomButton();
            ConfirmPasswordTextBox = new CustomTextBox();
            PasswordTextBox = new CustomTextBox();
            UsernameTextBox = new CustomTextBox();
            BottomPanel = new Panel();
            RightPanel = new Panel();
            LeftPanel = new Panel();
            UpperPanel = new Panel();
            SignUpLabel = new Label();
            SignUpPanel.SuspendLayout();
            UpperPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SignUpPanel
            // 
            SignUpPanel.BackColor = Color.FromArgb(34, 33, 74);
            SignUpPanel.Controls.Add(SignUpButton);
            SignUpPanel.Controls.Add(ConfirmPasswordTextBox);
            SignUpPanel.Controls.Add(PasswordTextBox);
            SignUpPanel.Controls.Add(UsernameTextBox);
            SignUpPanel.Controls.Add(BottomPanel);
            SignUpPanel.Controls.Add(RightPanel);
            SignUpPanel.Controls.Add(LeftPanel);
            SignUpPanel.Controls.Add(UpperPanel);
            SignUpPanel.Dock = DockStyle.Fill;
            SignUpPanel.Location = new Point(0, 0);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(784, 561);
            SignUpPanel.TabIndex = 0;
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
            SignUpButton.Location = new Point(287, 355);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(220, 40);
            SignUpButton.TabIndex = 16;
            SignUpButton.Text = "Sign Up";
            SignUpButton.TextColor = Color.White;
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.BackColor = Color.FromArgb(34, 33, 74);
            ConfirmPasswordTextBox.BorderColor = Color.White;
            ConfirmPasswordTextBox.BorderFocusColor = Color.MediumSlateBlue;
            ConfirmPasswordTextBox.BorderRadius = 0;
            ConfirmPasswordTextBox.BorderSize = 2;
            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPasswordTextBox.ForeColor = Color.White;
            ConfirmPasswordTextBox.Location = new Point(287, 280);
            ConfirmPasswordTextBox.Multiline = false;
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Padding = new Padding(10, 7, 10, 7);
            ConfirmPasswordTextBox.PasswordChar = true;
            ConfirmPasswordTextBox.PlaceholderColor = Color.DarkGray;
            ConfirmPasswordTextBox.PlaceholderText = "Confirm Password";
            ConfirmPasswordTextBox.Size = new Size(220, 32);
            ConfirmPasswordTextBox.TabIndex = 15;
            ConfirmPasswordTextBox.UnderlinedStyle = true;
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
            PasswordTextBox.Location = new Point(287, 210);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(10, 7, 10, 7);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.DarkGray;
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(220, 32);
            PasswordTextBox.TabIndex = 14;
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
            UsernameTextBox.Location = new Point(287, 140);
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Padding = new Padding(10, 7, 10, 7);
            UsernameTextBox.PasswordChar = false;
            UsernameTextBox.PlaceholderColor = Color.DarkGray;
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new Size(220, 32);
            UsernameTextBox.TabIndex = 13;
            UsernameTextBox.UnderlinedStyle = true;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.FromArgb(31, 30, 68);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(80, 481);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(624, 80);
            BottomPanel.TabIndex = 12;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(31, 30, 68);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(704, 80);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(80, 481);
            RightPanel.TabIndex = 8;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(31, 30, 68);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 80);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(80, 481);
            LeftPanel.TabIndex = 7;
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.FromArgb(31, 30, 68);
            UpperPanel.Controls.Add(SignUpLabel);
            UpperPanel.Dock = DockStyle.Top;
            UpperPanel.Location = new Point(0, 0);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(784, 80);
            UpperPanel.TabIndex = 6;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLabel.ForeColor = Color.White;
            SignUpLabel.Location = new Point(338, 25);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(94, 32);
            SignUpLabel.TabIndex = 4;
            SignUpLabel.Text = "Signup";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(SignUpPanel);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            SignUpPanel.ResumeLayout(false);
            UpperPanel.ResumeLayout(false);
            UpperPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SignUpPanel;
        private Panel UpperPanel;
        private Label SignUpLabel;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Panel BottomPanel;
        private CustomTextBox UsernameTextBox;
        private CustomTextBox ConfirmPasswordTextBox;
        private CustomTextBox PasswordTextBox;
        private CustomButton SignUpButton;
    }
}