using System.Collections.Generic;
using System.Linq;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Domain.Repositories;
using CvoBooksDemo.Repository.Context;

namespace CvoBooksDemo.Repository.Repository
{

    public class ClientRepository : IClientRepository
    {
        // Private fields
        private readonly ICvoBooksContext _cvoBooksContext;

        
        // Class initializers
        public ClientRepository() : this(new CvoBooksContext())
        {
            
        }

        
        public ClientRepository(ICvoBooksContext cvoBooksContext)
        {
            _cvoBooksContext = cvoBooksContext;
        }

        public Client Get(int id)
        {
            return _cvoBooksContext.Client.Single(c => c.Id == id);
        }

        public IEnumerable<Client> Get()
        {
            return _cvoBooksContext.Client.ToList();
        }

        public void Save(Client client)
        {
            if (client.Id == 0)
            {
                _cvoBooksContext.Client.Add(client);
                _cvoBooksContext.SaveChanges();
            }
            else
            {
                _cvoBooksContext.Client.Attach(client);
                _cvoBooksContext.SaveChanges();
            }
        }
    }
}