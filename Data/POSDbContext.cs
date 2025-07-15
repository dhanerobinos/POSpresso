using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POSpresso.Domain.Entities; 

namespace POSpresso.Data
{
    internal class POSDbContext: DbContext
    {
        public DbSet<User> User { get; set; }
      

  
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            optionsBuilder.UseSqlServer(connectionString: configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
