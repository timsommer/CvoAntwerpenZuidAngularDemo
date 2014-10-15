using System.Collections.Generic;

namespace CvoBooksDemo.Domain
{
    public class Client : DomainObject
    {
        public string Name { get; set; }        
        public string Address { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
    }

    public abstract class DomainObject
    {
        public int Id { get; set; }

    }


}