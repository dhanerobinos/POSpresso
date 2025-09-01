using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSpresso.Domain.Entities;

namespace POSpresso.Infrastructure.Configurations
{
    public class SaleDetailConfig : IEntityTypeConfiguration<SaleDetails>
    {
        public void Configure(EntityTypeBuilder<SaleDetails> builder)
        {
            builder.HasKey(sd => sd.SaleDetailsID);

            builder.HasOne(sd => sd.Sales)
                   .WithMany(s => s.SaleDetails)
                   .HasForeignKey(sd => sd.SaleId);

            builder.HasOne(sd => sd.Products)
                   .WithMany()
                   .HasForeignKey(sd => sd.ProductId);

            builder.Property(sd => sd.Price).HasPrecision(18, 2);
            builder.Property(sd => sd.SubTotal).HasPrecision(18, 2);

            builder.Property(sd => sd.Size)
                   .HasMaxLength(50)
                   .IsRequired(false);  
        }
    }
}
