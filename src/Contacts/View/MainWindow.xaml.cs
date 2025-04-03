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

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM mainVM { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_Click;
            mainVM = new MainVM();
            DataContext = mainVM;
            saveButton.Command = new ViewModel.SaveCommand();
            saveButton.CommandParameter = mainVM.Contact;
            loadButton.Command = new ViewModel.LoadCommand();
            loadButton.CommandParameter = mainVM.Contact;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            mainVM.Name = ";;;sadsa;d;";
        }
    }
}
