using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.Entities;
using POSpresso.Domain.DTO;
using POSpresso.Interfaces;


namespace POSpresso.Services
{
    public class SaleService: ISaleService
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
                SubTotal = Math.Round(dto.Subtotal, 2),
                Tax = Math.Round(dto.Tax, 2),
                Total = Math.Round(dto.Total, 2),
                SaleDate = DateTime.Now,
                SaleDetails = dto.Items.Select(i => new SaleDetails
                {
                    ProductId = i.ProductId,
                    Size = i.Size,
                    Quantity = i.Quantity,
                    Price = Math.Round(i.Price, 2),
                    SubTotal = Math.Round(i.Price * i.Quantity, 2)
                }).ToList()
            };

            try
            {
                _context.Sales.Add(sale);
                await _context.SaveChangesAsync();
                return sale.SaleId;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                throw;
            }
        }
        public async Task<List<Sales>> GetSalesAsync(DateTime? start = null, DateTime? end = null)
        {
            var query = _context.Sales.AsQueryable();

            if (start.HasValue)
                query = query.Where(s => s.SaleDate >= start.Value);

            if (end.HasValue)
                query = query.Where(s => s.SaleDate <= end.Value);

            return await query
                .Include(s => s.SaleDetails) // so details are loaded
                .OrderByDescending(s => s.SaleDate)
                .ToListAsync();
        }
    }
}
