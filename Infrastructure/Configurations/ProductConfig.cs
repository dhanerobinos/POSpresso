using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSpresso.Domain.Entities;

namespace POSpresso.Infrastructure.Configurations
{
    public class ProductConfig: IEntityTypeConfiguration<Products>   
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
          
        }
    }
}
