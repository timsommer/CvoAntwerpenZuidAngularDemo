using System.Data.Entity;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Repository.Context.Mapping;

namespace CvoBooksDemo.Repository.Context
{
    public class CvoCustomerContext : DbContext, ICvoCustomerContext
    {
        public CvoCustomerContext()
        {
            Database.SetInitializer<CvoCustomerContext>(null);
            // We're using eager loading in this application.
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
        }

    }
}