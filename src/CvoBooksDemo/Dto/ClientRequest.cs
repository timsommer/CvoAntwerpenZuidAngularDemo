using System.Collections.Generic;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Dto
{
    public class GetCustomerRequestMessage
    {
        public List<Customer> Customers { get; set; }
    }

    public class SaveCustomerMessage
    {
        public Customer Customer { get; set; }
    }
}