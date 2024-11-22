using Collections.Models;
using Glimpses.Bindings;
using Grpc.Net.Client;
using KRKProfiles;

namespace Collections.Clients.Grpc;

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
}