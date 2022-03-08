#nullable disable
using Microsoft.EntityFrameworkCore;

namespace BacolaFrontBackDatabase.Data
{
    public class BacolaFrontBackDatabaseContext : DbContext
    {
        public BacolaFrontBackDatabaseContext(DbContextOptions<BacolaFrontBackDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<BacolaFrontBackDatabase.Models.Product> Product { get; set; }
    }
}
