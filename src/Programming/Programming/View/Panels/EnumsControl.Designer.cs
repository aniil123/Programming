
namespace Programming.View.Panels
{
    partial class EnumsControl
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
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.IntLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.FirstStageGroudBox = new System.Windows.Forms.GroupBox();
            this.FirstStageGroudBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(168, 30);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(171, 46);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.ScrollAlwaysVisible = true;
            this.ValueListBox.Size = new System.Drawing.Size(130, 199);
            this.ValueListBox.TabIndex = 2;
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "Form_edu",
            "Genre",
            "Saeson",
            "Smartphones",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(19, 46);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(130, 199);
            this.EnumsListBox.TabIndex = 0;
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(16, 30);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsLabel.TabIndex = 1;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(321, 30);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(51, 13);
            this.IntLabel.TabIndex = 5;
            this.IntLabel.Text = "Int value:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(324, 46);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntTextBox.TabIndex = 4;
            // 
            // FirstStageGroudBox
            // 
            this.FirstStageGroudBox.Controls.Add(this.IntTextBox);
            this.FirstStageGroudBox.Controls.Add(this.IntLabel);
            this.FirstStageGroudBox.Controls.Add(this.EnumsLabel);
            this.FirstStageGroudBox.Controls.Add(this.EnumsListBox);
            this.FirstStageGroudBox.Controls.Add(this.ValueListBox);
            this.FirstStageGroudBox.Controls.Add(this.ValueLabel);
            this.FirstStageGroudBox.Location = new System.Drawing.Point(3, 3);
            this.FirstStageGroudBox.Name = "FirstStageGroudBox";
            this.FirstStageGroudBox.Size = new System.Drawing.Size(504, 306);
            this.FirstStageGroudBox.TabIndex = 7;
            this.FirstStageGroudBox.TabStop = false;
            this.FirstStageGroudBox.Text = "Enumerations";
            // 
            // EnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FirstStageGroudBox);
            this.Name = "EnumsControl";
            this.Size = new System.Drawing.Size(514, 313);
            this.FirstStageGroudBox.ResumeLayout(false);
            this.FirstStageGroudBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.GroupBox FirstStageGroudBox;
    }
}
