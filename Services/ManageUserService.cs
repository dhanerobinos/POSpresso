using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;    

namespace POSpresso.Services
{
    public class ManageUserService
    {
        private readonly POSDbContext _context;

       public ManageUserService(POSDbContext context)
        {
          _context = context;
        }

        public async Task<List<User>> GetAllUsersAsync() =>
                await _context.User.ToListAsync();

        //INSERT INTO Users (...) VALUES (...); in ADO.NET 
        //use DTO for services and UI(best practice)
        public async Task AddUserAsync(UserDTO userDto)
        {
            // Checks of username already exists (case-insensitive match)
            var existingUser = await _context.User
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == userDto.Username.ToLower());

            if (existingUser != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }
            var user = new User
            {
                Username = userDto.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password),
                RequiresPasswordChange = true,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Role = userDto.Role,
                Status = userDto.Status,
                UserImage = userDto.UserImage
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return null;

            return user;
        }

        public async Task UpdateUserAsync(UserDTO userDto)
        {
            var user = await _context.User.FindAsync(userDto.UserId);
            if (user == null)
                throw new Exception("User not found");

                user.Username = userDto.Username;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.Role = userDto.Role;
                user.Status = userDto.Status;
                user.UserImage = userDto.UserImage;
                user.RequiresPasswordChange = userDto.RequiresPasswordChange;

            if (!string.IsNullOrEmpty(userDto.Password))
            {
                user.Password = userDto.Password;
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.User.FindAsync(userId);
            if (user == null) return false;

            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

