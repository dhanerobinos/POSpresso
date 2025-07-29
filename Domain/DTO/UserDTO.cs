using POSpresso.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Domain.DTO
{                                                                                  //DTO - Data Transfer Object, for UI, no sensitive data like password
    public class UserDTO
    {
         public int UserId { get; set; }  // Optional when adding
         public string Username { get; set; } = string.Empty;
         public string Password { get; set; } = string.Empty; // Optional when adding, for new users
         public string FirstName { get; set; } = string.Empty;
         public string LastName { get; set; } = string.Empty;
         public UserStatus Status { get; set; } = UserStatus.Active;
         public UserRole Role { get; set; } = UserRole.Cashier;
         public byte[]? UserImage { get; set; }
         public bool RequiresPasswordChange { get; set; } = true;



    }
}

