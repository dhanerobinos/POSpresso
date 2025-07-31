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

            builder.Property(p => p.ProductDescription)
                   .HasMaxLength(255);

            builder.Property(p => p.ProductPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(p => p.ProductStatus)
                   .HasConversion<string>() //enum to string in db
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(p => p.ProductCreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(p => p.ProductCategory)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
