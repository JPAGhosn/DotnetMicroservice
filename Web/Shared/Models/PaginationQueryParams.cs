namespace KRK_Shared.Models;

public class PaginationQueryParams
{
    public int? PageNumber { get; set; }

    public int? PageSize { get; set; }

    public string? Search { get; set; }
}