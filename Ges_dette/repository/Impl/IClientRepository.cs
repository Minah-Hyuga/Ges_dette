using Ges_dette.entities;

namespace Ges_dette.repositories.list
{
    internal interface IClientRepository : IRepository<Client>
    {
        Client SelectBySurname(string value);
    }
}
