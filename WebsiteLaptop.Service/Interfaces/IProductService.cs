using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Service.ViewModels.Product;

namespace WebsiteLaptop.Service.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}
