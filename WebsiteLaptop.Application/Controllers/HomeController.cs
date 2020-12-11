using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebsiteLaptop.Application.Extensions;
using WebsiteLaptop.Application.Models;
using WebsiteLaptop.Service.Interfaces;

namespace WebsiteLaptop.Application.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;
        private IConfiguration _configuration;
        private ICommonService _commonService;

        public HomeController(IProductService productService, ICommonService commonService, IConfiguration configuration,
       IProductCategoryService productCategoryService)
        {
            _commonService = commonService;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _configuration = configuration;
        }

        public IActionResult Index(int? pageSize, string sortBy = "latest", int page = 1)
        {
            ViewData["BodyClass"] = "cms-index-index cms-home-page";
            var homeVm = new HomeViewModel();
            homeVm.HomeCategories = _productCategoryService.GetHomeCategories(5);
            homeVm.HotProducts = _productService.GetHotProduct(5);
            homeVm.TopSellProducts = _productService.GetLastest(5);
            homeVm.HomeSlides = _commonService.GetSlides("top");
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            homeVm.PageSize = pageSize;
            homeVm.SortType = sortBy;
            homeVm.Data = _productService.GetAllPaging(null, string.Empty, page, pageSize.Value, sortBy);
            return View(homeVm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Trang mô tả ứng dụng của bạn.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Trang liên hệ của bạn.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
