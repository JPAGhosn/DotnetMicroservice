using KRK_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KRK_Auth.ModelsConfiguration;

public class UserModelConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.FirstName);

        builder.Property(m => m.LastName);

        builder.Property(m => m.Email);

        builder.Property(m => m.PhoneNumber);
    }
}