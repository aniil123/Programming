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
    public class Cart
    {
        private List<Item> _items;
        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
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
        /// <summary>
        /// Возвращает суммарную стоимость товаров в корзине.
        /// </summary>
        public double Amound
        {
            get
            {
                if (Items != null)
                {
                    double sumCost = 0;
                    foreach (var i in _items)
                    {
                        sumCost += i.Cost;
                    }
                    return sumCost;
                }
                else
                {
                    return 0;
                }
            }
        }
        public Cart() { }
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
