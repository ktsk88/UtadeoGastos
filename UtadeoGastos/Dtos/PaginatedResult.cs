namespace UtadeoGastos.Dtos
{
    /// <summary>Pagination searching</summary>
    /// <typeparam name="T">Type of result.</typeparam>
    public class PaginatedResult<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }

        public PaginatedResult(List<T> items, int count, int currentPage, int pageSize)
        {
            Items = items;
            TotalCount = count;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public PaginatedResult()
        {
            Items = new List<T>();
        }
    }
}
