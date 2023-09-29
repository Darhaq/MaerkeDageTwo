using Microsoft.EntityFrameworkCore;

namespace MaerkeDageTwo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Birthday> Birthdays { get; set; }
    }
}
