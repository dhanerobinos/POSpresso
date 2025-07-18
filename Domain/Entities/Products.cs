using POSpresso.Domain.Entities;

namespace POSpresso.Domain.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; } 
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public  DateTime CreatedAt { get; set; }

        // Foreign key to the Category table
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;
    }
}
