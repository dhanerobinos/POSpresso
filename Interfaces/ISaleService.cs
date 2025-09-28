using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;

namespace POSpresso.Interfaces
{
    public interface ISaleService
    {
        Task<int> CheckoutAsync(List<CartItem> cartItems);
        Task<int> SaveSaleAsync(SaleDTO dto);
        Task<List<Sales>> GetSalesAsync(DateTime? startDate = null, DateTime? endDate = null);
        Task<IEnumerable<DailySalesDto>> GetDailySalesAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<BestSellerDto>> GetBestSellersAsync(DateTime startDate, DateTime endDate, int top = 5);
        Task<decimal> GetMonthlyTotalSalesAsync(DateTime month);
        Task<int> GetMonthlyTransactionCountAsync(DateTime month);
        Task<decimal> GetMonthlyRevenueAsync(DateTime month);
        Task<List<DailySalesDTO>> GetDailyItemsSoldAsync(DateTime start, DateTime end);
        Task<List<TodayProductSalesDTO>> GetTodayProductSalesAsync();

    }
}
