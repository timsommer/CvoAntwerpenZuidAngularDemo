using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Repository.Context
{
    public interface ICvoCustomerContext
    {
        Database Database { get; }

        DbSet<Customer> Customers { get; set; }



        int SaveChanges();


        DbEntityEntry Entry(object entity);


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}