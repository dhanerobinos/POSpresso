using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class CashierDashboardDTO
    {
        public decimal TotalSales { get; set; }
        public int Transactions { get; set; }
        public int ItemsSold { get; set; }
    }
}
