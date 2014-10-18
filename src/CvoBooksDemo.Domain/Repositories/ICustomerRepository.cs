using System.Collections.Generic;

namespace CvoBooksDemo.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);

        IEnumerable<Customer> Get();

        void Save(Customer customer);

        void Delete(int id);
    }
}