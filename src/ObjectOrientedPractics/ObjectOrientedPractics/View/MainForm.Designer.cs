
namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.TabControl.SuspendLayout();
            this.ItemTabPage.SuspendLayout();
            this.CustomerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemTabPage);
            this.TabControl.Controls.Add(this.CustomerTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(765, 676);
            this.TabControl.TabIndex = 0;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Controls.Add(this.ItemsTab);
            this.ItemTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(757, 650);
            this.ItemTabPage.TabIndex = 0;
            this.ItemTabPage.Text = "Item";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(751, 644);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Controls.Add(this.CustomersTab);
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Size = new System.Drawing.Size(757, 650);
            this.CustomerTabPage.TabIndex = 1;
            this.CustomerTabPage.Text = "Customer";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(0, 0);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(757, 650);
            this.CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 676);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.TabControl.ResumeLayout(false);
            this.ItemTabPage.ResumeLayout(false);
            this.CustomerTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabPage CustomerTabPage;
        private View.Tabs.CustomersTab CustomersTab;
    }
}

