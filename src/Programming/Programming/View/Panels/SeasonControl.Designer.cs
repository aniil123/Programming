
namespace Programming.View.Panels
{
    partial class SeasonControl
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
            this.ThirdStageGroundBox = new System.Windows.Forms.GroupBox();
            this.SeasonResultLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SesonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ThirdStageGroundBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThirdStageGroundBox
            // 
            this.ThirdStageGroundBox.Controls.Add(this.SeasonResultLabel);
            this.ThirdStageGroundBox.Controls.Add(this.SeasonButton);
            this.ThirdStageGroundBox.Controls.Add(this.SesonLabel);
            this.ThirdStageGroundBox.Controls.Add(this.SeasonComboBox);
            this.ThirdStageGroundBox.Location = new System.Drawing.Point(3, 3);
            this.ThirdStageGroundBox.Name = "ThirdStageGroundBox";
            this.ThirdStageGroundBox.Size = new System.Drawing.Size(357, 217);
            this.ThirdStageGroundBox.TabIndex = 9;
            this.ThirdStageGroundBox.TabStop = false;
            this.ThirdStageGroundBox.Text = "Season Handle";
            // 
            // SeasonResultLabel
            // 
            this.SeasonResultLabel.AutoSize = true;
            this.SeasonResultLabel.Location = new System.Drawing.Point(55, 145);
            this.SeasonResultLabel.Name = "SeasonResultLabel";
            this.SeasonResultLabel.Size = new System.Drawing.Size(0, 13);
            this.SeasonResultLabel.TabIndex = 3;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(230, 103);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            // 
            // SesonLabel
            // 
            this.SesonLabel.AutoSize = true;
            this.SesonLabel.Location = new System.Drawing.Point(52, 87);
            this.SesonLabel.Name = "SesonLabel";
            this.SesonLabel.Size = new System.Drawing.Size(80, 13);
            this.SesonLabel.TabIndex = 1;
            this.SesonLabel.Text = "Choose season";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(55, 106);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(137, 21);
            this.SeasonComboBox.TabIndex = 0;
            // 
            // SeasonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThirdStageGroundBox);
            this.Name = "SeasonControl";
            this.Size = new System.Drawing.Size(367, 227);
            this.ThirdStageGroundBox.ResumeLayout(false);
            this.ThirdStageGroundBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ThirdStageGroundBox;
        private System.Windows.Forms.Label SeasonResultLabel;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SesonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}
