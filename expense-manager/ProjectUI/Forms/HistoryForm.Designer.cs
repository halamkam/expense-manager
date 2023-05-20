namespace ProjectUI.Forms
{
    partial class HistoryForm
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
            HistoryGridView = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Method = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Counterparty = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).BeginInit();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(34, 33, 74);
            BackgroundPanel.Controls.Add(HistoryGridView);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(969, 561);
            BackgroundPanel.TabIndex = 0;
            // 
            // HistoryGridView
            // 
            HistoryGridView.AllowUserToAddRows = false;
            HistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryGridView.BackgroundColor = Color.FromArgb(34, 33, 74);
            HistoryGridView.BorderStyle = BorderStyle.None;
            HistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGridView.Columns.AddRange(new DataGridViewColumn[] { Username, Amount, Method, Date, Counterparty, Category });
            HistoryGridView.Dock = DockStyle.Fill;
            HistoryGridView.GridColor = Color.FromArgb(34, 33, 74);
            HistoryGridView.Location = new Point(0, 0);
            HistoryGridView.Name = "HistoryGridView";
            HistoryGridView.RowTemplate.Height = 25;
            HistoryGridView.Size = new Size(969, 561);
            HistoryGridView.TabIndex = 0;
            HistoryGridView.CellEndEdit += HistoryGridView_CellEndEdit;
            HistoryGridView.UserDeletingRow += HistoryGridView_UserDeletingRow;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Method
            // 
            Method.DataPropertyName = "Method";
            Method.HeaderText = "Method";
            Method.Name = "Method";
            Method.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Counterparty
            // 
            Counterparty.DataPropertyName = "Counterparty";
            Counterparty.HeaderText = "To / From";
            Counterparty.Name = "Counterparty";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 561);
            Controls.Add(BackgroundPanel);
            Name = "HistoryForm";
            Text = "History";
            BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HistoryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackgroundPanel;
        private DataGridView HistoryGridView;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Counterparty;
        private DataGridViewTextBoxColumn Category;
    }
}