using System.Data.Entity.ModelConfiguration;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Repository.Context.Mapping
{
    public class ClientMapping : EntityTypeConfiguration<Client>
    {
        public ClientMapping()
        {
            ToTable("Client");

            HasKey(c => c.Id);
        }
    }
}