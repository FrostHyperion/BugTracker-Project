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



            if (!userManager.Users.Any())
            {
                Users Admin = new Users
                {
                    Email = "Admin@test.ca",
                    NormalizedEmail = "ADMIN@TEST.CA",
                    UserName = "Admin@test.ca",
                    NormalizedUserName = "ADMIN@TEST.CA",
                    EmailConfirmed = true,
                };
                Users projectManager = new Users
                {
                    Email = "projectManager@test.ca",
                    NormalizedEmail = "PROJECTMANAGER@TEST.CA",
                    UserName = "projectManager@test.ca",
                    NormalizedUserName = "PROJECTMANAGER@TEST.CA",
                    EmailConfirmed = true,
                };
                Users Submitter = new Users
                {
                    Email = "Submitter@test.ca",
                    NormalizedEmail = "SUBMITTER@TEST.CA",
                    UserName = "Submitter@test.ca",
                    NormalizedUserName = "SUBMITTER@TEST.CA",
                    EmailConfirmed = true,
                };
                Users Developer = new Users
                {
                    Email = "Developer@test.ca",
                    NormalizedEmail = "DEVELOPER@TEST.CA",
                    UserName = "Developer@test.ca",
                    NormalizedUserName = "DEVELOPER@TEST.CA",
                    EmailConfirmed = true,
                };
                Users seededUser = new Users
                {
                    Email = "User@test.ca",
                    NormalizedEmail = "USER@TEST.CA",
                    UserName = "User@test.ca",
                    NormalizedUserName = "USER@TEST.CA",
                    EmailConfirmed = true,
                };

                var password = new PasswordHasher<Users>();
                var hashed = password.HashPassword(seededUser, "P@ssword1");
                seededUser.PasswordHash = hashed;
                await userManager.CreateAsync(seededUser);
                await userManager.AddToRoleAsync(seededUser, "admin");


                var hashedProjectManager = password.HashPassword(projectManager, "P@ssword1");
                projectManager.PasswordHash = hashedProjectManager;
                await userManager.CreateAsync(projectManager);
                await userManager.AddToRoleAsync(projectManager, "projectManager");


                var hashedSubmitter = password.HashPassword(Submitter, "P@ssword1");
                Submitter.PasswordHash = hashedSubmitter;
                await userManager.CreateAsync(Submitter);
                await userManager.AddToRoleAsync(Submitter, "Submitter");

                var hashedDeveloper = password.HashPassword(Developer, "P@ssword1");
                Developer.PasswordHash = hashedDeveloper;
                await userManager.CreateAsync(Developer);
                await userManager.AddToRoleAsync(Developer, "Developer");


                var hashedAdmin = password.HashPassword(Admin, "P@ssword1");
                Admin.PasswordHash = hashedAdmin;
                await userManager.CreateAsync(Admin);
                await userManager.AddToRoleAsync(Admin, "admin");

            }

            await context.SaveChangesAsync();
        }
    }
}


