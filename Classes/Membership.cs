using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FitnessApp
{
    internal class Membership
    {
        public Membership(int idTrainer, string cost, string dataStart, string dataEnd)
        {
            PersonalTrainerID = idTrainer;
            Cost = cost;
            DataStart = dataStart;
            DataEnd = dataEnd;
        }

        public Membership() { }
        public int PersonalTrainerID {  get; set; }
        public string Cost {  get; set; }
        public string DataStart {  get; set; }
        public string DataEnd { get; set; }

        public override string ToString()
        {
            string str = $"{PersonalTrainerID}!{Cost}!{DataStart}!{DataEnd}";
            return str ;
        }
    }
}
