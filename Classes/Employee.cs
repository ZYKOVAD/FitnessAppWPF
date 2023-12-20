using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Classes
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }


        public Employee(int id, string name, string surname, string secondName, string phone, string email)
        {
            ID = id;
            Name = name;
            Surname = surname;
            SecondName = secondName;
            PhoneNumber = phone;
            Email = email;

        }

        public Employee(string name, string surname, string secondName, string phone, string email)
        {
            int LastID = int.Parse(File.ReadAllText("LastID.txt"));
            LastID++;
            this.ID = LastID;
            File.WriteAllText("LastID.txt", LastID.ToString());
            Name = name;
            Surname = surname;
            SecondName = secondName;
            PhoneNumber = phone;
            Email = email;
        }

        public Employee() { }

        public override string ToString()
        {
            string res = $"{ID}!{Name}!{Surname}!{SecondName}!{PhoneNumber}!{Email}";
            return res;
        }

    }
}
