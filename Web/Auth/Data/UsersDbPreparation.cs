using KRK_Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Auth.Data;

public class UsersDbPreparation
{
    public static void PrepPopulation(IApplicationBuilder app, bool isProd)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<AuthDbContext>()!, isProd);
        }
    }

    private static void SeedData(AuthDbContext context, bool isProd)
    {
        if (isProd)
        {
            Console.WriteLine("--> Attempting to apply migrations...");
            try
            {
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"--> Could not run migrations: {ex.Message}");
            }

            if (!context.Users.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Users.AddRange(
                    new UserModel
                    {
                        Id = Guid.Parse("5d255a37-623b-43b3-8815-3876cbaa829d"),
                        FirstName = "Jean Paul",
                        LastName = "Abi Ghosn",
                        Email = "jp.abighosn.98@gmail.com",
                        PhoneNumber = "71853050"
                    }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}