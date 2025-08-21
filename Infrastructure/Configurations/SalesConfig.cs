using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSpresso.Domain.Entities;

namespace POSpresso.Infrastructure.Configurations
{
    public class SaleConfig : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany(s => s.SaleDetails)
                   .WithOne(sd => sd.Sales)
                   .HasForeignKey(sd => sd.SaleId);

            builder.Property(s => s.TotalAmount)
                   .HasColumnType("decimal(18,2)");
        }
    }
}
