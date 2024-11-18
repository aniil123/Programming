using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка на товары в баллах.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        //Скидка в баллах.
        private int _points;
        /// <summary>
        /// Возвращает скидку в баллах.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                _points = value;
            }
        }
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }
        /// <summary>
        /// На основе полученного списка товаров определяет сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach(var i in items)
            {
                amount += i.Cost;
            }
            if(Points > amount * 0.3)
            {
                return amount * 0.3;
            }
            else
            {
                return Points;
            }
        }
        /// <summary>
        /// На основе полученного списка товаров опредеяет сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Суммма скидки.</returns>
        public double Apply(List<Item> items)
        {
            double amount = 0;
            foreach(var i in items)
            {
                amount += i.Cost;
            }
            int points;
            if(Points > amount * 0.3)
            {
                points = (int)(amount * 0.3);
                Points -= (int)(amount * 0.3);
            }
            else
            {
                points = Points;
                Points = 0;
            }
            foreach(var i in items)
            {
                i.Cost -= (int)points / items.Count;
            }
            items[items.Count - 1].Cost -= points % items.Count;
            return points;
        }
        /// <summary>
        /// На совнове полученного списка товаров увеличивает количество накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach(var i in items)
            {
                amount += i.Cost;
            }
            Points += (int)Math.Ceiling(amount*0.1);
        }
    }
}
