
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
            this.Classes = new System.Windows.Forms.TabPage();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FilmListBox = new System.Windows.Forms.ListBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.SeasonControl = new Programming.View.Panels.SeasonControl();
            this.WeekDayControl = new Programming.View.Panels.WeekDayControl();
            this.EnumsControl = new Programming.View.Panels.EnumsControl();
            this.rectangleCollisionControl1 = new Programming.View.Panels.RectangleCollisionControl();
            this.rectangleInfoControl1 = new Programming.View.Panels.RectangleInfoControl();
            this.filmsInfoControl1 = new Programming.View.Panels.FilmsInfoControl();
            this.EnumTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.Classes.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTabControl
            // 
            this.EnumTabControl.Controls.Add(this.Enums);
            this.EnumTabControl.Controls.Add(this.Classes);
            this.EnumTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumTabControl.Name = "EnumTabControl";
            this.EnumTabControl.SelectedIndex = 0;
            this.EnumTabControl.Size = new System.Drawing.Size(1234, 711);
            this.EnumTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonControl);
            this.Enums.Controls.Add(this.WeekDayControl);
            this.Enums.Controls.Add(this.EnumsControl);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1226, 685);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.filmsInfoControl1);
            this.Classes.Controls.Add(this.rectangleInfoControl1);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(1226, 685);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectangleCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(1226, 685);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RatingLabel
            // 
            this.RatingLabel.Location = new System.Drawing.Point(0, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(100, 23);
            this.RatingLabel.TabIndex = 0;
            // 
            // GenreLabel
            // 
            this.GenreLabel.Location = new System.Drawing.Point(0, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(100, 23);
            this.GenreLabel.TabIndex = 0;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(0, 0);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 0;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(0, 0);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 0;
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(0, 0);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(75, 23);
            this.FindFilmButton.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(100, 23);
            this.DateLabel.TabIndex = 0;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Location = new System.Drawing.Point(0, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(100, 23);
            this.DurationLabel.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 23);
            this.NameLabel.TabIndex = 0;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(0, 0);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 0;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(0, 0);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // FilmListBox
            // 
            this.FilmListBox.Location = new System.Drawing.Point(0, 0);
            this.FilmListBox.Name = "FilmListBox";
            this.FilmListBox.Size = new System.Drawing.Size(120, 95);
            this.FilmListBox.TabIndex = 0;
            // 
            // IDLabel
            // 
            this.IDLabel.Location = new System.Drawing.Point(0, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(100, 23);
            this.IDLabel.TabIndex = 0;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(0, 0);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(0, 0);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 0;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(0, 0);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(0, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(100, 23);
            this.yLabel.TabIndex = 0;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(0, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(100, 23);
            this.xLabel.TabIndex = 0;
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.Location = new System.Drawing.Point(0, 0);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(120, 95);
            this.RectangleListBox.TabIndex = 0;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(0, 0);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 0;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(0, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(100, 23);
            this.ColorLabel.TabIndex = 0;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(0, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(100, 23);
            this.WidthLabel.TabIndex = 0;
            // 
            // LengthLabel
            // 
            this.LengthLabel.Location = new System.Drawing.Point(0, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(100, 23);
            this.LengthLabel.TabIndex = 0;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(0, 0);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 0;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(0, 0);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 0;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(0, 0);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 0;
            // 
            // SeasonControl
            // 
            this.SeasonControl.Location = new System.Drawing.Point(673, 397);
            this.SeasonControl.Name = "SeasonControl";
            this.SeasonControl.Size = new System.Drawing.Size(367, 227);
            this.SeasonControl.TabIndex = 11;
            // 
            // WeekDayControl
            // 
            this.WeekDayControl.Location = new System.Drawing.Point(24, 397);
            this.WeekDayControl.Name = "WeekDayControl";
            this.WeekDayControl.Size = new System.Drawing.Size(400, 224);
            this.WeekDayControl.TabIndex = 10;
            // 
            // EnumsControl
            // 
            this.EnumsControl.Location = new System.Drawing.Point(9, 17);
            this.EnumsControl.Name = "EnumsControl";
            this.EnumsControl.Size = new System.Drawing.Size(514, 313);
            this.EnumsControl.TabIndex = 9;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(1226, 685);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // rectangleInfoControl1
            // 
            this.rectangleInfoControl1.BackColor = System.Drawing.Color.White;
            this.rectangleInfoControl1.Location = new System.Drawing.Point(8, 40);
            this.rectangleInfoControl1.Name = "rectangleInfoControl1";
            this.rectangleInfoControl1.Size = new System.Drawing.Size(285, 356);
            this.rectangleInfoControl1.TabIndex = 0;
            // 
            // filmsInfoControl1
            // 
            this.filmsInfoControl1.BackColor = System.Drawing.Color.White;
            this.filmsInfoControl1.Location = new System.Drawing.Point(299, 40);
            this.filmsInfoControl1.Name = "filmsInfoControl1";
            this.filmsInfoControl1.Size = new System.Drawing.Size(283, 340);
            this.filmsInfoControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.EnumTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.EnumTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumTabControl;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox FilmListBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private View.Panels.RectangleCollisionControl rectangleCollisionControl1;
        private View.Panels.EnumsControl EnumsControl;
        private View.Panels.WeekDayControl WeekDayControl;
        private View.Panels.SeasonControl SeasonControl;
        private View.Panels.FilmsInfoControl filmsInfoControl1;
        private View.Panels.RectangleInfoControl rectangleInfoControl1;
    }
}

