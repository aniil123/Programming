
namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.IntLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.FirstStageGroudBox = new System.Windows.Forms.GroupBox();
            this.SecondStageGroundBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseWeekDayTextBox = new System.Windows.Forms.TextBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseResultLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.FirstStageGroudBox.SuspendLayout();
            this.SecondStageGroundBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SecondStageGroundBox);
            this.Enums.Controls.Add(this.FirstStageGroudBox);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1226, 685);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
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
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
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
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // FirstStageGroudBox
            // 
            this.FirstStageGroudBox.Controls.Add(this.IntTextBox);
            this.FirstStageGroudBox.Controls.Add(this.IntLabel);
            this.FirstStageGroudBox.Controls.Add(this.EnumsLabel);
            this.FirstStageGroudBox.Controls.Add(this.EnumsListBox);
            this.FirstStageGroudBox.Controls.Add(this.ValueListBox);
            this.FirstStageGroudBox.Controls.Add(this.ValueLabel);
            this.FirstStageGroudBox.Location = new System.Drawing.Point(8, 20);
            this.FirstStageGroudBox.Name = "FirstStageGroudBox";
            this.FirstStageGroudBox.Size = new System.Drawing.Size(504, 306);
            this.FirstStageGroudBox.TabIndex = 6;
            this.FirstStageGroudBox.TabStop = false;
            this.FirstStageGroudBox.Text = "Enumerations";
            // 
            // SecondStageGroundBox
            // 
            this.SecondStageGroundBox.Controls.Add(this.ParseResultLabel);
            this.SecondStageGroundBox.Controls.Add(this.ParseLabel);
            this.SecondStageGroundBox.Controls.Add(this.ParseWeekDayTextBox);
            this.SecondStageGroundBox.Controls.Add(this.ParseButton);
            this.SecondStageGroundBox.Location = new System.Drawing.Point(9, 397);
            this.SecondStageGroundBox.Name = "SecondStageGroundBox";
            this.SecondStageGroundBox.Size = new System.Drawing.Size(392, 217);
            this.SecondStageGroundBox.TabIndex = 7;
            this.SecondStageGroundBox.TabStop = false;
            this.SecondStageGroundBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(249, 103);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseWeekDayTextBox
            // 
            this.ParseWeekDayTextBox.Location = new System.Drawing.Point(46, 106);
            this.ParseWeekDayTextBox.Name = "ParseWeekDayTextBox";
            this.ParseWeekDayTextBox.Size = new System.Drawing.Size(155, 20);
            this.ParseWeekDayTextBox.TabIndex = 1;
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
            // ParseResultLabel
            // 
            this.ParseResultLabel.AutoSize = true;
            this.ParseResultLabel.Location = new System.Drawing.Point(49, 133);
            this.ParseResultLabel.Name = "ParseResultLabel";
            this.ParseResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ParseResultLabel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.FirstStageGroudBox.ResumeLayout(false);
            this.FirstStageGroudBox.PerformLayout();
            this.SecondStageGroundBox.ResumeLayout(false);
            this.SecondStageGroundBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.GroupBox FirstStageGroudBox;
        private System.Windows.Forms.GroupBox SecondStageGroundBox;
        private System.Windows.Forms.Label ParseResultLabel;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.TextBox ParseWeekDayTextBox;
        private System.Windows.Forms.Button ParseButton;
    }
}

