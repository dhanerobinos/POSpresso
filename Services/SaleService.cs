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
                Total = cartItems.Sum(ci => ci.SubTotal),
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

            return sale.SaleId;
        }
        public async Task<int> SaveSaleAsync(SaleDTO dto)
        {
            var sale = new Sales
            {
                UserId = dto.UserId,
                SubTotal = dto.Subtotal,
                Tax = dto.Tax,
                Total = dto.Total,
                SaleDate = DateTime.Now,
                SaleDetails = dto.Items.Select(i => new SaleDetails
                {
                    ProductId = i.ProductId,
                    Size = i.Size,
                    Quantity = i.Quantity,
                    Price = i.Price,
                    SubTotal = i.Price * i.Quantity
                }).ToList()
            };

            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();

            return sale.SaleId;
        }
    }
}
