using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Service.ViewModels.System;

namespace WebsiteLaptop.Service.AotoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
        }
    }
}
