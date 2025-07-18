using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSpresso.Domain.Entities;

namespace POSpresso.Infrastructure.Configurations
{
    public class ProductConfig: IEntityTypeConfiguration<Products>   
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Description)
                   .HasMaxLength(255);

            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(p => p.IsAvailable)
                   .IsRequired();

            builder.Property(p => p.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.ProductCategory)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
