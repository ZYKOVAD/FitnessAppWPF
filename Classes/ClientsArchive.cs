using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace FitnessApp.Classes
{
    internal class ClientsArchive { 

        public static Client GetClientById(int id, List<Client> list)
        {
            Client res = null;

            foreach (Client client in list)
            {
                if (client.ID == id)
                {
                    res = client;
                    return res;
                }
            }

            return res;

        }
        public static Client GetClientById(int id)
        {
            Client res = null;
            List<Client> list = Read();

            foreach (Client client in list)
            {
                if (client.ID == id)
                {
                    res = client;
                    return res;
                }
            }

            return res;

        }

        public static int GetIndexClientByID(int id, List<Client> list)
        {
            int res;
            int index = 0;
            foreach (Client cl in list)
            {
                if (cl.ID == id)
                {
                    res = index;
                    return res;
                }
                index++;
            }
            return -1;
        }

        public static void Write(Client client)   
        {
            var path = "dataArchive.txt";
            string str = client.ToString();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(str);
            }

        }

        public static void Write(List<Client> list)  //функция перезаписи файла
        {
            var path = "dataArchive.txt";

            File.WriteAllText(path, string.Empty);

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (Client client in list)
                {
                    string str = client.ToString();
                    writer.WriteLine(str);
                }
            }
        }

        public static List<Client> Read()
        {
            var path = "dataArchive.txt";
            List<Client> res = new List<Client>();

            string[] clients = File.ReadAllLines(path);
            try
            {
                foreach (string str in clients)
                {
                    string[] data = str.Split('!');
                    Client client = new Client();
                    client.ID = int.Parse(data[0]);
                    client.Name = data[1];
                    client.Surname = data[2];
                    client.SecondName = data[3];
                    client.PhoneNumber = data[4];
                    client.Email = data[5];
                    int nd = int.Parse(data[6]);
                    client.NumberDeal = nd;
                    string dataend = data[9];
                    client.Membership = new Membership()
                    {
                        PersonalTrainerID = int.Parse(data[7]),
                        Cost = data[8],
                        DataStart = data[9],
                        DataEnd = data[10]
                    };
                    res.Add(client);
                }
                return res;

            }
            catch
            {
                return new List<Client>();
            }
            
        }

        public static void Delete(int id)
        {
            List<Client> list = Read();
            foreach (Client client in list)
            {
                if (client.ID == id)
                {
                    list.Remove(client);
                    break;
                }
            }
            Write(list);
        }
    }
}
