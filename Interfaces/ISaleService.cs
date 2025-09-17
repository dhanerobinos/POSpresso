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
    }
}
