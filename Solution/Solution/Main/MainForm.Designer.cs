
namespace Solution
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
            this.workersControls1 = new Solution.Main.Controls.WorkersControls();
            this.SuspendLayout();
            // 
            // workersControls1
            // 
            this.workersControls1.Location = new System.Drawing.Point(13, 13);
            this.workersControls1.Name = "workersControls1";
            this.workersControls1.Size = new System.Drawing.Size(874, 611);
            this.workersControls1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 644);
            this.Controls.Add(this.workersControls1);
            this.Name = "MainForm";
            this.Text = "Workers app";
            this.ResumeLayout(false);

        }

        #endregion

        private Main.Controls.WorkersControls workersControls1;
    }
}

