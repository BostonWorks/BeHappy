using Microsoft.EntityFrameworkCore;

namespace behappy.Persistance
{
    public class BeHappyDbContext: DbContext
    {
        public BeHappyDbContext(DbContextOptions<BeHappyDbContext> options)
            :base(options)
        {
            
        }
    }
}