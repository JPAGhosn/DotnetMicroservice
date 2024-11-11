using KRK_Profiles.Models;
using KRK_Profiles.Seeders;
using Microsoft.EntityFrameworkCore;

namespace KRK_Profiles.Data;

public class ProfilesDbContext : DbContext
{
    public ProfilesDbContext(DbContextOptions<ProfilesDbContext> options) : base(options)
    {
    }

    public DbSet<ProfileModel> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        base.OnModelCreating(modelBuilder);
    }
}