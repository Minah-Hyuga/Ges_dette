using System.Collections.Generic;
using System.Linq;
using Ges_dette.entities;

namespace Ges_dette.repository.Impl
{
    internal class ClientRepository : RepositoryImpl<Client>, IClientRepository
    {
        private List<Client> list;

        public ClientRepository()
        {
            list = new List<Client>(); 
        }

        public Client SelectBySurname(string value)
        {
            return list.FirstOrDefault(cl => cl.surname == value);
        }

        public void AddClient(Client client)
        {
            list.Add(client);
        }

        // Autres méthodes à implémenter selon les besoins...
    }
}
