
namespace Programming.View.Panels
{
    partial class WeekDayControl
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
            this.SecondStageGroundBox = new System.Windows.Forms.GroupBox();
            this.ParseResultLabel = new System.Windows.Forms.Label();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseWeekDayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SecondStageGroundBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecondStageGroundBox
            // 
            this.SecondStageGroundBox.Controls.Add(this.ParseResultLabel);
            this.SecondStageGroundBox.Controls.Add(this.ParseLabel);
            this.SecondStageGroundBox.Controls.Add(this.ParseWeekDayTextBox);
            this.SecondStageGroundBox.Controls.Add(this.ParseButton);
            this.SecondStageGroundBox.Location = new System.Drawing.Point(3, 3);
            this.SecondStageGroundBox.Name = "SecondStageGroundBox";
            this.SecondStageGroundBox.Size = new System.Drawing.Size(392, 217);
            this.SecondStageGroundBox.TabIndex = 8;
            this.SecondStageGroundBox.TabStop = false;
            this.SecondStageGroundBox.Text = "Weekday Parsing";
            // 
            // ParseResultLabel
            // 
            this.ParseResultLabel.AutoSize = true;
            this.ParseResultLabel.Location = new System.Drawing.Point(49, 133);
            this.ParseResultLabel.Name = "ParseResultLabel";
            this.ParseResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ParseResultLabel.TabIndex = 3;
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(46, 87);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(115, 13);
            this.ParseLabel.TabIndex = 2;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // ParseWeekDayTextBox
            // 
            this.ParseWeekDayTextBox.Location = new System.Drawing.Point(46, 106);
            this.ParseWeekDayTextBox.Name = "ParseWeekDayTextBox";
            this.ParseWeekDayTextBox.Size = new System.Drawing.Size(155, 20);
            this.ParseWeekDayTextBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(249, 103);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            // 
            // WeekDayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SecondStageGroundBox);
            this.Name = "WeekDayControl";
            this.Size = new System.Drawing.Size(400, 224);
            this.SecondStageGroundBox.ResumeLayout(false);
            this.SecondStageGroundBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SecondStageGroundBox;
        private System.Windows.Forms.Label ParseResultLabel;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.TextBox ParseWeekDayTextBox;
        private System.Windows.Forms.Button ParseButton;
    }
}
