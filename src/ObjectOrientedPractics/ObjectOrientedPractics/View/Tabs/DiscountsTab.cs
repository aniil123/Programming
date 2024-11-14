using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        PointsDiscount pointsDiscount = new PointsDiscount();
        List<Model.Item> items = new List<Model.Item>();
        public DiscountsTab()
        {
            InitializeComponent();
            for(int i = 0; i<4;i++)
            {

            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
