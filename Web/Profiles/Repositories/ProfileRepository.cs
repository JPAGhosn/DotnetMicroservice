using KRK_Profiles.Data;
using KRK_Profiles.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Profiles.Repositories;

public class ProfileRepository(ProfilesDbContext context)
{
    public async Task<List<ProfileModel>> GetAll()
    {
        return await context.Profiles.ToListAsync();
    }

    public async Task<List<ProfileModel>> GetAllWithIds(List<Guid> ids)
    {
        return await context.Profiles.Where(profile => ids.Contains(profile.Id)).ToListAsync();
    }
}