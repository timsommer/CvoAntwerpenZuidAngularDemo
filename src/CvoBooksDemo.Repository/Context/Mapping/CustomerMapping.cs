using System.Data.Entity.ModelConfiguration;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Repository.Context.Mapping
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            ToTable("Customer");

            HasKey(c => c.Id);
        }
    }
}