using System.Collections.Generic;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Dto
{

    public class GetClientsRequestMessage
    {
        public List<Client> Clients { get; set; }
    }

    public class SaveClientMessage
    {
        public Client Client { get; set; }
    }
}