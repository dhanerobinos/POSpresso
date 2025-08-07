using POSpresso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{
    public class ProductCategoryDTO
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public byte[]? CategoryImage { get; set; }
    }
}
