using POSpresso.Domain.DTO;

namespace POSpresso.Interfaces
{
    public interface ISaleService
    {
        Task<int> CheckoutAsync(List<CartItem> cartItems);
        Task<int> SaveSaleAsync(SaleDTO dto);
    }
}
