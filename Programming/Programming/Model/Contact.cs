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
        private string name;
        private string sur_name;
        private int kol_prop;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                name = value;
            }
        }
        public string SurName
        {
            get
            {
                return sur_name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                sur_name = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phone_number;
            }
            set
            {
                if (value[0] == '8' && value.Length == 11 && long.TryParse(value, out long a) == true)
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
                Validator.AssertOnPositiveValue(value);
                kol_prop = value;
            }
        }
        public Contact()
        {
            PhoneNumber = "89001233219";
            Name = "Sasha";
            SurName = "Gaberu";
            KolProp = 3;
        }
        public Contact(string phone_number, string name, string sur_name, int kol_prop)
        {
            PhoneNumber = phone_number;
            Name = name;
            KolProp = kol_prop;
            SurName = sur_name;
        }
        private void AssertStringContainsOnlyLetters(string value, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            foreach(var i in value)
            {
                if((Convert.ToInt32(i)<65 || Convert.ToInt32(i)>90) && (Convert.ToInt32(i)<97 || Convert.ToInt32(i)>122))
                {
                    throw new Exception("При вызове метода " + memberName + " произошла ошибка");
                }
            }
        }

    }
}
