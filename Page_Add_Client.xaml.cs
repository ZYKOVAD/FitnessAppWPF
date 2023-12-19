using FitnessApp.Classes;
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
using System.Xml.Linq;

namespace FitnessApp
{
    /// <summary>
    /// Логика взаимодействия для Add_Client.xaml
    /// </summary>
    public partial class Add_Client : Page
    {
        public Add_Client()
        {
            InitializeComponent();
        }

        private void But_Create_Client_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(NameBox.Text, SurnameBox.Text, SecondNameBox.Text, PhoneNumberBox.Text, EmailBox.Text, int.Parse(NumDealBox.Text), int.Parse(TrainerIDBox.Text), CostBox.Text, DataStartBox.Text, DataEndBox.Text);

            ArchiveClients.Write(client);

            //ArchiveClients.clientList.Add(client);

            MessageBox.Show("Клиент создан!");
        }

    }
}
