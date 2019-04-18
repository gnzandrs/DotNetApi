using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}