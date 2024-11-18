using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка в процентах.
    /// </summary>
    public class PresentDiscount : IDiscount
    {
        //Категория, на товарам которой есть скидка.
        public Category Category { get; set; }
        //Скидка в процентах на товары выбранной категории.
        private int _discount;
        //Суммарное количество денег, потраченных на товары выбранной категории.
        private double _totalCosts;
        /// <summary>
        /// Возвращает скидку в процентах на товары выбранной категории.
        /// </summary>
        public int Discount
        {
            get
            {
                return _discount;
            }
            private set
            {
                if (value > 10)
                {
                    _discount = 10;
                }
                else
                {
                    _discount = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и присваивает суммарное количество денег потраченных на товары выбранной категории.
        /// </summary>
        public double TotalCosts
        {
            get
            {
                return _totalCosts;
            }
            set
            { 
                _totalCosts = value;
            }
        }
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная {Category} - {Discount}%";
            }
        }
        /// <summary>
        /// На основе полученного списка товаров определяет сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Model.Item> items)
        {
            double amount = 0;
            foreach(var i in items)
            {
                if (i.Category == Category)
                {
                    amount += i.Cost;
                }
            }
            return amount * Discount * 0.01;
        }
        /// <summary>
        /// На основе полученного списка товаров определяет сумму скидки и применяет ее к товарам выбранной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Apply(List<Model.Item> items)
        {
            double amount = 0;
            List<Model.Item> necessaryItems = new List<Model.Item>();
            foreach(var i in items)
            {
                if (i.Category == Category)
                {
                    necessaryItems.Add(i);
                    amount += i.Cost;
                }
            }
            if (necessaryItems.Count != 0)
            {
                double discount = (int)(amount * Discount * 0.01 / necessaryItems.Count * 100) / 100;
                foreach (var i in necessaryItems)
                {
                    i.Cost -= discount;
                }
                Discount = 0;
                TotalCosts = 0;
            }
            return amount * Discount * 0.01;
        }
        /// <summary>
        /// На основе полученного спиская товаров увеличивает количество накопленных процентов скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Model.Item> items)
        {
            double amount = 0;
            foreach(var i in items)
            {
                if(i.Category == Category)
                {
                    amount += i.Cost;
                }
            }
            TotalCosts += amount;
            Discount = (int)TotalCosts / 1000;
        }
        public PresentDiscount(Category category)
        {
            Category = category;
        }
    }
}
