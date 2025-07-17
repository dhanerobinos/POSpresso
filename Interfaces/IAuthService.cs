using POSpresso.Domain.Entities;

namespace POSpresso.Interfaces
{
    public interface IAuthService
    {
        Task<User?> GetByUsernameAsync(string username);
        bool VerifyPassword(string password, string hashedPassword);
    }

}
