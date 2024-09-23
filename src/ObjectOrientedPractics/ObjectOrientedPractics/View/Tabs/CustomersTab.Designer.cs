
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.RandomCustomerButton = new System.Windows.Forms.Button();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Controls.Add(this.AddressTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.IDLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.IDTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.AddressLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(360, 5);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(387, 637);
            this.SelectedCustomerGroupBox.TabIndex = 14;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(6, 108);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(375, 112);
            this.AddressTextBox.TabIndex = 10;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(7, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 62);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(66, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(179, 20);
            this.IDTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 92);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(66, 59);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(315, 20);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(4, 5);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(56, 13);
            this.ItemsLabel.TabIndex = 13;
            this.ItemsLabel.Text = "Customers";
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(124, 596);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(115, 46);
            this.RemoveCustomerButton.TabIndex = 12;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(4, 596);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(115, 46);
            this.AddCustomerButton.TabIndex = 11;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 26);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(350, 563);
            this.CustomersListBox.TabIndex = 10;
            // 
            // RandomCustomerButton
            // 
            this.RandomCustomerButton.Location = new System.Drawing.Point(246, 596);
            this.RandomCustomerButton.Name = "RandomCustomerButton";
            this.RandomCustomerButton.Size = new System.Drawing.Size(108, 46);
            this.RandomCustomerButton.TabIndex = 15;
            this.RandomCustomerButton.Text = "Random";
            this.RandomCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RandomCustomerButton);
            this.Controls.Add(this.SelectedCustomerGroupBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(750, 647);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button RandomCustomerButton;
    }
}
