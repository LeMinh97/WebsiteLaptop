using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.IRepositories;
using WebsiteLaptop.Infrastructure.Interfaces;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.Product;

namespace WebsiteLaptop.Service.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryVm)
        {
            var productCategory = _mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryVm);
            _productCategoryRepository.Add(productCategory);
            return productCategoryVm;
        }

        public void Delete(int id)
        {
            _productCategoryRepository.Remove(id);
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            return _mapper.ProjectTo<ProductCategoryViewModel>(_productCategoryRepository.FindAll().OrderBy(x => x.ParentId)).ToList();
        }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _mapper.ProjectTo<ProductCategoryViewModel>(_productCategoryRepository.FindAll(x => x.Name.Contains(keyword)
                || x.Description.Contains(keyword))
                    .OrderBy(x => x.ParentId)).ToList();

            else
                return _mapper.ProjectTo<ProductCategoryViewModel>(_productCategoryRepository.FindAll().OrderBy(x => x.ParentId))
                    .ToList();
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            return _mapper.ProjectTo<ProductCategoryViewModel>(_productCategoryRepository.FindAll(x => x.Status == Status.Active
            && x.ParentId == parentId))
             .ToList();
        }

        public ProductCategoryViewModel GetById(int id)
        {
            return _mapper.Map<ProductCategory, ProductCategoryViewModel>(_productCategoryRepository.FindById(id));
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            var query = _mapper.ProjectTo<ProductCategoryViewModel>(_productCategoryRepository
                .FindAll(x => x.HomeFlag == true, c => c.Products)
                  .OrderBy(x => x.HomeOrder)
                  .Take(top));

            var categories = query.ToList();
            foreach (var category in categories)
            {
                //category.Products = _productRepository
                //    .FindAll(x => x.HotFlag == true && x.CategoryId == category.Id)
                //    .OrderByDescending(x => x.DateCreated)
                //    .Take(5)
                //    .ProjectTo<ProductViewModel>().ToList();
            }
            return categories;
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategoryViewModel productCategoryVm)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}
