using FitnessApp.Classes;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Page_Archive_Clients.xaml
    /// </summary>
    public partial class Page_Archive_Clients : Page
    {
        public Page_Archive_Clients()
        {
            InitializeComponent();
        }

        private List<Client> _listClient;

        private void Loaded_page(object sender, RoutedEventArgs e)
        {

            _listClient = ClientsArchive.Read();

            dgArchiveClients.ItemsSource = _listClient;
        }
    }
}
