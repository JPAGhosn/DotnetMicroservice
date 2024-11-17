using Grpc.Core;
using KRK_Profiles.Bindings;
using KRK_Profiles.Repositories;
using KRKProfiles;

namespace KRK_Profiles.Services.Grpc;

public class GrpcProfileService(ProfileRepository profileRepository, PicturesBasePathBindings basePathBindings)
    : Profile.ProfileBase
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

            if (profile.ProfilePicture is not null)
                model.ProfilePicture =
                    basePathBindings.SeaweedFS + "/" + basePathBindings.Profiles + "/" + profile.ProfilePicture;

            if (profile.CoverPicture is not null)
                model.CoverPicture =
                    basePathBindings.SeaweedFS + "/" + basePathBindings.Covers + "/" + profile.CoverPicture;

            response.Profiles.Add(model);
        }

        return response;
    }
}