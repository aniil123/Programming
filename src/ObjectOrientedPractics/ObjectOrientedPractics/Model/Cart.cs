using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина с товарами покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        //Список товаров в корзине.
        private List<Item> _items;
        //Суммарная стоимость товаров.
        private double _amount;
        private bool flagAmountChange = true;
        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                flagAmountChange = true;
                return _items;
            }
            set
            {
                _items = value;
                flagAmountChange = true;
            }
        }
        /// <summary>
        /// Возвращает суммарную стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (flagAmountChange)
                {
                    _amount = 0;
                    foreach (var i in _items)
                    {
                        _amount += i.Cost;
                    }
                    flagAmountChange = false;
                    return _amount;
                }
                else
                {
                    return _amount;
                }
            }
        }
        public object Clone()
        {
            List<Item> items = new List<Item>();
            foreach(var i in Items)
            {
                items.Add((Item)i.Clone());
            }
            return new Cart(items);
        }
        public Cart() 
        {
            Items = new List<Item>();
        }
        /// <summary>
        /// Зполняет корзину товарами.
        /// </summary>
        /// <param name="items">Товары из корзины покупателя.</param>
        public Cart(List<Item> items)
        {
            _items = items;
        }
    }
}
