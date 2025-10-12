using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.Entities
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string MethodName { get; set; } = string.Empty;
        public bool IsEnabled { get; set; } = true;
        public bool IsDefault { get; set; } = false;
        public byte[]? PaymentImage { get; set; }
    }
}
