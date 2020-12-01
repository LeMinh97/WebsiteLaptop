using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteLaptop.Data.IRepositories;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.Product;

namespace WebsiteLaptop.Service.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.ProductCategory)).ToList();
        }
    }
}