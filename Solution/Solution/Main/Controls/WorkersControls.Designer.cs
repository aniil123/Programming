
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.DateOfEmploymentLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.DateOfEmploymentTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SelectedWorkerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.Location = new System.Drawing.Point(4, 4);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(333, 537);
            this.WorkersListBox.TabIndex = 0;
            // 
            // SelectedWorkerGroupBox
            // 
            this.SelectedWorkerGroupBox.Controls.Add(this.SalaryTextBox);
            this.SelectedWorkerGroupBox.Controls.Add(this.DateOfEmploymentTextBox);
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
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(125, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(370, 20);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // PostTextBox
            // 
            this.PostTextBox.Location = new System.Drawing.Point(125, 65);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(370, 20);
            this.PostTextBox.TabIndex = 5;
            // 
            // DateOfEmploymentTextBox
            // 
            this.DateOfEmploymentTextBox.Location = new System.Drawing.Point(125, 110);
            this.DateOfEmploymentTextBox.Name = "DateOfEmploymentTextBox";
            this.DateOfEmploymentTextBox.Size = new System.Drawing.Size(188, 20);
            this.DateOfEmploymentTextBox.TabIndex = 6;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(125, 156);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(188, 20);
            this.SalaryTextBox.TabIndex = 7;
            // 
            // WorkersControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedWorkerGroupBox);
            this.Controls.Add(this.WorkersListBox);
            this.Name = "WorkersControls";
            this.Size = new System.Drawing.Size(874, 611);
            this.SelectedWorkerGroupBox.ResumeLayout(false);
            this.SelectedWorkerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox WorkersListBox;
        private System.Windows.Forms.GroupBox SelectedWorkerGroupBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox DateOfEmploymentTextBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DateOfEmploymentLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label FullNameLabel;
    }
}
