using KRK_Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Auth.Seeders;

public static class UserSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>().HasData(
            new UserModel
            {
                Id = Guid.Parse("533a9b1a-49af-4f39-8603-55450458049e"),
                Email = "jp.abighosn.98@gmail.com"
            }
        );
    }
}