using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Model.Address _address;
        public Model.Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value != null)
                {
                    _address = value;
                    if (_address.Index != 0)
                    {
                        PostIndexTextBox.Text = _address.Index.ToString();
                    }
                    else
                    {
                        PostIndexTextBox.Text = "";
                    }
                    CountryTextBox.Text = _address.Country;
                    CityTextBox.Text = _address.City;
                    StreetTextBox.Text = _address.Street;
                    BuildingTextBox.Text = _address.Building;
                    ApartmentTextBox.Text = _address.Apartment;
                }
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
        }
        /// <summary>
        /// Устанавливает свойства ReadOnly в значение true для всех текстовых полей пользовательского элемента управления.
        /// </summary>
        public void ReadOnlyOn()
        {
            PostIndexTextBox.ReadOnly = true;
            CountryTextBox.ReadOnly = true;
            CityTextBox.ReadOnly = true;
            StreetTextBox.ReadOnly = true;
            BuildingTextBox.ReadOnly = true;
            ApartmentTextBox.ReadOnly = true;
        }
        /// <summary>
        /// Устанавливает свойство ReadOnly в значение false для всех текстовых полей пользовательского элемента управления.
        /// </summary>
        public void ReadOnlyOff()
        {
            PostIndexTextBox.ReadOnly = false;
            CountryTextBox.ReadOnly = false;
            CityTextBox.ReadOnly = false;
            StreetTextBox.ReadOnly = false;
            BuildingTextBox.ReadOnly = false;
            ApartmentTextBox.ReadOnly = false;
        }
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(PostIndexTextBox.Text.Length == 0)
                {
                    _address.Index = 0;
                }
                else
                {
                    _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
                }
                PostIndexTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                PostIndexTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                CountryTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                CityTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                StreetTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                BuildingTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
                ExceptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                ApartmentTextBox.BackColor = Color.Red;
                ExceptionLabel.Text = ClearingException(ex);
            }
        }
        /// <summary>
        /// Очищает исключение от "лишнего".
        /// </summary>
        /// <param name="ex">Содержит информацию об исключении.</param>
        /// <returns>Строка, содержащая информацию об исключении.</returns>
        private string ClearingException(Exception ex)
        {
            string exStr = "";
            char[] exCharArray = ex.ToString().ToCharArray();
            bool flag = false;
            foreach (var i in exCharArray)
            {
                if (i == '\n')
                {
                    break;
                }
                if (flag)
                {
                    exStr += i;
                }
                if (i == ' ')
                {
                    flag = true;
                }
            }
            return exStr;
        }
    }
}
