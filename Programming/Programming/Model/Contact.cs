using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        private string phone_number;
        public string name { get; set; }
        private int kol_prop;
        public string PhoneNumber
        {
            get
            {
                return phone_number;
            }
            set
            {
                if(value[0] == '8' && value.Length == 11 && int.TryParse(value, out int a) == true)
                {
                    phone_number = value;
                }
                else
                {
                   throw new Exception("Неверный номер телефона");
                }
            }
        }
        public int KolProp
        {
            get
            {
                return kol_prop;
            }
            set
            {
                if(value>=0)
                {
                    kol_prop = value;
                }
                else
                {
                    throw new Exception("Количество пропущенных звонков не может быть меньше 0");
                }
            }
        }
        public Contact()
        {
            PhoneNumber = "89001233219";
            name = "Саша";
            KolProp = 3;
        }
        public Contact(string phone_number, string name, int kol_prop)
        {
            PhoneNumber = phone_number;
            this.name = name;
            KolProp = kol_prop;
        }
    }
}
