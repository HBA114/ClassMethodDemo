using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class ClientManager : Client
    {

        Client[] clients = new Client[10];
        int i = 0;
        public void Add(string name, string surname , int id)
        {
            clients[i] = new Client();
            clients[i].Id = id;
            clients[i].Name = name;
            clients[i].SurName = surname;
            i++;
        }

        public void Delete(int id)
        {
            for(int k = 0; k < i; k++)
            {
                if(clients[k].Id == id)
                {
                    clients[k] = null;
                    //clients[k].Id = 0;
                    //clients[k].Name = null;
                    //clients[k].SurName = null;

                }
            }
        }


        public void List()
        {
            for(int j = 0; j < i; j++ )
            {
                if(clients[j] != null)
                    Console.WriteLine("\nName : "+clients[j].Name+"\nSurname : "+clients[j].SurName+"\nId : "+clients[j].Id);
            }
        }
    }
}
