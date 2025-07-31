using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;

namespace POSpresso.Domain.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; } 
        public decimal ProductPrice { get; set; }
        public  DateTime ProductCreatedAt { get; set; }
        public ProductStatus ProductStatus { get; set; } = ProductStatus.Available;
        public byte[]? ProductImage { get; set; }

        // Foreign key to the Category table
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;
    }
}
