using ProjectUI.UIComponents;

namespace ProjectUI.Forms
{
    partial class ExpenseForm
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
            components = new System.ComponentModel.Container();
            BackgroundPanel = new Panel();
            PaymentMethodButton = new CustomButton();
            ToTextBox = new CustomTextBox();
            CategoryButton = new CustomButton();
            DatePicker = new CustomDatePicker();
            AmountTextBox = new CustomTextBox();
            AddExpenseButton = new CustomButton();
            CategoryDropdownMenu = new CustomDropdownMenu(components);
            PaymentMethodDDMenu = new CustomDropdownMenu(components);
            BackgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(34, 33, 74);
            BackgroundPanel.Controls.Add(PaymentMethodButton);
            BackgroundPanel.Controls.Add(ToTextBox);
            BackgroundPanel.Controls.Add(CategoryButton);
            BackgroundPanel.Controls.Add(DatePicker);
            BackgroundPanel.Controls.Add(AmountTextBox);
            BackgroundPanel.Controls.Add(AddExpenseButton);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.Size = new Size(784, 561);
            BackgroundPanel.TabIndex = 0;
            // 
            // PaymentMethodButton
            // 
            PaymentMethodButton.Anchor = AnchorStyles.None;
            PaymentMethodButton.BackColor = Color.MediumSlateBlue;
            PaymentMethodButton.BackgroundColor = Color.MediumSlateBlue;
            PaymentMethodButton.BorderColor = Color.White;
            PaymentMethodButton.BorderRadius = 0;
            PaymentMethodButton.BorderSize = 1;
            PaymentMethodButton.FlatAppearance.BorderSize = 0;
            PaymentMethodButton.FlatStyle = FlatStyle.Flat;
            PaymentMethodButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentMethodButton.ForeColor = Color.White;
            PaymentMethodButton.Location = new Point(423, 156);
            PaymentMethodButton.Name = "PaymentMethodButton";
            PaymentMethodButton.Size = new Size(220, 40);
            PaymentMethodButton.TabIndex = 14;
            PaymentMethodButton.Text = "Method";
            PaymentMethodButton.TextColor = Color.White;
            PaymentMethodButton.UseVisualStyleBackColor = false;
            PaymentMethodButton.Click += PaymentMethodButton_Click;
            // 
            // ToTextBox
            // 
            ToTextBox.Anchor = AnchorStyles.None;
            ToTextBox.BackColor = Color.FromArgb(34, 33, 74);
            ToTextBox.BorderColor = Color.White;
            ToTextBox.BorderFocusColor = Color.MediumSlateBlue;
            ToTextBox.BorderRadius = 0;
            ToTextBox.BorderSize = 2;
            ToTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToTextBox.ForeColor = Color.White;
            ToTextBox.Location = new Point(153, 224);
            ToTextBox.Multiline = false;
            ToTextBox.Name = "ToTextBox";
            ToTextBox.Padding = new Padding(10, 7, 10, 7);
            ToTextBox.PasswordChar = false;
            ToTextBox.PlaceholderColor = Color.DarkGray;
            ToTextBox.PlaceholderText = "To";
            ToTextBox.Size = new Size(220, 32);
            ToTextBox.TabIndex = 13;
            ToTextBox.UnderlinedStyle = true;
            // 
            // CategoryButton
            // 
            CategoryButton.Anchor = AnchorStyles.None;
            CategoryButton.BackColor = Color.MediumSlateBlue;
            CategoryButton.BackgroundColor = Color.MediumSlateBlue;
            CategoryButton.BorderColor = Color.White;
            CategoryButton.BorderRadius = 0;
            CategoryButton.BorderSize = 1;
            CategoryButton.FlatAppearance.BorderSize = 0;
            CategoryButton.FlatStyle = FlatStyle.Flat;
            CategoryButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryButton.ForeColor = Color.White;
            CategoryButton.Location = new Point(423, 216);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(220, 40);
            CategoryButton.TabIndex = 12;
            CategoryButton.Text = "Category";
            CategoryButton.TextColor = Color.White;
            CategoryButton.UseVisualStyleBackColor = false;
            CategoryButton.Click += CategoryButton_Click_1;
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.None;
            DatePicker.BorderColor = Color.White;
            DatePicker.BorderSize = 1;
            DatePicker.CustomFormat = "";
            DatePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            DatePicker.Format = DateTimePickerFormat.Short;
            DatePicker.Location = new Point(285, 298);
            DatePicker.MaxDate = new DateTime(2023, 4, 28, 0, 0, 0, 0);
            DatePicker.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            DatePicker.MinimumSize = new Size(0, 35);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(220, 35);
            DatePicker.SkinColor = Color.MediumSlateBlue;
            DatePicker.TabIndex = 11;
            DatePicker.TextColor = Color.White;
            DatePicker.Value = new DateTime(2023, 4, 28, 0, 0, 0, 0);
            // 
            // AmountTextBox
            // 
            AmountTextBox.Anchor = AnchorStyles.None;
            AmountTextBox.BackColor = Color.FromArgb(34, 33, 74);
            AmountTextBox.BorderColor = Color.White;
            AmountTextBox.BorderFocusColor = Color.MediumSlateBlue;
            AmountTextBox.BorderRadius = 0;
            AmountTextBox.BorderSize = 2;
            AmountTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTextBox.ForeColor = Color.White;
            AmountTextBox.Location = new Point(153, 156);
            AmountTextBox.Multiline = false;
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Padding = new Padding(10, 7, 10, 7);
            AmountTextBox.PasswordChar = false;
            AmountTextBox.PlaceholderColor = Color.DarkGray;
            AmountTextBox.PlaceholderText = "Amount";
            AmountTextBox.Size = new Size(220, 32);
            AmountTextBox.TabIndex = 10;
            AmountTextBox.UnderlinedStyle = true;
            // 
            // AddExpenseButton
            // 
            AddExpenseButton.Anchor = AnchorStyles.None;
            AddExpenseButton.BackColor = Color.DarkSlateBlue;
            AddExpenseButton.BackgroundColor = Color.DarkSlateBlue;
            AddExpenseButton.BorderColor = Color.PaleVioletRed;
            AddExpenseButton.BorderRadius = 20;
            AddExpenseButton.BorderSize = 0;
            AddExpenseButton.FlatAppearance.BorderSize = 0;
            AddExpenseButton.FlatStyle = FlatStyle.Flat;
            AddExpenseButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddExpenseButton.ForeColor = Color.White;
            AddExpenseButton.Location = new Point(257, 380);
            AddExpenseButton.Name = "AddExpenseButton";
            AddExpenseButton.Size = new Size(270, 40);
            AddExpenseButton.TabIndex = 9;
            AddExpenseButton.Text = "Add expense";
            AddExpenseButton.TextColor = Color.White;
            AddExpenseButton.UseVisualStyleBackColor = false;
            AddExpenseButton.Click += AddExpenseButton_Click;
            // 
            // CategoryDropdownMenu
            // 
            CategoryDropdownMenu.IsMainMenu = false;
            CategoryDropdownMenu.MenuItemHeight = 25;
            CategoryDropdownMenu.MenuItemTextColor = Color.Empty;
            CategoryDropdownMenu.Name = "rjDropdownMenu1";
            CategoryDropdownMenu.PrimaryColor = Color.Empty;
            CategoryDropdownMenu.Size = new Size(61, 4);
            CategoryDropdownMenu.ItemClicked += CategoryDropdownMenu_ItemClicked;
            // 
            // PaymentMethodDDMenu
            // 
            PaymentMethodDDMenu.IsMainMenu = false;
            PaymentMethodDDMenu.MenuItemHeight = 25;
            PaymentMethodDDMenu.MenuItemTextColor = Color.Empty;
            PaymentMethodDDMenu.Name = "rjDropdownMenu1";
            PaymentMethodDDMenu.PrimaryColor = Color.Empty;
            PaymentMethodDDMenu.Size = new Size(61, 4);
            PaymentMethodDDMenu.ItemClicked += PaymentMethodDDMenu_ItemClicked;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(BackgroundPanel);
            Name = "ExpenseForm";
            Text = "Expense";
            Load += ExpenseForm_Load;
            BackgroundPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BackgroundPanel;
        private CustomButton AddExpenseButton;
        private CustomDropdownMenu CategoryDropdownMenu;
        private CustomButton PaymentMethodButton;
        private CustomTextBox ToTextBox;
        private CustomButton CategoryButton;
        private CustomDatePicker DatePicker;
        private CustomTextBox AmountTextBox;
        private CustomDropdownMenu PaymentMethodDDMenu;
    }
}