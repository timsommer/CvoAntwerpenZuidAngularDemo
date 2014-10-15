using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CvoBooksDemo.Domain;

namespace CvoBooksDemo.Repository.Context
{
    public interface ICvoBooksContext
    {
        Database Database { get; }

        DbSet<Client> Client { get; set; }



        int SaveChanges();


        DbEntityEntry Entry(object entity);


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}