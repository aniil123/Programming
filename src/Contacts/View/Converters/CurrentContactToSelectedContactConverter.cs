using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ViewModel;

namespace View.Converters
{
    internal class CurrentContactToSelectedContactConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            ContactVM currentContactVM = (ContactVM)value;
            return mainVM.Contacts.IndexOf(currentContactVM) != -1 ? value : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            if (mainVM.Mode == Modes.Editing)
                mainVM.UseClone();
            mainVM.Mode = Modes.Viewing;
            return value;
        }
    }
}
