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
    /// Логика взаимодействия для Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Page
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void But_Create_Employee_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee(NameBox.Text, SurnameBox.Text, SecondNameBox.Text, PhoneNumberBox.Text, EmailBox.Text);

            EmployeeList.Write(emp);

            MessageBox.Show("Сотрудник создан!");
        }
    }
}
