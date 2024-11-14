namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ProductsAmountLabel = new System.Windows.Forms.Label();
            this.AmountDiscountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.AmountProductsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(24, 20);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(13, 49);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(175, 49);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(94, 49);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // ProductsAmountLabel
            // 
            this.ProductsAmountLabel.AutoSize = true;
            this.ProductsAmountLabel.Location = new System.Drawing.Point(265, 20);
            this.ProductsAmountLabel.Name = "ProductsAmountLabel";
            this.ProductsAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.ProductsAmountLabel.TabIndex = 4;
            this.ProductsAmountLabel.Text = "Products Amount:";
            // 
            // AmountDiscountLabel
            // 
            this.AmountDiscountLabel.AutoSize = true;
            this.AmountDiscountLabel.Location = new System.Drawing.Point(326, 91);
            this.AmountDiscountLabel.Name = "AmountDiscountLabel";
            this.AmountDiscountLabel.Size = new System.Drawing.Size(13, 13);
            this.AmountDiscountLabel.TabIndex = 5;
            this.AmountDiscountLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(265, 68);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.DiscountAmountLabel.TabIndex = 6;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // AmountProductsLabel
            // 
            this.AmountProductsLabel.AutoSize = true;
            this.AmountProductsLabel.Location = new System.Drawing.Point(326, 43);
            this.AmountProductsLabel.Name = "AmountProductsLabel";
            this.AmountProductsLabel.Size = new System.Drawing.Size(13, 13);
            this.AmountProductsLabel.TabIndex = 7;
            this.AmountProductsLabel.Text = "0";
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountProductsLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.AmountDiscountLabel);
            this.Controls.Add(this.ProductsAmountLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InfoLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(451, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label ProductsAmountLabel;
        private System.Windows.Forms.Label AmountDiscountLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label AmountProductsLabel;
    }
}
