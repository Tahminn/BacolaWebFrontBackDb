#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BacolaFrontBackDatabase.Models;

namespace BacolaFrontBackDatabase.Data
{
    public class BacolaFrontBackDatabaseContext : DbContext
    {
        public BacolaFrontBackDatabaseContext (DbContextOptions<BacolaFrontBackDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<BacolaFrontBackDatabase.Models.Product> Product { get; set; }
    }
}
