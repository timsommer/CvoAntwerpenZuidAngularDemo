using System.Collections.Generic;

namespace CvoBooksDemo.Domain
{
    public class Customer : DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Address { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string IsFavorite { get; set; }
    }

    public abstract class DomainObject
    {
        public int Id { get; set; }

    }


}