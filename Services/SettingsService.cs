using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Interfaces;
using System.Threading.Tasks;

namespace POSpresso.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly IDbContextFactory<POSDbContext> _contextFactory;

        public SettingsService(IDbContextFactory<POSDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<SettingsDTO?> GetSettingsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            var entity = await context.SettingsEntity.FirstOrDefaultAsync();
            if (entity == null) return null;

            return new SettingsDTO
            {
                CafeName = entity.CafeName,
                Address = entity.Address,
                Contact = entity.Contact,
            };
        }

        public async Task SaveSettingsAsync(SettingsDTO dto)
        {
            using var context = _contextFactory.CreateDbContext();
            var existing = await context.SettingsEntity.FirstOrDefaultAsync();

            if (existing == null)
            {
                var newEntity = new SettingsEntity
                {
                    CafeName = dto.CafeName,
                    Address = dto.Address,
                    Contact = dto.Contact,
                };
                context.SettingsEntity.Add(newEntity);
            }
            else
            {
                existing.CafeName = dto.CafeName;
                existing.Address = dto.Address;
                existing.Contact = dto.Contact;
            }

            await context.SaveChangesAsync();
        }
    }
}
