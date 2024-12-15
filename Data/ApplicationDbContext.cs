using Microsoft.EntityFrameworkCore;
using Friends_Web_App.Models;

namespace Friends_Web_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
            
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
