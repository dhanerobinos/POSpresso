using POSpresso.Domain.Enums;
namespace POSpresso.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Cashier;
        public UserStatus Status { get; set; } = UserStatus.Active;
        public byte[]? UserImage { get; set; }
        public bool RequiresPasswordChange { get; set; } = true;

    }
}
