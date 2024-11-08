using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Model.Item> _items;
        /// <summary>
        /// Возвращает и присваивает список товаров.
        /// </summary>
        public List<Model.Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        public ItemsTab()
        {
            InitializeComponent();
            IDTextBox.ReadOnly = true;
            CostTextBox.ReadOnly = true;
            NameTextBox.ReadOnly = true;
            DescriptionTextBox.ReadOnly = true;
            AddItemButton.Click += AddItemButton_Click;
            RemoveItemButton.Click += RemoveItemButton_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            foreach (var i in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(i);
            }
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            
            _items.Add(new Model.Item());
            ItemsListBox.Items.Add(_items[_items.Count - 1].Name);
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int index = ItemsListBox.SelectedIndex;
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                _items[index].Active = false;
                _items.RemoveAt(index);
                CostTextBox.BackColor = IDTextBox.BackColor;
                NameTextBox.BackColor = IDTextBox.BackColor;
                DescriptionTextBox.BackColor = IDTextBox.BackColor;
            }
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                CostTextBox.ReadOnly = false;
                NameTextBox.ReadOnly = false;
                DescriptionTextBox.ReadOnly = false;
                IDTextBox.Text = _items[ItemsListBox.SelectedIndex].ID.ToString();
                CostTextBox.Text = _items[ItemsListBox.SelectedIndex].Cost.ToString();
                NameTextBox.Text = _items[ItemsListBox.SelectedIndex].Name;
                DescriptionTextBox.Text = _items[ItemsListBox.SelectedIndex].Info;
                CategoryComboBox.SelectedItem = _items[ItemsListBox.SelectedIndex].Category;
            }
            else
            {
                IDTextBox.Text = "";
                CostTextBox.Text = "";
                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CategoryComboBox.SelectedIndex = -1;
                CostTextBox.ReadOnly = true;
                NameTextBox.ReadOnly = true;
                DescriptionTextBox.ReadOnly = true;
            }
        }
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(CostTextBox.Text) < 0 || Convert.ToInt32(CostTextBox.Text) > 100000)
                {
                    throw new Exception();
                }
                _items[ItemsListBox.SelectedIndex].Cost = Convert.ToInt32(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch
            {
                CostTextBox.BackColor = Color.Red;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(NameTextBox.Text == "")
                {
                    throw new Exception();
                }
                _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _items[ItemsListBox.SelectedIndex].Name;
                NameTextBox.SelectionStart = NameTextBox.Text.Length;
                NameTextBox.BackColor = Color.White;
            }
            catch
            {
                NameTextBox.BackColor = Color.Red;
            }
        }
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(DescriptionTextBox.Text == "")
                {
                    throw new Exception();
                }
                _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch
            {
                DescriptionTextBox.BackColor = Color.Red;
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex != -1)
            {
                _items[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedIndex;
            }
        }
    }
}
