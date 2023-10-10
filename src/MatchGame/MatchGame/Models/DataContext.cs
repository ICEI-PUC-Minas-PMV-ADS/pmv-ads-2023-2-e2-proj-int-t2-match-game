using Microsoft.EntityFrameworkCore;

namespace MatchGame.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
        
        
        
        
        
        }


        public  DbSet<User> Users { get; set; }


    }
}
