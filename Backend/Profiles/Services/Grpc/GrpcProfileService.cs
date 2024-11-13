using Grpc.Core;
using KRK_Profiles.Repositories;
using KRKProfiles;

namespace KRK_Profiles.Services.Grpc;

public class GrpcProfileService(ProfileRepository profileRepository) : Profile.ProfileBase
{
    public override async Task<GetManyProfilesResponse> GetManyProfiles(GetManyProfilesRequest request,
        ServerCallContext context)
    {
        var response = new GetManyProfilesResponse();
        var profiles = await profileRepository.GetAll();

        foreach (var profile in profiles)
        {
            var model = new GrpcProfileModel
            {
                Id = profile.Id.ToString(),
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                UserName = profile.UserName
            };

            if (profile.ProfilePicture is not null) model.ProfilePicture = profile.ProfilePicture;

            if (profile.CoverPicture is not null) model.CoverPicture = profile.CoverPicture;

            response.Profiles.Add(model);
        }

        return response;
    }
}