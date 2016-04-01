using AG.Store.Model;
using AG.Store.WebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AG.Store.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private const int PageSize = 4;

        // GET: Product
        public ViewResult List(string category, int page = 1)
        {
            IEnumerable<Product> products = CreateDefaultProductList();

            PageInfo pageInfo = new PageInfo(page, PageSize, category == null ? products.Count() : products.Where(p => p.Category == category).Count());

            var model = new ProductsListViewModel(category, pageInfo, products.Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));

            return View(model);
        }

        #region Test Data

        private List<Product> CreateDefaultProductList()
        {
            var list = new List<Product>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product{i}",
                    Category = "Product",
                    Price = 100 * i,
                    Description = $"Description of product{i}"
                });
            }
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Product
                {
                    ProductId = i,
                    Name = $"Game{i}",
                    Category = "Game",
                    Price = 100 * i,
                    Description = $"Description of Game{i}"
                });
            }

            return list;
        }

        #endregion Test Data
    }
}