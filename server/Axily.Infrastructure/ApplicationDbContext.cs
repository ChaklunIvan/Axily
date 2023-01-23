using Axily.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Axily.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
