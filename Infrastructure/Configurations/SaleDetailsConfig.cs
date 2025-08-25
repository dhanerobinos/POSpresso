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

            // Relationship: each SaleDetail belongs to one Sale
            builder.HasOne(sd => sd.Sales)
                   .WithMany(s => s.SaleDetails)
                   .HasForeignKey(sd => sd.SaleId);

            // Relationship: each SaleDetail belongs to one Product
            builder.HasOne(sd => sd.Products)
                   .WithMany()
                   .HasForeignKey(sd => sd.ProductId);

            // Decimal precision
            builder.Property(sd => sd.Price)
                   .HasColumnType("decimal(18,2)");

            builder.Property(sd => sd.SubTotal)
                   .HasColumnType("decimal(18,2)");

            // Optional: require Size
            builder.Property(sd => sd.Size)
                   .HasMaxLength(50)
                   .IsRequired();
        }
    }
}
