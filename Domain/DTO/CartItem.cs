using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }  //per unit
        public decimal SubTotal => Quantity * Price;  
        public byte[]? ProductImage { get; set; }  
    }
}
