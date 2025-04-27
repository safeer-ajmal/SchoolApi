using School.Domain.Entities;
using School.Domain.Enums;
using Microsoft.AspNetCore.Identity;

public static class AdminSeed
{
    public static async Task SeedAdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        // Create Admin Role
        if (!await roleManager.RoleExistsAsync("Admin"))
            await roleManager.CreateAsync(new IdentityRole("Admin"));

        // Create Default Admin
        if (await userManager.FindByEmailAsync("admin@school.com") == null)
        {
            var admin = new User
            {
                UserName = "admin@school.com",
                Email = "admin@school.com",
                FirstName = "Super",
                LastName = "Admin",
                Role = UserRole.Admin
            };
            await userManager.CreateAsync(admin, "Admin@1234");
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}