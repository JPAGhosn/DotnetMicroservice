using Glimpses.Models;
using Glimpses.Models.Pivots;
using KRK_Shared.Models;

namespace Glimpses.Dtos;

public class GlimpseViewDto
{
    public GlimpseViewDto(GlimpseModel glimpse)
    {
        Id = glimpse.Id;
        Name = glimpse.Name;
        NumberOfViews = glimpse.NumberOfViews;
        PublishedDate = glimpse.PublishedDate;
        Creator = glimpse.Creator;
        VideoPath = glimpse.VideoPath;
        ThumbnailPath = glimpse.ThumbnailPath;
    }

    public Guid Id { get; set; }

    public string Name { get; set; } = default!;

    public int NumberOfViews { get; set; }

    public DateTime PublishedDate { get; set; } = DateTime.Now.ToUniversalTime();

    public Guid CreatorId { get; set; }

    public ProfileModel Creator { get; set; }

    public string VideoPath { get; set; }

    public string ThumbnailPath { get; set; }

    public List<TagModel> Tags { get; set; }
    public List<GlimpseHasTag> GlimpseHasTag { get; set; }
}