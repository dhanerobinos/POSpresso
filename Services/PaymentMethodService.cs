using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Interfaces;
namespace POSpresso.Services
{
    public class PaymentMethodService: IPaymentMethodService
    {
        private readonly IDbContextFactory<POSDbContext> _contextFactory;

        public PaymentMethodService(IDbContextFactory<POSDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<PaymentMethodDTO>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.PaymentMethod
                .Select(p => new PaymentMethodDTO
                {
                    Id = p.Id,
                    MethodName = p.MethodName,
                    Type = p.Type,
                    IsEnabled = p.IsEnabled,
                    IsDefault = p.IsDefault
                })
                .ToListAsync();
        }

        public async Task<PaymentMethodDTO?> GetByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var entity = await context.PaymentMethod.FindAsync(id);
            if (entity == null) return null;

            return new PaymentMethodDTO
            {
                Id = entity.Id,
                MethodName = entity.MethodName,
                Type = entity.Type,
                IsEnabled = entity.IsEnabled,
                IsDefault = entity.IsDefault
            };
        }

        public async Task AddAsync(PaymentMethodDTO dto)
        {
            using var context = _contextFactory.CreateDbContext();

            var entity = new PaymentMethod
            {
                MethodName = dto.MethodName,
                Type = dto.Type,
                IsEnabled = dto.IsEnabled,
                IsDefault = dto.IsDefault
            };

            context.PaymentMethod.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PaymentMethodDTO dto)
        {
            using var context = _contextFactory.CreateDbContext();

            var entity = await context.PaymentMethod.FindAsync(dto.Id);
            if (entity == null) return;

            entity.MethodName = dto.MethodName;
            entity.Type = dto.Type;
            entity.IsEnabled = dto.IsEnabled;
            entity.IsDefault = dto.IsDefault;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var entity = await context.PaymentMethod.FindAsync(id);
            if (entity != null)
            {
                context.PaymentMethod.Remove(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
