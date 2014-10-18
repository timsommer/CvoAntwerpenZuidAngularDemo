using System.Collections.Generic;
using System.Linq;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Domain.Repositories;
using CvoBooksDemo.Repository.Context;

namespace CvoBooksDemo.Repository.Repository
{

    public class CustomerRepository : ICustomerRepository
    {
        // Private fields
        private readonly ICvoCustomerContext _cvoCustomerContext;

        
        // Class initializers
        public CustomerRepository() : this(new CvoCustomerContext())
        {
            
        }

        
        public CustomerRepository(ICvoCustomerContext cvoCustomerContext)
        {
            _cvoCustomerContext = cvoCustomerContext;
        }



        // Public methods
        public Customer Get(int id)
        {
            return _cvoCustomerContext.Customers.Single(c => c.Id == id);
        }


        public IEnumerable<Customer> Get()
        {
            return _cvoCustomerContext.Customers.ToList();
        }


        public void Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _cvoCustomerContext.Customers.Add(customer);
                _cvoCustomerContext.SaveChanges();
            }
            else
            {
                _cvoCustomerContext.Customers.Attach(customer);
                _cvoCustomerContext.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var client = _cvoCustomerContext.Customers.Single(c => c.Id == id);
            _cvoCustomerContext.Customers.Remove(client);
            _cvoCustomerContext.SaveChanges();
        }
    }
}