using behappy.Model;
using Microsoft.EntityFrameworkCore;

namespace behappy.Persistance
{
    public class BeHappyDbContext: DbContext
    {
       public DbSet<User> Users {get; set;}
        public BeHappyDbContext(DbContextOptions<BeHappyDbContext> options)
            :base(options)
        {
            
        }
    }
}