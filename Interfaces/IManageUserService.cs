using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;

namespace POSpresso.Interfaces
{
    public interface IManageUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(UserDTO userDto);
        Task<bool> DeleteUserAsync(int userId);
    }
}
