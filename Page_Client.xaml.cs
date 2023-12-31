﻿using FitnessApp.Classes;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private int ID_client;

        public Page2()
        {
            InitializeComponent();
            
        }
        
        private void Click_But_ShowClient(object sender, RoutedEventArgs e)
        {
            ID_client = int.Parse(ID_Client_Input.Text);

            Client client = ArchiveClients.GetClientById(ID_client);

            if (client != null)
            {
                IDB.Text = client.ID.ToString();
                NameB.Text = client.Name;
                SurnameB.Text = client.Surname;
                SecondNameB.Text = client.SecondName;
                PhoneB.Text = client.PhoneNumber;
                EmailB.Text = client.Email;
                NumDealB.Text = client.NumberDeal.ToString();
                TrainerIDB.Text = client.Membership.PersonalTrainerID.ToString();
                CostB.Text = client.Membership.Cost.ToString();
                DataStartB.Text = client.Membership.DataStart;
                DataEndB.Text = client.Membership.DataEnd;

                clar.Visibility = Visibility.Hidden;
                But_OutOFArchive.Visibility = Visibility.Hidden;
                But_AddToArchive.Visibility = Visibility.Visible;
            }
            else if (ClientsArchive.GetClientById(ID_client) != null)
            {
                client = ClientsArchive.GetClientById(ID_client);
                IDB.Text = client.ID.ToString();
                NameB.Text = client.Name;
                SurnameB.Text = client.Surname;
                SecondNameB.Text = client.SecondName;
                PhoneB.Text = client.PhoneNumber;
                EmailB.Text = client.Email;
                NumDealB.Text = client.NumberDeal.ToString();
                TrainerIDB.Text = client.Membership.PersonalTrainerID.ToString();
                CostB.Text = client.Membership.Cost.ToString();
                DataStartB.Text = client.Membership.DataStart;
                DataEndB.Text = client.Membership.DataEnd;

                clar.Visibility = Visibility.Visible;
                But_OutOFArchive.Visibility = Visibility.Visible;
                But_AddToArchive.Visibility = Visibility.Hidden;
            }
            
            else
            {
                clar.Visibility = Visibility.Hidden;
                MessageBox.Show("Клиента с таким ID не существует");
            }

            ID_Client_Input.Clear();

        }

        private void But_AddToArchive_Click(object sender, RoutedEventArgs e)
        {
            int IDClient = int.Parse(IDB.Text);

            Client.AddClientToArchive(IDClient); 

            MessageBox.Show("Клиент добавлен в архив!");

            clar.Visibility= Visibility.Visible;

            But_AddToArchive.Visibility = Visibility.Hidden;

            But_OutOFArchive.Visibility = Visibility.Visible;
        }

        private void But_OutOFArchive_Click(object sender, RoutedEventArgs e)
        {
            int IDClient = int.Parse(IDB.Text);

            Client.OutOfArchive(IDClient);

            MessageBox.Show("Клиент удален из архива!");

            clar.Visibility = Visibility.Hidden;

            But_AddToArchive.Visibility = Visibility.Visible;

            But_OutOFArchive.Visibility = Visibility.Hidden;
        }

        private void But_Delete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(IDB.Text);
            
            if (But_OutOFArchive.Visibility == Visibility.Hidden)
            {
                ArchiveClients.Delete(id);
            }
            else
            {
                ClientsArchive.Delete(id);
            }
            
            MessageBox.Show("Клиент удалён!");
            NavigationService.Navigate(new Page1());
        }
    }
}
