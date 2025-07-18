

namespace POSpresso.Domain.Entities
{
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } 

        public ICollection<Products> Products { get; set; } = new List<Products>();
    }
}
