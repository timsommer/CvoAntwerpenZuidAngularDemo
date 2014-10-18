using System.Collections.Generic;

namespace CvoBooksDemo.Domain.Repositories
{
    public interface IClientRepository
    {
        Client Get(int id);

        IEnumerable<Client> Get();

        void Save(Client client);

        void Delete(int id);
    }
}