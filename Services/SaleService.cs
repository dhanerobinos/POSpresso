using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.Entities;
using POSpresso.Domain.DTO;


namespace POSpresso.Services
{
    public class SaleService
    {
        private readonly POSDbContext _context;

        public SaleService(POSDbContext context)
        {
            _context = context;
        }
        public async Task<int> CheckoutAsync(List<CartItem>cartItems)
        {
            var sale = new Sales
            {
                SaleDate = DateTime.Now,
                TotalAmount = cartItems.Sum(ci => ci.SubTotal),
                SaleDetails = cartItems.Select(ci => new SaleDetails
                {
                    ProductId = ci.ProductId,
                    Size = ci.Size,
                    Quantity = ci.Quantity,
                    Price = ci.Price,
                    SubTotal = ci.SubTotal
                }).ToList()
            };
            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();

            return sale.Id;
        }
    }
}
