using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Glimpses.Models.Pivots;
using KRK_Shared.Models;

namespace Glimpses.Models;

public class GlimpseModel
{
    public Guid Id { get; set; }

    [Required] public string Name { get; set; } = default!;

    [Required] public int NumberOfViews { get; set; } = 0!;

    [Required] public DateTime PublishedDate { get; set; } = DateTime.Now.ToUniversalTime();

    [Required] public Guid CreatorId { get; set; }

    [NotMapped] public ProfileModel Creator { get; set; }

    [Required] public string VideoPath { get; set; }

    [Required] public string ThumbnailPath { get; set; }

    public List<TagModel> Tags { get; set; }
    public List<GlimpseHasTag> GlimpseHasTag { get; set; }
}