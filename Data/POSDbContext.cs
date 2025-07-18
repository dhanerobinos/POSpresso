using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POSpresso.Domain.Entities;
using POSpresso.Infrastructure.Configurations;

namespace POSpresso.Data
{
    public class POSDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public POSDbContext(DbContextOptions<POSDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
        }




        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");

                if (string.IsNullOrEmpty(connectionString))
                    throw new ArgumentException("Connection string 'DefaultConnection' not found in appsettings.json.");

                optionsBuilder.UseSqlServer(connectionString);

            }
        }
    }
}
