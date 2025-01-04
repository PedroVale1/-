using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data.Mappings;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=ProductCatalog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductModelMap());
        }
    }
}
