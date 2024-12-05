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

    public async Task DeleteAllDocumentsAsync()
    {
        var indexName = "collections-index";
        await _elasticClient.DeleteByQueryAsync<object>(d => d
            .Index(indexName)
            .Query(q => q.MatchAll())
        );
    }

    public async Task CreateIndexIfNotExistsAsync()
    {
        var indexName = "collections-index";
        var existsResponse = await _elasticClient.Indices.ExistsAsync(indexName);
        if (!existsResponse.Exists)
        {
            var createIndexResponse = await _elasticClient.Indices.CreateAsync("collections-index", c => c
                .Settings(s => s
                    .Analysis(a => a
                        .Tokenizers(t => t
                            .EdgeNGram("edge_ngram", e => e
                                .MinGram(2)
                                .MaxGram(10)
                                .TokenChars(TokenChar.Letter, TokenChar.Digit)
                            )
                        )
                        .Analyzers(an => an
                            .Custom("autocomplete", ca => ca
                                .Tokenizer("edge_ngram")
                                .Filters("lowercase")
                            )
                        )
                    )
                )
                .Map<CollectionEksModel>(m => m
                    .Properties(p => p
                        .Text(t => t
                                .Name(n => n.Name)
                                .Analyzer("autocomplete") // Use the custom analyzer
                                .SearchAnalyzer("standard") // Use standard analyzer for search
                        )
                        .Keyword(k => k
                            .Name(n => n.CreatorId)
                        )
                    )
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

    public async Task BulkIndexCollectionsAsync(IEnumerable<CollectionEksModel> collections)
    {
        var response = await _elasticClient
            .BulkAsync(b => b
                    .Index("collections-index")
                    .IndexMany(collections)
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

    public async Task<ISearchResponse<CollectionEksModel>> SearchCollectionsAsync(string search, Guid creatorId,
        CancellationToken cancellationToken)
    {
        var response = await _elasticClient.SearchAsync<CollectionEksModel>(s => s
                .Index("collections-index")
                .Query(q => q
                    .Bool(b => b
                        .Must(
                            bs => bs.Match(m => m
                                .Field(f => f.Name)
                                .Query(search)
                                .Fuzziness(Fuzziness.Auto)
                            ),
                            bs => bs.Term(t => t
                                .Field(f => f.CreatorId)
                                .Value(creatorId.ToString())
                            )
                        )
                    )
                ),
            cancellationToken
        );

        if (!response.IsValid) throw new Exception($"Search failed: {response.ServerError.Error.Reason}");

        return response;
    }

    public async Task<ISearchResponse<CollectionEksModel>> AdvancedSearchAsync(
        string search,
        Guid creatorId,
        int page,
        int pageSize,
        CancellationToken cancellationToken
    )
    {
        // Ensure page number is at least 1
        if (page < 1) page = 1;

        // Calculate the number of documents to skip
        var from = (page - 1) * pageSize;

        var response = await _elasticClient.SearchAsync<CollectionEksModel>(s => s
            .Index("collections-index") // Ensure this index name is correct
            .From(from)
            .Size(pageSize)
            .Query(q => q
                .Bool(b => b
                    .Must(
                        bs => bs.Match(m => m
                            .Field(f => f.Name)
                            .Query(search)
                            .Fuzziness(Fuzziness.Auto)
                        ),
                        bs => bs.Term(t => t
                            .Field(f => f.CreatorId)
                            .Value(creatorId)
                        )
                    )
                )
            )
        );

        // Improved error handling with more detailed information
        if (!response.IsValid)
        {
            var errorReason = response.ServerError?.Error?.Reason ?? "Unknown error";
            var errorType = response.ServerError?.Error?.Type;
            throw new Exception($"Advanced search failed: {errorReason} (Type: {errorType})");
        }

        return response;
    }


    public async Task DeleteIndexAsync()
    {
        var indexName = "collections-index";

        try
        {
            var response = await _elasticClient.Indices.DeleteAsync(indexName);

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