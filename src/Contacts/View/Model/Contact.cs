using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{

    /// <summary>
    /// Контактные данные.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер телефона. 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает почту.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создает объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact(){}
    }
}
