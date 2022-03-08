using BacolaFrontBackDatabase.Data;
using Microsoft.EntityFrameworkCore;


namespace BacolaFrontBackDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BacolaFrontBackDatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BacolaFrontBackDatabaseContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(

                );
                context.SaveChanges();
            }
        }
    }
}
