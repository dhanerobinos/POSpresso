using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class SettingsDTO
    {
        public string CafeName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string ReceiptFooter { get; set; } = string.Empty;
        public decimal TaxRate { get; set; }
        public decimal DefaultDiscount { get; set; }
    }
}
