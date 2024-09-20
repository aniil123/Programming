using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonControl : UserControl
    {
        public SeasonControl()
        {
            InitializeComponent();
            SeasonButton.Click += SeasonButton_Click;
            foreach (var i in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(i);
            }
            SeasonComboBox.SelectedIndex = 0;
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    SeasonResultLabel.Text = "";
                    this.BackColor = Color.Orange;
                    break;
                case 1:
                    this.BackColor = Color.White;
                    SeasonResultLabel.Text = "Ура! Солнце!";
                    break;
                case 2:
                    this.BackColor = Color.White;
                    SeasonResultLabel.Text = "Бррр! Холодно!";
                    break;
                case 3:
                    SeasonResultLabel.Text = "";
                    this.BackColor = Color.Green;
                    break;
            }
        }
    }
}
