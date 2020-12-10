using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Utilities.Dtos;

namespace WebsiteLaptop.Application.Models.ProductViewModels
{
    public class CatalogViewModel
    {
        public PagedResult<ProductViewModel> Data { get; set; }

        public ProductCategoryViewModel Category { set; get; }

        public string SortType { set; get; }

        public int? PageSize { set; get; }

        public List<SelectListItem> SortTypes { get; } = new List<SelectListItem>
        {
            new SelectListItem(){Value = "latest",Text = "Mới nhất"},
            new SelectListItem(){Value = "oldest",Text = "Cũ nhất"},
            new SelectListItem(){Value = "price-asc",Text = "Giá tăng"},
            new SelectListItem(){Value = "price-desc",Text = "Giá giảm"},
            new SelectListItem(){Value = "name-asc",Text = "Tên tăng"},
            new SelectListItem(){Value = "name-desc",Text = "Tên giảm"},
        };

        public List<SelectListItem> PageSizes { get; } = new List<SelectListItem>
        {
            new SelectListItem(){Value = "12",Text = "12"},
            new SelectListItem(){Value = "24",Text = "24"},
            new SelectListItem(){Value = "48",Text = "48"},
        };
    }
}
