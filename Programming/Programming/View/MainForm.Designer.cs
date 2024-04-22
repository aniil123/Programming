
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
            this.EnumTabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.ThirdStageGroundBox = new System.Windows.Forms.GroupBox();
            this.SeasonResultLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SesonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SecondStageGroundBox = new System.Windows.Forms.GroupBox();
            this.ParseResultLabel = new System.Windows.Forms.Label();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseWeekDayTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.FirstStageGroudBox = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.EnumTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.ThirdStageGroundBox.SuspendLayout();
            this.SecondStageGroundBox.SuspendLayout();
            this.FirstStageGroudBox.SuspendLayout();
            this.Classes.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTabControl
            // 
            this.EnumTabControl.Controls.Add(this.Enums);
            this.EnumTabControl.Controls.Add(this.Classes);
            this.EnumTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumTabControl.Name = "EnumTabControl";
            this.EnumTabControl.SelectedIndex = 0;
            this.EnumTabControl.Size = new System.Drawing.Size(1234, 711);
            this.EnumTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.ThirdStageGroundBox);
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
            // ThirdStageGroundBox
            // 
            this.ThirdStageGroundBox.Controls.Add(this.SeasonResultLabel);
            this.ThirdStageGroundBox.Controls.Add(this.SeasonButton);
            this.ThirdStageGroundBox.Controls.Add(this.SesonLabel);
            this.ThirdStageGroundBox.Controls.Add(this.SeasonComboBox);
            this.ThirdStageGroundBox.Location = new System.Drawing.Point(618, 397);
            this.ThirdStageGroundBox.Name = "ThirdStageGroundBox";
            this.ThirdStageGroundBox.Size = new System.Drawing.Size(357, 217);
            this.ThirdStageGroundBox.TabIndex = 8;
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
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
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
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
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
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(324, 46);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntTextBox.TabIndex = 4;
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
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(168, 30);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.RectanglesGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(1226, 685);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleListBox);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(20, 19);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(275, 227);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(7, 32);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(126, 121);
            this.RectangleListBox.TabIndex = 8;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(152, 178);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(149, 111);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(149, 63);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(149, 16);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(152, 127);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(152, 79);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(152, 32);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.EnumTabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.EnumTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.ThirdStageGroundBox.ResumeLayout(false);
            this.ThirdStageGroundBox.PerformLayout();
            this.SecondStageGroundBox.ResumeLayout(false);
            this.SecondStageGroundBox.PerformLayout();
            this.FirstStageGroudBox.ResumeLayout(false);
            this.FirstStageGroudBox.PerformLayout();
            this.Classes.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumTabControl;
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
        private System.Windows.Forms.GroupBox ThirdStageGroundBox;
        private System.Windows.Forms.Label SesonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonResultLabel;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListBox RectangleListBox;
    }
}

