using BugTracker.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Models
{
    public class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<Users>>();

            List<string> roles = new List<string>
            {
                "Submitter", "admin", "ProjectManager", "Developer"
            };

            if (!context.Roles.Any())
            {
                foreach (string role in roles)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
                context.SaveChanges();
            }



            if (!context.Users.Any())
            {
                Users seededUser = new Users
                {
                    Email = "Admin@test.ca",
                    NormalizedEmail = "ADMIN@TEST.CA",
                    UserName = "Admin@test.ca",
                    NormalizedUserName = "ADMIN@TEST.CA",
                    EmailConfirmed = true,
                };

                var password = new PasswordHasher<Users>();
                var hashed = password.HashPassword(seededUser, "P@ssword1");
                seededUser.PasswordHash = hashed;

                await userManager.CreateAsync(seededUser);
                await userManager.AddToRoleAsync(seededUser, "admin");

            }

            await context.SaveChangesAsync();
        }
    }
}

