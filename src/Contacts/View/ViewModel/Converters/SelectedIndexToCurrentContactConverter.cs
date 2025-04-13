using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using System.Collections.ObjectModel;

namespace View.ViewModel.Converters
{
    public class SelectedIndexToCurrentContactConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return -1;
            }
            MainVM mainVM = (MainVM)parameter;
            ObservableCollection<ContactVM> contacts = (ObservableCollection<ContactVM>)value;
            return contacts.IndexOf(mainVM.CurrentContactVM);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MainVM mainVM = (MainVM)parameter;
            if((int)value == -1)
            {
                mainVM.CurrentContactVM = null;
            }
            else
            {
                mainVM.CurrentContactVM = mainVM.Contacts[(int)value];
            }
            mainVM.OnPropertyChanged(new List<string>() { "Name", "PhoneNumber", "Email" });
            mainVM.Mode = Modes.Nothing;
            return mainVM.Contacts;
        }
    }
}
