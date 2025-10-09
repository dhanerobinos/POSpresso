using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class PaymentMethodDTO
    {
        public int Id { get; set; }
        public string MethodName { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }
    }
}
