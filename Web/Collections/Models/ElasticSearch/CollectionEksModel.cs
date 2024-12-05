using Nest;

namespace Collections.Models.ElasticSearch;

[ElasticsearchType(RelationName = "collections-index")]
public class CollectionEksModel
{
    [Text(Name = "id")] public Guid Id { get; set; }

    [Text(Name = "name")] public string Name { get; set; }

    [Text(Name = "creatorId")] public Guid CreatorId { get; set; }
}