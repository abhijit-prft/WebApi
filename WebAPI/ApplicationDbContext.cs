using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Workshop> Workshops { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }

    }
}
