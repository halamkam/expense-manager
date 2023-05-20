namespace ProjectUI.Forms
{
    partial class AdminUserForm
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
            BackgroundPanel = new Panel();
            UserGridView = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(34, 33, 74);
            BackgroundPanel.Controls.Add(UserGridView);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(784, 561);
            BackgroundPanel.TabIndex = 1;
            // 
            // UserGridView
            // 
            UserGridView.AllowUserToAddRows = false;
            UserGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserGridView.BackgroundColor = Color.FromArgb(34, 33, 74);
            UserGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGridView.Columns.AddRange(new DataGridViewColumn[] { Username, Password });
            UserGridView.Dock = DockStyle.Fill;
            UserGridView.GridColor = Color.FromArgb(34, 33, 74);
            UserGridView.Location = new Point(0, 0);
            UserGridView.Name = "UserGridView";
            UserGridView.RowTemplate.Height = 25;
            UserGridView.Size = new Size(784, 561);
            UserGridView.TabIndex = 0;
            UserGridView.CellEndEdit += UserGridView_CellEndEdit;
            UserGridView.UserDeletingRow += UserGridView_UserDeletingRow;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // AdminUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(BackgroundPanel);
            Name = "AdminUserForm";
            Text = "Log";
            BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackgroundPanel;
        private DataGridView UserGridView;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
    }
}