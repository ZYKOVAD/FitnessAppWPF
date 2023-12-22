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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        List<Employee> _listEmpl;

        private void Loaded_page1(object sender, RoutedEventArgs e)
        {
           
            try
            {
                _listEmpl = EmployeeList.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgClients.ItemsSource = _listEmpl;
        }

        private void But_Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add_Employee());
        }

        private void But_delete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(ID_Emp.Text);
            EmployeeList.Delete(id);
            ID_Emp.Clear();
            NavigationService.Refresh();
            MessageBox.Show("Сотрудник удалён!");
            
        }
    }
    
}
