using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Application.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebsiteLaptop.Application.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IProductCategoryService _productCategoryService;
        IConfiguration _configuration;
        IOrderService _orderService;
        public ProductController(IProductService productService, IConfiguration configuration, IOrderService orderService,
        IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _configuration = configuration;
            _orderService = orderService;
        }

        [Route("categories.html")]
        public IActionResult Index()
        {
            var categories = _productCategoryService.GetAll();
            return View(categories);
        }

        [Route("{alias}-c.{id}.html")]
        public IActionResult Catalog(int id, int? pageSize, string sortBy= "latest", int page = 1)
        {
            var catalog = new CatalogViewModel();
            ViewData["BodyClass"] = "shop_grid_full_width_page";
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            //if (sortBy == null)
            //    pageSize = _configuration.GetValue<string>("SortBy");

            catalog.PageSize = pageSize;
            catalog.SortType = sortBy;
            catalog.Data = _productService.GetAllPaging(id, string.Empty, page, pageSize.Value, sortBy);
            catalog.Category = _productCategoryService.GetById(id);

            return View(catalog);
        }

        [Route("{alias}-p.{id}.html", Name = "ProductDetail")]
        public IActionResult Details(int id)
        {
            ViewData["BodyClass"] = "product-page";
            var model = new DetailViewModel();
            model.Product = _productService.GetById(id);
            model.Category = _productCategoryService.GetById(model.Product.CategoryId);
            model.RelatedProducts = _productService.GetRelatedProducts(id, 9);
            model.UpsellProducts = _productService.GetUpsellProducts(6);
            model.ProductImages = _productService.GetImages(id);
            model.ProductConditions = _orderService.GetProductConditions().Select(x => new SelectListItem()
            {
                Text = x.Condition,
                Value = x.Id.ToString()
            }).ToList();
            return View(model);
        }

        [Route("search.html")]
        public IActionResult Search(string keyword, int? pageSize, string sortBy = "latest", int page = 1)
        {
            var catalog = new SearchResultViewModel();
            ViewData["BodyClass"] = "shop_grid_full_width_page";
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            catalog.PageSize = pageSize;
            catalog.SortType = sortBy;
            catalog.Data = _productService.GetAllPaging(null, keyword, page, pageSize.Value, sortBy);
            catalog.Keyword = keyword;

            return View(catalog);
        }

        [Route("products.html")]
        public IActionResult AllProducts( int? pageSize, string sortBy = "latest", int page = 1)
        {
            var catalog = new CatalogViewModel();
            ViewData["BodyClass"] = "shop_grid_full_width_page";
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            catalog.PageSize = pageSize;
            catalog.SortType = sortBy;
            catalog.Data = _productService.GetAllPaging( null, string.Empty, page, pageSize.Value, sortBy);

            return View(catalog);
        }

    }
}
