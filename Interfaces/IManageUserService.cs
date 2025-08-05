using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;

namespace POSpresso.Interfaces
{
    public interface IManageUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task AddUserAsync(UserDTO userDto);
        Task UpdateUserAsync(UserDTO userDto);
        Task<bool> DeleteUserAsync(int userId);
    }
}
