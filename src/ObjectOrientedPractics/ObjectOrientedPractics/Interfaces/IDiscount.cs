using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для классов для скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get; }
        /// <summary>
        /// На основе полученного списка товаров определяет сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки</returns>
        double Calculate(List<Model.Item> items);
        /// <summary>
        /// На основе полученного списка товаров определяет сумму скидки и примеянет ее к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        double Apply(List<Model.Item> items);
        /// <summary>
        /// На основе полученного списка товаров увеличивает накопленную скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Model.Item> items);
    }
}
