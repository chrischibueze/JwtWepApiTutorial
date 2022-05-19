using JwtWepApiTutorial.Model;
using Microsoft.EntityFrameworkCore;

namespace JwtWepApiTutorial
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<user> users { get; set; }

    }
}
