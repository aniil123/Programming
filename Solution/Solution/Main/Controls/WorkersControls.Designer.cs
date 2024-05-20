
namespace Solution.Main.Controls
{
    partial class WorkersControls
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
            this.WorkersListBox = new System.Windows.Forms.ListBox();
            this.SelectedWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.ErrorCalendarPanel = new System.Windows.Forms.Panel();
            this.ErrorCalendarLabel = new System.Windows.Forms.Label();
            this.DateOfEmploymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.DateOfEmploymentLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RedactPictureBox = new System.Windows.Forms.PictureBox();
            this.DeletePictureBox = new System.Windows.Forms.PictureBox();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.SelectedWorkerGroupBox.SuspendLayout();
            this.ErrorCalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.Location = new System.Drawing.Point(4, 4);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(333, 537);
            this.WorkersListBox.TabIndex = 0;
            this.WorkersListBox.SelectedIndexChanged += new System.EventHandler(this.WorkersListBox_SelectedIndexChanged);
            // 
            // SelectedWorkerGroupBox
            // 
            this.SelectedWorkerGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.DateOfEmploymentDateTimePicker);
            this.SelectedWorkerGroupBox.Controls.Add(this.ErrorCalendarPanel);
            this.SelectedWorkerGroupBox.Controls.Add(this.PostTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.DateOfEmploymentLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.PostLabel);
            this.SelectedWorkerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedWorkerGroupBox.Location = new System.Drawing.Point(344, 4);
            this.SelectedWorkerGroupBox.Name = "SelectedWorkerGroupBox";
            this.SelectedWorkerGroupBox.Size = new System.Drawing.Size(523, 188);
            this.SelectedWorkerGroupBox.TabIndex = 1;
            this.SelectedWorkerGroupBox.TabStop = false;
            this.SelectedWorkerGroupBox.Text = "Selected worker";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(125, 156);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(188, 20);
            this.SalaryTextBox.TabIndex = 7;
            this.SalaryTextBox.TextChanged += new System.EventHandler(this.SalaryTextBox_TextChanged);
            // 
            // ErrorCalendarPanel
            // 
            this.ErrorCalendarPanel.Controls.Add(this.ErrorCalendarLabel);
            this.ErrorCalendarPanel.Location = new System.Drawing.Point(120, 108);
            this.ErrorCalendarPanel.Name = "ErrorCalendarPanel";
            this.ErrorCalendarPanel.Size = new System.Drawing.Size(210, 30);
            this.ErrorCalendarPanel.TabIndex = 8;
            // 
            // ErrorCalendarLabel
            // 
            this.ErrorCalendarLabel.AutoSize = true;
            this.ErrorCalendarLabel.Location = new System.Drawing.Point(207, 4);
            this.ErrorCalendarLabel.Name = "ErrorCalendarLabel";
            this.ErrorCalendarLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorCalendarLabel.TabIndex = 3;
            // 
            // DateOfEmploymentDateTimePicker
            // 
            this.DateOfEmploymentDateTimePicker.Location = new System.Drawing.Point(125, 113);
            this.DateOfEmploymentDateTimePicker.MaxDate = new System.DateTime(2799, 11, 26, 0, 0, 0, 0);
            this.DateOfEmploymentDateTimePicker.MinDate = new System.DateTime(1925, 12, 31, 0, 0, 0, 0);
            this.DateOfEmploymentDateTimePicker.Name = "DateOfEmploymentDateTimePicker";
            this.DateOfEmploymentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfEmploymentDateTimePicker.TabIndex = 2;
            this.DateOfEmploymentDateTimePicker.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.DateOfEmploymentDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfEmploymentDateTimePicker_ValueChanged);
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(125, 65);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(370, 20);
            this.PostTextBox.TabIndex = 5;
            this.PostTextBox.TextChanged += new System.EventHandler(this.PostTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(125, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(370, 20);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalaryLabel.Location = new System.Drawing.Point(80, 159);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Salary:";
            // 
            // DateOfEmploymentLabel
            // 
            this.DateOfEmploymentLabel.AutoSize = true;
            this.DateOfEmploymentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateOfEmploymentLabel.Location = new System.Drawing.Point(15, 113);
            this.DateOfEmploymentLabel.Name = "DateOfEmploymentLabel";
            this.DateOfEmploymentLabel.Size = new System.Drawing.Size(104, 13);
            this.DateOfEmploymentLabel.TabIndex = 2;
            this.DateOfEmploymentLabel.Text = "Date of employment:";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PostLabel.Location = new System.Drawing.Point(88, 68);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(31, 13);
            this.PostLabel.TabIndex = 1;
            this.PostLabel.Text = "Post:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FullNameLabel.Location = new System.Drawing.Point(64, 22);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full name:";
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Location = new System.Drawing.Point(4, 557);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(45, 45);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddPictureBox.TabIndex = 2;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            // 
            // RedactPictureBox
            // 
            this.RedactPictureBox.Location = new System.Drawing.Point(80, 557);
            this.RedactPictureBox.Name = "RedactPictureBox";
            this.RedactPictureBox.Size = new System.Drawing.Size(45, 45);
            this.RedactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedactPictureBox.TabIndex = 3;
            this.RedactPictureBox.TabStop = false;
            this.RedactPictureBox.Click += new System.EventHandler(this.RedactPictureBox_Click);
            // 
            // DeletePictureBox
            // 
            this.DeletePictureBox.Location = new System.Drawing.Point(156, 557);
            this.DeletePictureBox.Name = "DeletePictureBox";
            this.DeletePictureBox.Size = new System.Drawing.Size(45, 45);
            this.DeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletePictureBox.TabIndex = 4;
            this.DeletePictureBox.TabStop = false;
            this.DeletePictureBox.Click += new System.EventHandler(this.DeletePictureBox_Click);
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.Location = new System.Drawing.Point(344, 199);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(0, 13);
            this.ExceptionLabel.TabIndex = 5;
            // 
            // WorkersControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ExceptionLabel);
            this.Controls.Add(this.DeletePictureBox);
            this.Controls.Add(this.RedactPictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.SelectedWorkerGroupBox);
            this.Controls.Add(this.WorkersListBox);
            this.Name = "WorkersControls";
            this.Size = new System.Drawing.Size(874, 611);
            this.SelectedWorkerGroupBox.ResumeLayout(false);
            this.SelectedWorkerGroupBox.PerformLayout();
            this.ErrorCalendarPanel.ResumeLayout(false);
            this.ErrorCalendarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WorkersListBox;
        private System.Windows.Forms.GroupBox SelectedWorkerGroupBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DateOfEmploymentLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.DateTimePicker DateOfEmploymentDateTimePicker;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RedactPictureBox;
        private System.Windows.Forms.PictureBox DeletePictureBox;
        private System.Windows.Forms.Panel ErrorCalendarPanel;
        private System.Windows.Forms.Label ErrorCalendarLabel;
        private System.Windows.Forms.Label ExceptionLabel;
    }
}
