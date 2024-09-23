using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель.
    /// </summary>
    class Customer
    {
        private static int _counter = 0;
        //Уникальный номер покупателя.
        private int _id;
        //Полное имя покупателя.
        private string _fullname;
        //Адрес доставки товара покупателю.
        private string _address;
        /// <summary>
        /// Возвращает уникальный номер покупателя.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает полное имя покупателя. Значение должно быть строковым с количеством символов меньше 200
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " .");
                _fullname = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает адрес для доставки покупателю. Значение должно быть строковым с количеством символов меньше 500.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 500);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " /,.0123456789");
                _address = value;
            }
        }
        /// <summary>
        /// Заполняет поля с полным именем и адресом доставки товара покупателя.
        /// </summary>
        /// <param name="_fullname">Значение должно быть строковым с количеством символов меньше 200.</param>
        /// <param name="_address">Значение должно быть строковым с количеством символов меньше 500.</param>
        public Customer(string fullname, string address)
        {
            _counter++;
            ID = _counter;
            FullName = fullname;
            Address = address;
        }
    }
}
