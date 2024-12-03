using Nest;

namespace Collections.Models.ElasticSearch;

[ElasticsearchType(Name = "collections")]
public class CollectionEksModel
{
    [Text(Name = "id")] public string Id { get; set; }

    [Text(Name = "name")] public string Name { get; set; }
}