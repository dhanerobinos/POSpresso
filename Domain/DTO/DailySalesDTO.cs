using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class DailySalesDTO
    {
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
    }
}

