using POSpresso.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Interfaces
{
    public interface IPaymentMethodService
    {
        Task<List<PaymentMethodDTO>> GetAllAsync();
        Task<PaymentMethodDTO?> GetByIdAsync(int id);
        Task AddAsync(PaymentMethodDTO dto);
        Task UpdateAsync(PaymentMethodDTO dto);
        Task DeleteAsync(int id);
    }
}
