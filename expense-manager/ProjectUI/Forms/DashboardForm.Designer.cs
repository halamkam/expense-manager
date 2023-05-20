namespace ProjectUI.Forms
{
    partial class DashboardForm
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
            BalanceLabel = new Label();
            BackgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(34, 33, 74);
            BackgroundPanel.Controls.Add(BalanceLabel);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(784, 561);
            BackgroundPanel.TabIndex = 1;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Dock = DockStyle.Fill;
            BalanceLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLabel.ForeColor = Color.White;
            BalanceLabel.Location = new Point(0, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(784, 561);
            BalanceLabel.TabIndex = 0;
            BalanceLabel.Text = "Balance";
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(BackgroundPanel);
            Name = "DashboardForm";
            Text = "Dashboard";
            BackgroundPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BackgroundPanel;
        private Label BalanceLabel;
    }
}