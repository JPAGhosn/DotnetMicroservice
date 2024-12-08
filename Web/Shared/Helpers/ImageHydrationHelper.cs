using Shared.Bindings;

namespace KRK_Shared.Helpers;

public class ImageHydrationHelper(PicturesBasePath picturesBasePath)
{
    public string? HydrateImage(string basePath, string? imageUrl)
    {
        if (string.IsNullOrEmpty(imageUrl)) return null;

        return Path.Combine(picturesBasePath.SeaweedFS, basePath, imageUrl);
    }
}