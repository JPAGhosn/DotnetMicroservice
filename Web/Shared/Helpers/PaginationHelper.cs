using KRK_Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace KRK_Shared.Helpers;

public static class PaginationHelper
{
    public static async Task<PaginationResponse<T>> Pagination<T>(IQueryable<T> query, int pageNumber, int pageSize,
        CancellationToken cancellationToken)
    {
        var totalItems = await query.CountAsync(cancellationToken);
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var data = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return new PaginationResponse<T>
        {
            Data = data,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages
        };
    }
}