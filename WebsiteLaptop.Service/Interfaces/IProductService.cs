using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Utilities.Dtos;

namespace WebsiteLaptop.Service.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}
