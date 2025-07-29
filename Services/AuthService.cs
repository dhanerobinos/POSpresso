using POSpresso.Data;
using POSpresso.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace POSpresso.Services
{
    public class AuthService
    {
        private readonly POSDbContext _context;
        public AuthService(POSDbContext context)
        {
            _context = context;
        }
        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.User
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        public async Task UpdatePasswordAsync(int userId, string newPassword)
        {
            var user = await _context.User.FindAsync(userId);
            if (user == null) throw new Exception("User not found");

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.RequiresPasswordChange = false; 

            _context.User.Update(user);
            await _context.SaveChangesAsync();
        }

    }
}
