using Ges_dette.services;
using Ges_dette.views;
using System;

namespace Ges_dette
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        ClientService.Add(ClientView.Saisir());
                        break;
                    case 2:
                        ClientView.Afficher(ClientService.GetAll());
                        break;
                    case 3:
                        UserRepository.Insert(null);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);

            Console.WriteLine("Hello world!");
        }

        public static int Menu()
        {
            Console.WriteLine("1- Créer un client");
            Console.WriteLine("2- Lister les clients");
            Console.WriteLine("3- Créer un user");
            Console.Write("Faites votre choix : ");
            return int.Parse(Console.ReadLine());
        }
    }
}
