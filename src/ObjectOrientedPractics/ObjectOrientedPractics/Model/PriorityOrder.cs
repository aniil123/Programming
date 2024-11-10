using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ.
    /// </summary>
    class PriorityOrder : Order
    {
        //Желаемая дата доставки заказа.
        private DateTime _priorityDate;
        //Желаемое ремя доставки товара.
        private string _priorityTime;
        /// <summary>
        /// Возвращает и присваивает желаемую дату доставки. Значение должно быть типа <see cref="DateTime"/>.
        /// </summary>
        public DateTime PriorityDate
        {
            get
            {
                return _priorityDate;
            }
            set
            {
                if (value >= DateTime.Today)
                {
                    _priorityDate = value;
                }
                else
                {
                    throw new Exception("Указанная дата доставки некорректна");
                }
            }
        }
        /// <summary>
        /// Возвращает и задает желаемое время доставки товара. Значение должно быть строковым.
        /// </summary>
        public string PriorityTime
        {
            get
            {
                return _priorityTime;
            }
            set
            {
                _priorityTime = value;
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
        public PriorityOrder(int index, string country, string city, string street, string building, string apartment, string date, List<Item> items, OrderStatus orderStatus):
            base(index, country, city, street, building, apartment, date, items, orderStatus) { }
    }
}
