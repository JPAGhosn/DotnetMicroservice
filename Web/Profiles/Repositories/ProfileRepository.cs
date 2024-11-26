using KRK_Profiles.Models;
using Microsoft.EntityFrameworkCore;
using Profiles.Data;

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

    public async Task<ProfileModel?> GetById(Guid id, CancellationToken cancellationToken = default)
    {
        return await context.Profiles.FirstOrDefaultAsync(profile => profile.Id == id, cancellationToken);
    }
}