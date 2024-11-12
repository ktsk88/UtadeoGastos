using Ninfa.Common.TransferObjects;

namespace Ninfa.Common
{
    public static class Utilities
    {
        /// <summary>Used to database pagination.</summary>
        /// <typeparam name="T">Type result</typeparam>
        /// <param name="source">Origin.</param>
        /// <param name="pageIndex">Actually page.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>object of <see cref="PaginatedResult"/></returns>
        public static Task<PaginatedResult<T>> ToPaginatedList<T>(
        this IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Task.FromResult(new PaginatedResult<T>(items, count, pageIndex, pageSize));
        }
    }
}
