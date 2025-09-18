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
                .Include(s => s.User)     
                .Include(s => s.SaleDetails) 
                .OrderByDescending(s => s.SaleDate)
                .ToListAsync();
        }
        public async Task<IEnumerable<DailySalesDto>> GetDailySalesAsync(DateTime startDate, DateTime endDate)
        {
            // Get sales by day
            var sales = await _context.Sales
                .Where(s => s.SaleDate.Date >= startDate.Date && s.SaleDate.Date <= endDate.Date)
                .GroupBy(s => s.SaleDate.Date)
                .Select(g => new DailySalesDto
                {
                    Date = g.Key,
                    TotalSales = g.Sum(x => x.Total)
                })
                .ToListAsync();

            //  dictionary for quick lookup
            var salesDict = sales.ToDictionary(s => s.Date, s => s.TotalSales);

            // Generate all dates in the range & fill missing days with 0
            var result = Enumerable.Range(0, (endDate - startDate).Days + 1)
                .Select(offset =>
                {
                    var date = startDate.Date.AddDays(offset);
                    return new DailySalesDto
                    {
                        Date = date,
                        TotalSales = salesDict.ContainsKey(date) ? salesDict[date] : 0
                    };
                })
                .ToList();

            return result;
        }
        public async Task<IEnumerable<BestSellerDto>> GetBestSellersAsync(DateTime startDate, DateTime endDate, int top = 5)
        {
            var bestSellers = await _context.SaleDetails
                .Where(sd => sd.Sales.SaleDate.Date >= startDate.Date && sd.Sales.SaleDate.Date <= endDate.Date)
                .GroupBy(sd => sd.Products.ProductName)
                .Select(g => new BestSellerDto
                {
                    ProductName = g.Key,
                    QuantitySold = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(b => b.QuantitySold)
                .Take(top)
                .ToListAsync();

            return bestSellers;
        }






    }
}
