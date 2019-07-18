namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageZize = 10;
        public int PageSize
        {
            get { return pageZize; }
            set { pageZize = (value > MaxPageSize) ? MaxPageSize : value; }
        }        
    }
}