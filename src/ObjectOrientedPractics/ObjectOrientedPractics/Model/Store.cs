using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class Store
    {
        //Список товаров.
        private List<Model.Item> _items;
        //Список покупателей.
        private List<Model.Customer> _customers;
        /// <summary>
        /// Возвращает и присваивает список товаров.
        /// </summary>
        public List<Model.Item> Items
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
        /// Возвращает и присваивает список покупателей.
        /// </summary>
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public Store()
        {
            _items = new List<Model.Item>();
            _customers = new List<Model.Customer>();
            for(int i = 0;i < 3;i++)
            {
                _items.Add(new Item());
                _customers.Add(new Customer());
            }
        }
    }
}
