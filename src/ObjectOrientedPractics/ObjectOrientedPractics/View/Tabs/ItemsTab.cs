using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        DataTools.SortingCriteria sortingCriteria;
        List<Item> _items;
        List<Item> _displayedItems = new List<Item>();
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
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            SortingComboBox.SelectedIndexChanged += SortingComboBox_SelectedIndexChanged;
            foreach (var i in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(i);
            }
            SortingComboBox.Items.Add("Name");
            SortingComboBox.Items.Add("Cost (Ascending)");
            SortingComboBox.Items.Add("Cost (Descending)");
            SortingComboBox.SelectedIndex = 0;
            sortingCriteria = DataTools.SortingName;
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            
            _items.Add(new Item());
            _displayedItems.Add(_items[_items.Count - 1]);
            ItemsListBox.Items.Add(_items[_items.Count - 1].Name);
            SortingItems();
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int index = _items.IndexOf(_displayedItems[ItemsListBox.SelectedIndex]);
                _displayedItems.RemoveAt(ItemsListBox.SelectedIndex);
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
                IDTextBox.Text = _displayedItems[ItemsListBox.SelectedIndex].ID.ToString();
                CostTextBox.Text = _displayedItems[ItemsListBox.SelectedIndex].Cost.ToString();
                NameTextBox.Text = _displayedItems[ItemsListBox.SelectedIndex].Name;
                DescriptionTextBox.Text = _displayedItems[ItemsListBox.SelectedIndex].Info;
                CategoryComboBox.SelectedItem = _displayedItems[ItemsListBox.SelectedIndex].Category;
            }
            else
            {
                IDTextBox.Text = "";
                CostTextBox.Text = "";
                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";
                CostTextBox.BackColor = IDTextBox.BackColor;
                NameTextBox.BackColor = IDTextBox.BackColor;
                DescriptionTextBox.BackColor = IDTextBox.BackColor;
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
                _displayedItems[ItemsListBox.SelectedIndex].Cost = Convert.ToInt32(CostTextBox.Text);
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
                _displayedItems[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = _displayedItems[ItemsListBox.SelectedIndex].Name;
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
                _displayedItems[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
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
                _displayedItems[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedIndex;
            }
        }
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
            if(FindTextBox.Text == "")
            {
                ItemsListBox.Items.Clear();
                _displayedItems.Clear();
                foreach(var i in _items)
                {
                    ItemsListBox.Items.Add(i.Name);
                    _displayedItems.Add(i);
                }
            }
            else
            {
                ItemsListBox.Items.Clear();
                _displayedItems.Clear();
                foreach(var i in _items)
                {
                    if(Services.DataTools.PresenceOfSubstring(i, FindTextBox.Text))
                    {
                        ItemsListBox.Items.Add(i.Name);
                        _displayedItems.Add(i);
                    }
                }
            }
            SortingItems();
        }
        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortingComboBox.SelectedIndex)
            {
                case 0:
                    sortingCriteria = DataTools.SortingName;
                    break;
                case 1:
                    sortingCriteria = DataTools.CostAscending;
                    break;
                case 2:
                    sortingCriteria = DataTools.CostDescending;
                    break;
            }
            SortingItems();
        }
        private void SortingItems()
        {
            if (SortingComboBox.SelectedIndex != -1)
            {
                IDTextBox.Text = SortingComboBox.SelectedIndex.ToString();
                ItemsListBox.Items.Clear();
                DataTools.SortingData(_displayedItems, sortingCriteria);
                foreach (var i in _displayedItems)
                {
                    ItemsListBox.Items.Add(i.Name);
                }
                ItemsListBox.SelectedIndex = -1;
            }
        }
    }
}
