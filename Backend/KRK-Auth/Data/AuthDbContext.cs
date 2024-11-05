using KRK_Auth.Models;
using KRK_Auth.ModelsConfiguration;
using KRK_Auth.Seeders;
using Microsoft.EntityFrameworkCore;

namespace KRK_Auth.Data;

public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserModelConfiguration());

        UserSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}