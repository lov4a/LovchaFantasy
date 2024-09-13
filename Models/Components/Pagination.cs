namespace LovchaFantasy.Models.Components
{
    public class Pagination
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }

        public void setTotalPages(int count, int pageSize)
        {
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
        public void setPage(int page)
        {
            Page = page;
        }
        public bool HasPreviousPage
        {
            get
            {
                return (Page > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (Page < TotalPages);
            }
        }
        public void Prev()
        {
            if (HasPreviousPage) {
                Page--;
            }
        }
        public void Next()
        {
            if (HasNextPage)
            {
                Page++;
            }
        }
    }
}
