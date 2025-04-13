using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.ViewModel;
using Newtonsoft.Json;
using View.ViewModel.Commands;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddButton.CommandParameter = Resources["mainVM"];
            AddButton.Command = (AddCommand)Resources["addCommand"];
            EditButton.Command = (EditCommand)Resources["editCommand"];
            RemoveButton.Command = (RemoveCommand)Resources["removeCommand"];
            ApplyButton.Command = (ApplyCommand)Resources["applyCommand"];
            ApplyButton.CommandParameter = new List<object>() { NameTextBox, PhoneNumberTextBox, EmailTextBox };
            
        }
        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ContactsListBox.SelectedIndex = -1;
        //    ApplyButton.Visibility = Visibility.Visible;
        //    EditButton.Visibility = Visibility.Hidden;
        //    RemoveButton.Visibility = Visibility.Hidden;
        //    NameTextBox.IsReadOnly = false;
        //    PhoneNumberTextBox.IsReadOnly = false;
        //    EmailTextBox.IsReadOnly = false;
        //    NameTextBox.Text = "";
        //    PhoneNumberTextBox.Text = "";
        //    EmailTextBox.Text = "";
        //}
    }
}
