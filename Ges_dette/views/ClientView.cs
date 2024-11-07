using Ges_dette.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ges_dette.views
{
    public abstract class ClientView
    {
        public static void ListClients(List<entities.Client> clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine(client);
            }

        }
        public static Client CreateClient()
        {
            Console.Write("Surnom :");
            string surnom = Console.ReadLine();
            Console.Write("Telephone");
            string telephone = Console.ReadLine();
            Console.Write("addresse");
            string addresse = Console.ReadLine();
            return new Client { Surnom = surnom,Telephone = telephone };
    }
}
