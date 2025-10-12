using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.Entities
{
    public class Sales
    {
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; } = DateTime.Now; 

        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        // Foreign Key to User
        public int UserId { get; set; }
        public User User { get; set; }

        //FK to PaymentMethod
        public int PaymentMethodId { get; set; } // FK
        public PaymentMethod PaymentMethod { get; set; }

        // Navigation collection (line items)
        public ICollection<SaleDetails> SaleDetails { get; set; } = new List<SaleDetails>();
    }
}
