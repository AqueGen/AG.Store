using AG.Store.Model;
using System.Collections.Generic;

namespace AG.Store.WebUI.ViewModel
{
    public class ProductsListViewModel
    {
        public string Category { get; set; }

        public PageInfo PageInfo { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public ProductsListViewModel(string category, PageInfo pageInfo, IEnumerable<Product> products)
        {
            Category = category;
            PageInfo = pageInfo;
            Products = products;
        }
    }
}