using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KRK_Shared.Models;

namespace Collections.Models;

public class CollectionModel : BaseModel
{
    [Required] public string Name { get; set; }

    public string? CoverPath1 { get; set; }
    public string? CoverPath2 { get; set; }
    public string? CoverPath3 { get; set; }

    [Required] public Guid CreatorId { get; set; }

    [NotMapped] public ProfileModel? Creator { get; set; }

    [Required] public int NumberOfFollowers { get; set; }

    [Required] public DateTime PublishedDate { get; set; }
}