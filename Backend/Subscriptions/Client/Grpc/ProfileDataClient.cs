using Grpc.Net.Client;
using KRK_Subscriptions.Models;
using KRKProfiles;

namespace KRK_Subscriptions.Client.Grpc;

public class ProfileDataClient
{
    public async Task<List<ProfileModel>> GetManyProfiles(List<Guid> profilesIds)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:5200");
        var client = new Profile.ProfileClient(channel);
        var request = new GetManyProfilesRequest();
        foreach (var profileId in profilesIds) request.Ids.Add(profileId.ToString());
        try
        {
            var response = await client.GetManyProfilesAsync(request);
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