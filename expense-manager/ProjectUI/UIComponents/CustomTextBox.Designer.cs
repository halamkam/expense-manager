namespace ProjectUI.UIComponents
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox = new TextBox();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Dock = DockStyle.Fill;
            TextBox.Location = new Point(10, 7);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(230, 18);
            TextBox.TabIndex = 0;
            TextBox.Click += TextBox_Click;
            TextBox.TextChanged += TextBox_TextChanged;
            TextBox.Enter += TextBox_Enter;
            TextBox.KeyPress += TextBox_KeyPress;
            TextBox.Leave += TextBox_Leave;
            TextBox.MouseEnter += TextBox_MouseEnter;
            TextBox.MouseLeave += TextBox_MouseLeave;
            // 
            // CustomTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(TextBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.GrayText;
            Name = "CustomTextBox";
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
    }
}
