using Grpc.Core;
using KRK_Profiles.Bindings;
using KRK_Profiles.Repositories;
using KRKProfiles;

namespace KRK_Profiles.Services.Grpc;

public class GrpcProfileService(ProfileRepository profileRepository, PicturesBasePathBindings basePathBindings)
    : Profile.ProfileBase
{
    public override async Task<GetOneResponse?> GetOne(GetOneRequest request, ServerCallContext context)
    {
        var response = new GetOneResponse();
        var id = Guid.Parse(request.Id);
        var profile = await profileRepository.GetById(id);

        if (profile == null)
        {
            response.Profile = null;
            return response;
        }

        if (profile.ProfilePicture is not null)
            profile.ProfilePicture =
                basePathBindings.SeaweedFS + "/" + basePathBindings.Profiles + "/" + profile.ProfilePicture;

        if (profile.CoverPicture is not null)
            profile.CoverPicture =
                basePathBindings.SeaweedFS + "/" + basePathBindings.Covers + "/" + profile.CoverPicture;

        var model = new GrpcProfileModel
        {
            Id = profile.Id.ToString(),
            FirstName = profile.FirstName,
            LastName = profile.LastName,
            UserName = profile.UserName,
            CoverPicture = profile.CoverPicture,
            ProfilePicture = profile.ProfilePicture
        };

        response.Profile = model;

        return response;
    }

    public override async Task<GetManyProfilesResponse> GetManyProfiles(GetManyProfilesRequest request,
        ServerCallContext context)
    {
        var response = new GetManyProfilesResponse();
        var ids = request.Ids.Select(Guid.Parse).ToList();
        var profiles = await profileRepository.GetAllWithIds(ids);

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