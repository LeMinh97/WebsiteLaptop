using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.IRepositories;
using WebsiteLaptop.Infrastructure.Interfaces;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Utilities.Dtos;

namespace WebsiteLaptop.Service.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        IProductQuantityRepository _productQuantityRepository;
        IProductImageRepository _productImageRepository;
        IWholePriceRepository _wholePriceRepository;
        private readonly IMapper _mapper;
        IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IMapper mapper,
            IProductQuantityRepository productQuantityRepository, IUnitOfWork unitOfWork,
            IWholePriceRepository wholePriceRepository,
            IProductImageRepository productImageRepository)
        {
            _productRepository = productRepository;
            _productQuantityRepository = productQuantityRepository;
            _productImageRepository = productImageRepository;
            _wholePriceRepository = wholePriceRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.ProductCategory)).ToList();
        }

        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize, string sortBy="latest")
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));
            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);

            int totalRow = query.Count();

            if (sortBy == null)
            {
                query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }
            else if (sortBy.Contains("oldest"))
            {
                query = query.OrderBy(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }else if (sortBy.Contains("price-asc"))
            {
                query = query.OrderBy(x => x.Price)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }
            else if (sortBy.Contains("price-desc"))
            {
                query = query.OrderByDescending(x => x.Price)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }
            else if (sortBy.Contains("name-asc"))
            {
                query = query.OrderBy(x => x.Name)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }
            else if (sortBy.Contains("name-desc"))
            {
                query = query.OrderByDescending(x => x.Name)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }
            else
            {
                query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);
            }

            var data = _mapper.ProjectTo<ProductViewModel>(query).ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public ProductViewModel Add(ProductViewModel productVm)
        {
            if (!string.IsNullOrEmpty(productVm.Name))
            {
                var product = _mapper.Map<ProductViewModel, Product>(productVm);
                _productRepository.Add(product);
            }
            return productVm;
        }

        public void Update(ProductViewModel productVm)
        {
            var product = _mapper.Map<ProductViewModel, Product>(productVm);
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void AddQuantity(int productId, List<ProductQuantityViewModel> quantities)
        {
            _productQuantityRepository.RemoveMultiple(_productQuantityRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var quantity in quantities)
            {
                _productQuantityRepository.Add(new ProductQuantity()
                {
                    ProductId = productId,
                    ProductConditionId = quantity.ProductConditionId,
                    Quantity = quantity.Quantity
                });
            }
        }

        public List<ProductQuantityViewModel> GetQuantities(int productId)
        {
            return _mapper.ProjectTo<ProductQuantityViewModel>(_productQuantityRepository.FindAll(x => x.ProductId == productId)).ToList();
        }

        public List<ProductImageViewModel> GetImages(int productId)
        {
            return _mapper.ProjectTo<ProductImageViewModel>(_productImageRepository.FindAll(x => x.ProductId == productId)).ToList();
        }

        public void AddImages(int productId, string[] images)
        {
            _productImageRepository.RemoveMultiple(_productImageRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var image in images)
            {
                _productImageRepository.Add(new ProductImage()
                {
                    Path = image,
                    ProductId = productId,
                    Caption = string.Empty
                });
            }

        }

        public void AddWholePrice(int productId, List<WholePriceViewModel> wholePrices)
        {
            _wholePriceRepository.RemoveMultiple(_wholePriceRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var wholePrice in wholePrices)
            {
                _wholePriceRepository.Add(new WholePrice()
                {
                    ProductId = productId,
                    FromQuantity = wholePrice.FromQuantity,
                    ToQuantity = wholePrice.ToQuantity,
                    Price = wholePrice.Price,
                    Description = wholePrice.Description
                });
            }
        }

        public List<WholePriceViewModel> GetWholePrices(int productId)
        {
            return _mapper.ProjectTo<WholePriceViewModel>(_wholePriceRepository.FindAll(x => x.ProductId == productId)).ToList();
        }

        public List<ProductViewModel> GetLastest(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.Status == Status.Active).OrderByDescending(x => x.DateCreated)
                .Take(top)).ToList();
        }

        public List<ProductViewModel> GetHotProduct(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.Status == Status.Active && x.HotFlag == true)
                .OrderByDescending(x => x.DateCreated).Take(top)).ToList();
        }

        public List<ProductViewModel> GetRelatedProducts(int id, int top)
        {
            var product = _productRepository.FindById(id);
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.Status == Status.Active
                && x.Id != id && x.CategoryId == product.CategoryId)
            .OrderByDescending(x => x.DateCreated)
            .Take(top))
            .ToList();
        }

        public List<ProductViewModel> GetUpsellProducts(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(_productRepository.FindAll(x => x.PromotionPrice != null)
               .OrderByDescending(x => x.DateModified)
               .Take(top)).ToList();
        }

        public bool CheckAvailability(int productId, int productCondition)
        {
            var quantity = _productQuantityRepository.FindSingle(x => x.ProductConditionId == productCondition && x.ProductId == productId);
            if (quantity == null)
                return false;
            return quantity.Quantity > 0;
        }
    }
}