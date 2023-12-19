using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    abstract internal class Person
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string SecondName { get; set; }
        public abstract string PhoneNumber { get; set; }
        public abstract string Email { get; set; }
    }
}
