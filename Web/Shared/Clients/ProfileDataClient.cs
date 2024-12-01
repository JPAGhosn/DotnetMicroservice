using Grpc.Net.Client;
using KRK_Shared.Exceptions;
using KRKProfiles;
using Shared.Bindings;
using Shared.Models;

namespace Shared.Clients;

public class ProfileDataClient(ProfilesServiceBinding profilesServiceBinding)
{
    public async Task<List<ProfileModel>> GetManyProfiles(List<Guid> profilesIds, CancellationToken cancellationToken)
    {
        Console.WriteLine("Calling " + profilesServiceBinding.Url);
        var channel = GrpcChannel.ForAddress(profilesServiceBinding.Url);
        var client = new Profile.ProfileClient(channel);
        var request = new GetManyProfilesRequest();
        foreach (var profileId in profilesIds) request.Ids.Add(profileId.ToString());
        try
        {
            var response = await client.GetManyProfilesAsync(request, cancellationToken: cancellationToken);
            return response.Profiles.Select(profile => new ProfileModel
            {
                Id = Guid.Parse(profile.Id),
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                UserName = profile.UserName,
                ProfilePicture = profile.ProfilePicture,
                CoverPicture = profile.CoverPicture
            }).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ProfileModel> GetOne(Guid profileId, CancellationToken cancellationToken)
    {
        Console.WriteLine("Calling " + profilesServiceBinding.Url);
        var channel = GrpcChannel.ForAddress(profilesServiceBinding.Url);
        var client = new Profile.ProfileClient(channel);
        var request = new GetOneRequest
        {
            Id = profileId.ToString()
        };
        try
        {
            var response = await client.GetOneAsync(request, cancellationToken: cancellationToken);
            var profile = response.Profile;

            if (profile == null) throw new NotFoundException("Profile not found", "Profile not found");

            return new ProfileModel
            {
                Id = Guid.Parse(profile.Id),
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                UserName = profile.UserName,
                ProfilePicture = profile.ProfilePicture,
                CoverPicture = profile.CoverPicture
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}