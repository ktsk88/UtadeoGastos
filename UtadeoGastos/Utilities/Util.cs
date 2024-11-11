using Microsoft.EntityFrameworkCore;

using UtadeoGastos.Dtos;

namespace UtadeoGastos.Utilities
{
    public static class Util
    {
        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(
        this IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedResult<T>(items, count, pageIndex, pageSize);
        }
    }
}
