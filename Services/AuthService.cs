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

        public async Task<bool> AddAsync(User user)
        {
            _context.User.Add(user);
            return await _context.SaveChangesAsync() > 0;
        }
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
