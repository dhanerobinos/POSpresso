using POSpresso.Domain.Entities;    

namespace POSpresso.Domain.Entities
{
    public class SaleDetails
    {
        public int SaleDetailsID { get; set; }

        // Foreign key to Sale
        public int SaleId { get; set; }
        public Sales Sales { get; set; }

        // Reference to product
        public int ProductId { get; set; }
        public Products Products { get; set; }

        // Order info
        public string Size { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
    }
}
