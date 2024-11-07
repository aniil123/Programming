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
    public class Customer
    {
        private static int _counter = 0;
        //Уникальный номер покупателя.
        private int _id;
        //Полное имя покупателя.
        private string _fullname;
        //Адрес доставки товара покупателю.
        public Address Address;
        //Корзина покупателя.
        private Cart _cart;
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
        /// Возвращает и заполняет корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }
        /// <summary>
        /// Заполняет поля с полным именем и адресом доставки товара покупателя случайными значениями.
        /// </summary>
        public Customer()
        {
            _counter++;
            ID = _counter;
            string name = Enum.GetName(typeof(NamesOfCustomers), new Random().Next(0, Enum.GetNames(typeof(NamesOfCustomers)).Length));
            string secondName = Enum.GetNames(typeof(SecondNamesOfCustomers))[new Random().Next(0, Enum.GetNames(typeof(SecondNamesOfCustomers)).Length)];
            string patronymic = Enum.GetNames(typeof(PatronymicsOfCustomers))[new Random().Next(0, Enum.GetNames(typeof(PatronymicsOfCustomers)).Length)];
            FullName = name + " " + secondName + " " + patronymic;
            Address = new Address(new Random().Next(100000, 999999), "Россия", "Томск", "Ленина", "40", "1000");
            Cart = new Cart();
        }
        /// <summary>
        /// Заполняет поля с полным именем и адресом доставки товара покупателя.
        /// </summary>
        /// <param name="fullname">Значение должно быть строковым с количеством символов меньше 200.</param>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер улицы.</param>
        /// <param name="apartment">Номер квартиры.</param>
        /// <param name="items">Список товаров в корзине.</param>
        public Customer(string fullname, int index, string country, string city, string street, string building, string apartment, List<Item> items)
        {
            _counter++;
            ID = _counter;
            FullName = fullname;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart(items);
        }
    }
}
