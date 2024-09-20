using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о товаре.
    /// </summary>
    class Item
    {
        private static int counter = 0;
        //Уникальный номер товара.
        private int _id;
        //Название товара.
        private string _name;
        //Информация о товаре.
        private string _info;
        //Цена товара.
        private double _cost;
        /// <summary>
        /// Присваивает текущему товару уникальный номер.
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
        /// Возвращяет и присваивает имя товара. Значение должно быть строковым с количеством символов меньше 200.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " ");
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает информацию о товаре. Значение должно быть строковым с количеством символов меньше 1000.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 1000);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " .,()-");
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает цену товара. Значение должно быть вещественным не меньше 0 и не больше 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if(value >= 0 && value <= 100000)
                {
                    _cost = value;
                }
            }
        }
        /// <summary>
        /// Присваивает значения полям с названием, информацией и ценой товара.
        /// </summary>
        /// <param name="_name">Значение должно быть строковым с количеством символов меньше 200.</param>
        /// <param name="_info">Значение должно быть строковым с количеством символов меньше 1000.</param>
        /// <param name="_cost">Значение должно быть вещественным не меньше 0 и не больше 100000.</param>
        public Item(string _name, string _info, double _cost)
        {
            counter++;
            ID = counter;
            Name = _name;
            Info = _info;
            Cost = _cost;
        }
    }
}
