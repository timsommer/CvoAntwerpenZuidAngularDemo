using System.Data.Entity;
using CvoBooksDemo.Domain;
using CvoBooksDemo.Repository.Context.Mapping;

namespace CvoBooksDemo.Repository.Context
{
    public class CvoBooksContext : DbContext, ICvoBooksContext
    {
        public CvoBooksContext()
        {
            Database.SetInitializer<CvoBooksContext>(null);
            // We're using eager loading in this application.
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;

        }

        public DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientMapping());
        }

    }
}