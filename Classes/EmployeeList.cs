using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Classes
{
    internal class EmployeeList
    {
        public static List<Employee> Read()
        {
            var path = "dataEmployee.txt";
            List<Employee> res = new List<Employee>();
            string[] emps = File.ReadAllLines(path);

            foreach (string str in emps)
            {
                string[] data = str.Split('!');
                Employee employee = new Employee()
                {
                    ID = int.Parse(data[0]),
                    Name = data[1],
                    Surname = data[2],
                    SecondName = data[3],
                    PhoneNumber = data[4],
                    Email = data[5]

                };

                res.Add(employee);
            }
            return res;
        }

        static public void Write(Employee employee)
        {
            var path = "dataEmployee.txt";
            string str = employee.ToString();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(str);
            }
        }

        public static void Write(List<Employee> list)  //функция перезаписи файла
        {
            var path = "dataEmployee.txt";

            File.WriteAllText(path, string.Empty);

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (Employee employee in list)
                {
                    string str = employee.ToString();
                    writer.WriteLine(str);
                }
            }
        }
    }
}
