using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Заказ покупателя.
    /// </summary>
    public class Order
    {
        private static int counter = 0;
        //Статус заказа.
        public OrderStatus OrderStatus { get; set; }
        //Адрес доставки товаров.
        public Address Address;
        //ID заказа.
        private int _id;
        //Дата заказа
        private string _date;
        //Список товаров в заказе.
        private List<Item> _items;
        //Стоимость заказа.
        private double _totalCost;
        private double _discountAmount;
        private bool flagCostChange = true;
        /// <summary>
        /// Возвращает ID заказа.
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
        /// Возвращает и присваивает дату заказа. Значение должно быть строковым.
        /// </summary>
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает список товаров в заказе. Значение должно быть списком типа <see cref="Item"/>
        /// </summary>
        public List<Item> Items
        {
            get
            {
                flagCostChange = true;
                return _items;
            }
            private set
            {
                _items = value;
                flagCostChange = true;
            }
        }
        /// <summary>
        /// Возвращает суммарную стоимость товаров заказа.
        /// </summary>
        public double TotalCost
        {
            get
            {
                if (flagCostChange)
                {
                    _totalCost = 0;
                    foreach (var i in Items)
                    {
                        _totalCost += i.Cost;
                    }

                    flagCostChange = false;
                    return _totalCost;
                }
                else
                {
                    return _totalCost;
                }

            }
            set
            {

            }
        }
        /// <summary>
        /// Возвращает и задает размер скидки применяемой к заказу.
        /// </summary>
        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }
            set
            {
                _discountAmount = value;
            }
        }
        public double Total
        {
            get
            {
                return TotalCost - DiscountAmount;
            }
        }
        /// <summary>
        /// Заполняет поля класса полученными значениями.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер улицы.</param>
        /// <param name="apartment">Номер квартиры.</param>
        /// <param name="date">Дата заказа.</param>
        /// <param name="items">Список товаров заказа.</param>
        /// <param name="orderStatus">Состояние заказа.</param>
        public Order(int index, string country, string city, string street, string building, string apartment, string date, List<Item> items, OrderStatus orderStatus)
        {
            counter++;
            ID = counter;
            Address = new Address(index, country, city, street, building, apartment);
            Date = date;
            OrderStatus = orderStatus;
            Items = new List<Item>();
            foreach (var i in items)
            {
                Items.Add(new Model.Item(i.Name, i.Info, i.Cost, i.Category));
            }
        }
    }
}
