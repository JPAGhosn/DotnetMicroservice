using Collections.Models.ElasticSearch;
using Elasticsearch.Net;
using Nest;

namespace Collections.Repositories.ElasticSearch;

public class CollectionElasticSearchRepository
{
    private readonly IElasticClient _elasticClient;

    public CollectionElasticSearchRepository(IElasticClient elasticClient)
    {
        _elasticClient = elasticClient;
        // CreateIndexIfNotExistsAsync().Wait();
    }

    public async Task CreateIndexIfNotExistsAsync()
    {
        var indexName = "collections";
        var existsResponse = await _elasticClient.Indices.ExistsAsync(indexName);
        if (!existsResponse.Exists)
        {
            var createIndexResponse = await _elasticClient.Indices.CreateAsync(indexName, c => c
                .Map<CollectionEksModel>(m => m
                    .AutoMap()
                )
            );

            if (!createIndexResponse.IsValid)
                throw new Exception($"Failed to create index: {createIndexResponse.ServerError.Error.Reason}");
        }
    }

    public async Task IndexCollectionAsync(CollectionEksModel collection)
    {
        var response = await _elasticClient.IndexDocumentAsync(collection);
        if (!response.IsValid) throw new Exception($"Failed to index document: {response.ServerError.Error.Reason}");
    }

    public async Task BulkIndexCollectionsAsync(IEnumerable<CollectionEksModel> articles)
    {
        var response = await _elasticClient.BulkAsync(b => b
                .IndexMany(articles)
                .Refresh(Refresh.WaitFor) // Ensures documents are searchable immediately
        );

        if (response.Errors)
        {
            foreach (var item in response.ItemsWithErrors)
                // Log individual errors
                Console.WriteLine($"Failed to index document {item.Id}: {item.Error.Reason}");

            throw new Exception("Bulk indexing encountered errors.");
        }
    }

    public async Task<ISearchResponse<CollectionEksModel>> SearchCollectionsAsync(string keyword)
    {
        var response = await _elasticClient.SearchAsync<CollectionEksModel>(s => s
            .Query(q => q
                .Match(m => m
                    .Field(f => f.Name)
                    .Query(keyword)
                )
            )
        );

        if (!response.IsValid) throw new Exception($"Search failed: {response.ServerError.Error.Reason}");

        return response;
    }

    public async Task<ISearchResponse<CollectionEksModel>> AdvancedSearchAsync(string search, Guid creatorId, int page,
        int pageSize)
    {
        var response = await _elasticClient.SearchAsync<CollectionEksModel>(s => s
            .From((page - 1) * pageSize)
            .Size(pageSize)
            .Query(q => q
                .Bool(b => b
                    .Must(
                        bs => bs.Match(m => m.Field(f => f.Name).Query(search))
                        // Add more
                    )
                    .Filter(
                        f => f.DateRange(r => r
                            .Field(fld => fld.Name)
                        )
                    )
                )
            )
            .Sort(so => so
                .Descending(f => f.Name)
            )
        );

        if (!response.IsValid) throw new Exception($"Advanced search failed: {response.ServerError.Error.Reason}");

        return response;
    }

    public async Task DeleteIndexAsync()
    {
        var indexName = "collections";

        try
        {
            var response = await _elasticClient.Indices.DeleteAsync("collections");

            if (response.IsValid)
            {
                Console.WriteLine("Index '{IndexName}' deleted successfully.", "collections");
            }
            else
            {
                Console.WriteLine("Failed to delete index '{IndexName}': {Reason}", indexName,
                    response.ServerError?.Error?.Reason);
                throw new Exception($"Failed to delete index '{indexName}': {response.ServerError?.Error?.Reason}");
            }
        }
        catch (ElasticsearchClientException ex)
        {
            Console.WriteLine("ElasticsearchClientException occurred while deleting index '{IndexName}'.",
                indexName);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An exception occurred while deleting index '{IndexName}'.", indexName);
            throw;
        }
    }
}