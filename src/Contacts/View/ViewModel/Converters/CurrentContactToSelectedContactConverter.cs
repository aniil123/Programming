using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace View.ViewModel.Converters
{
    public class CurrentContactToSelectedContactConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            ContactVM currentContactVM = (ContactVM)value;
            if(mainVM.Contacts.IndexOf(currentContactVM) == -1)
            {
                return null;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Viewing;
            return value;
        }
    }
}
