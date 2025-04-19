using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;
using System.Collections.ObjectModel;

namespace View.ViewModel.Converters
{
    class Mode_CurrentContactToCanExecuteMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            Modes mode = (Modes)values[0];
            ContactVM currentContactVM = (ContactVM)values[1];
            return mode == Modes.Viewing && currentContactVM != null && mainVM.Contacts.IndexOf(currentContactVM) != -1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
