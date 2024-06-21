namespace University.Business.Wrappers;

public class Pagination<T>
{
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public IList<T> Items { get; set; } = [];

        public Pagination(int pageNumber, int pageSize, IList<T> items)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            Items = items;
        }


}
