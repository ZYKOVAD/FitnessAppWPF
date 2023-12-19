using FitnessApp.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FitnessApp
{
    internal class Client : Person
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string SecondName { get; set; }
        public override string PhoneNumber { get; set; }
        public override string Email { get; set; }
        public int NumberDeal { get; set; }  // номер договора

        public Membership Membership { get; set; } // абонемент

        public Client(int id, string name, string Surname, string secondName, string phoneNumber, string Email, int NumberDeal, int idTrainer, string cost, string dataStart, string dataEnd) //для считывания
        {
            this.ID = id;
            this.Name = name;
            this.Surname = Surname;
            this.SecondName = secondName;
            this.PhoneNumber = phoneNumber;
            this.Email = Email;
            this.NumberDeal = NumberDeal;

            Membership = new Membership(idTrainer, cost, dataStart, dataEnd);
        }

        public Client(string name, string Surname, string secondName, string phoneNumber, string Email, int NumberDeal, int idTrainer, string cost, string dataStart, string dataEnd) //для создания
        {
            int LastID = int.Parse(File.ReadAllText("LastID.txt"));
            LastID++;
            this.ID = LastID;
            File.WriteAllText("LastID.txt", LastID.ToString());
            this.Name = name;
            this.Surname = Surname;
            this.SecondName = secondName;
            this.PhoneNumber = phoneNumber;
            this.Email = Email;
            this.NumberDeal = NumberDeal;

            Membership = new Membership(idTrainer, cost, dataStart, dataEnd);


        }



        public Client() { }

        public override string ToString()
        {
            string memb = Membership.ToString();
            string str = $"{ID}!{Name}!{Surname}!{SecondName}!{PhoneNumber}!{Email}!{NumberDeal}!" + memb;
            return str;
        }
    }
}
