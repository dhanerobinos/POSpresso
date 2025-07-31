using POSpresso.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductIsAvailable { get; set; } = true;
        public DateTime ProductCreatedAt { get; set; }
        public ProductStatus ProductStatus { get; set; } = ProductStatus.Available;
        public byte[]? ProductImage { get; set; }
        public int CategoryID { get; set; }

    }
}
