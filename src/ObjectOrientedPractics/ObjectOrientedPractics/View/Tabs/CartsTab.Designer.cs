namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(4, 25);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(350, 563);
            this.ItemsListBox.TabIndex = 0;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemLabel.Location = new System.Drawing.Point(4, 4);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemLabel.TabIndex = 1;
            this.ItemLabel.Text = "Items";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(4, 596);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(115, 46);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(360, 28);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(429, 25);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(314, 21);
            this.CustomerComboBox.TabIndex = 4;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(363, 60);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(29, 13);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(690, 252);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalCostLabel.Location = new System.Drawing.Point(689, 265);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(0, 24);
            this.TotalCostLabel.TabIndex = 8;
            this.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(366, 300);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(87, 31);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(563, 300);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(87, 31);
            this.RemoveItemButton.TabIndex = 10;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Location = new System.Drawing.Point(656, 300);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(87, 31);
            this.ClearCartButton.TabIndex = 11;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(366, 77);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(377, 160);
            this.CartListBox.TabIndex = 12;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(750, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.ListBox CartListBox;
    }
}
