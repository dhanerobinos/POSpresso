using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; } 
        public decimal Price { get; set; }
        public bool isAvailable { get; set; } = true;
        public  DateTime CreatedAt { get; set; }

        // Foreign key to the Category table
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
