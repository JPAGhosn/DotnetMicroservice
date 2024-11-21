namespace Glimpses.Models;

public class GlimpseModel
{
    public Guid Id { get; set; }

    public Guid CreatorId { get; set; }

    public string VideoPath { get; set; }
}