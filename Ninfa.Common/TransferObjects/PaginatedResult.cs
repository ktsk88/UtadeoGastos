namespace Ninfa.Common.TransferObjects
{
    public class PaginatedResult<T>
    {
        /// <summary>Current page.</summary>
        public int CurrentPage { get; set; }
        /// <summary>Total pages.</summary>
        public int TotalPages { get; set; }
        /// <summary>Page size.</summary>
        public int PageSize { get; set; }
        /// <summary>Total records.</summary>
        public int TotalCount { get; set; }
        /// <summary>Items of the result.</summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>Ctor</summary>
        /// <param name="items">Items of the result.</param>
        /// <param name="count">Total records.</param>
        /// <param name="currentPage">Current page.</param>
        /// <param name="pageSize">Page size.</param>
        public PaginatedResult(List<T> items, int count, int currentPage, int pageSize)
        {
            Items = items;
            TotalCount = count;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        /// <summary>Default ctor.</summary>
        public PaginatedResult()
        {
            Items = new List<T>();
        }
    }
}
