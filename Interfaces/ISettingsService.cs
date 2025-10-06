using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using System.Threading.Tasks;

namespace POSpresso.Interfaces
{
    public interface ISettingsService
    {
        Task<SettingsDTO?> GetSettingsAsync();
        Task SaveSettingsAsync(SettingsDTO setting);
    }
}
