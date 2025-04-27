
using Microsoft.AspNetCore.Identity;
using School.Domain.Enums;

namespace School.Domain.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserRole Role { get; set; } // Your existing enum
}