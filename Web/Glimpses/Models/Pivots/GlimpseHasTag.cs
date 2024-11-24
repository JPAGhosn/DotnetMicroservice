namespace Glimpses.Models.Pivots;

public class GlimpseHasTag
{
    public Guid GlimpseId { get; set; }
    public GlimpseModel Glimpse { get; set; }

    public Guid TagId { get; set; }
    public TagModel Tag { get; set; }
}