using FitnessApp.Classes;
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

namespace FitnessApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        public MainWindow()
        {
            InitializeComponent();

            Frame.Content = new Page1();
        }

        private void But_all_click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page1();
        }

        private void But_client_click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page2();
        }

        private void But_employees_click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page3();
        }
    }
}
