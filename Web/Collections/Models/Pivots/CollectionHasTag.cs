namespace Collections.Models.Pivots;

public class CollectionHasTag
{
    public Guid CollectionId { get; set; }
    public CollectionModel Collection { get; set; }

    public Guid TagId { get; set; }
    public TagModel Tag { get; set; }
}