namespace KRK_Shared.Models;

public class PaginationResponse<T>
{
    public List<T> Data { get; set; } = [];
    public int PageNumber { get; set; } = default!;
    public int PageSize { get; set; } = default!;
    public long TotalPages { get; set; } = default!;
}