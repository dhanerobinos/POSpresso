using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }

        // Navigation property
        public ICollection<SaleDetails> SaleDetails { get; set; }
    }
}
