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
    public partial class WeekDayControl : UserControl
    {
        bool flag = true;
        public WeekDayControl()
        {
            InitializeComponent();
            ParseButton.Click += ParseButton_Click;
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            foreach (var i in Enum.GetValues(typeof(Weekday)))
            {
                if (Convert.ToString(i) == ParseWeekDayTextBox.Text)
                {
                    ParseResultLabel.Text = $"Это день недели({i} = {Convert.ToInt32(i)})";
                    flag = false;
                }
            }
            if (flag == true)
            {
                ParseResultLabel.Text = "Нет такого дня недели";
            }
            flag = true;
        }
    }
}
