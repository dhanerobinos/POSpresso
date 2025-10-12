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
                    IsEnabled = p.IsEnabled,
                    IsDefault = p.IsDefault,
                    PaymentImage =p.PaymentImage
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
                IsEnabled = entity.IsEnabled,
                IsDefault = entity.IsDefault,
                PaymentImage = entity.PaymentImage
            };
        }

        public async Task AddAsync(PaymentMethodDTO dto)
        {
            using var context = _contextFactory.CreateDbContext();

            var entity = new PaymentMethod
            {
                MethodName = dto.MethodName,
                IsEnabled = dto.IsEnabled,
                IsDefault = dto.IsDefault,
                PaymentImage = dto.PaymentImage
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
            entity.IsEnabled = dto.IsEnabled;
            entity.IsDefault = dto.IsDefault;

            if (dto.PaymentImage != null)
                entity.PaymentImage = dto.PaymentImage;

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
