
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
            this.WorkersControls = new Solution.Main.Controls.WorkersControls();
            this.SuspendLayout();
            // 
            // WorkersControls
            // 
            this.WorkersControls.Location = new System.Drawing.Point(13, 13);
            this.WorkersControls.Name = "WorkersControls";
            this.WorkersControls.Size = new System.Drawing.Size(874, 611);
            this.WorkersControls.TabIndex = 0;
            this.WorkersControls.Load += new System.EventHandler(this.WorkersControls_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 644);
            this.Controls.Add(this.WorkersControls);
            this.Name = "MainForm";
            this.Text = "Workers app";
            this.ResumeLayout(false);

        }

        #endregion

        private Main.Controls.WorkersControls WorkersControls;
    }
}

