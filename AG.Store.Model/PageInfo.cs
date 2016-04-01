using System;

namespace AG.Store.Model
{
    public class PageInfo
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }

        public PageInfo(int currentPage, int itemsPerPage, int totalItems)
        {
            CurrentPage = currentPage;
            ItemsPerPage = itemsPerPage;
            TotalItems = totalItems;
        }

        public int GetTotalPages()
        {
            return (int)Math.Ceiling((decimal)(TotalItems / ItemsPerPage));
        }
    }
}