using FitnessApp.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private List<Client> _listClient;
        public Page1()
        {
            InitializeComponent();  
        }
       
        public void Loaded_page1(object sender, RoutedEventArgs e)
        {
           try
           {
                _listClient = ArchiveClients.Read();
           }
           catch(Exception ex) 
           {
               MessageBox.Show(ex.Message);
           }

            dgClients.ItemsSource = _listClient;
        }


        private void But_Add_Client_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add_Client());    
        }

        private void But_ArchiveClients_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_Archive_Clients());
        }
    }
}
