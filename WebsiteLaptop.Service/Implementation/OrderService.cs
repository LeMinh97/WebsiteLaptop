using AutoMapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.IRepositories;
using WebsiteLaptop.Infrastructure.Interfaces;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.Order;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Utilities.Dtos;

namespace WebsiteLaptop.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IProductConditionRepository _productConditionRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository,
            IOrderDetailRepository orderDetailRepository,
            IProductConditionRepository productConditionRepository,
            IProductRepository productRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _productConditionRepository = productConditionRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(OrderViewModel orderVm)
        {
            var order = _mapper.Map<OrderViewModel, Order>(orderVm);
            var orderDetails = _mapper.Map<List<OrderDetailViewModel>, List<OrderDetail>>(orderVm.OrderDetails);
            foreach (var detail in orderDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
            }
            order.OrderDetails = orderDetails;
            _orderRepository.Add(order);
        }

        public void Update(OrderViewModel orderVm)
        {
            //Mapping to order domain
            var order = _mapper.Map<OrderViewModel, Order>(orderVm);

            //Get order Detail
            var newDetails = order.OrderDetails;

            //new details added
            var addedDetails = newDetails.Where(x => x.Id == 0).ToList();

            //get updated details
            var updatedDetails = newDetails.Where(x => x.Id != 0).ToList();

            //Existed details
            var existedDetails = _orderDetailRepository.FindAll(x => x.OrderId == orderVm.Id);

            //Clear db
            order.OrderDetails.Clear();

            foreach (var detail in updatedDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
                _orderDetailRepository.Update(detail);
            }

            foreach (var detail in addedDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
                _orderDetailRepository.Add(detail);
            }

            _orderDetailRepository.RemoveMultiple(existedDetails.Except(updatedDetails).ToList());

            _orderRepository.Update(order);
        }

        public void UpdateStatus(int orderId, OrderStatus status)
        {
            var order = _orderRepository.FindById(orderId);
            order.OrderStatus = status;
            _orderRepository.Update(order);
        }

        public List<ProductConditionViewModel> GetProductCondition()
        {
            return _mapper.ProjectTo<ProductConditionViewModel>(_productConditionRepository.FindAll()).ToList();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public PagedResult<OrderViewModel> GetAllPaging(string startDate, string endDate, string keyword
            , int pageIndex, int pageSize)
        {
            var query = _orderRepository.FindAll();
            if (!string.IsNullOrEmpty(startDate))
            {
                DateTime start = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
                query = query.Where(x => x.DateCreated >= start);
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                DateTime end = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
                query = query.Where(x => x.DateCreated <= end);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.CustomerName.Contains(keyword) || x.CustomerMobile.Contains(keyword));
            }
            var totalRow = query.Count();
            var data = _mapper.ProjectTo<OrderViewModel>(query.OrderByDescending(x => x.DateCreated)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize))
                .ToList();
            return new PagedResult<OrderViewModel>()
            {
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Results = data,
                RowCount = totalRow
            };
        }

        public OrderViewModel GetDetail(int orderId)
        {
            var order = _orderRepository.FindSingle(x => x.Id == orderId);
            var orderVm = _mapper.Map<Order, OrderViewModel>(order);
            var orderDetailVm = _mapper.ProjectTo<OrderDetailViewModel>(_orderDetailRepository.FindAll(x => x.OrderId == orderId)).ToList();
            orderVm.OrderDetails = orderDetailVm;
            return orderVm;
        }

        public List<OrderDetailViewModel> GetOrderDetails(int orderId)
        {
            return _mapper.ProjectTo<OrderDetailViewModel>(_orderDetailRepository
                .FindAll(x => x.OrderId == orderId, c => c.Order, c => c.ProductCondition, c => c.Product)).ToList();
        }

        public OrderDetailViewModel CreateDetail(OrderDetailViewModel orderDetailVm)
        {
            var orderDetail = _mapper.Map<OrderDetailViewModel, OrderDetail>(orderDetailVm);
            _orderDetailRepository.Add(orderDetail);
            return orderDetailVm;
        }

        public void DeleteDetail(int productId, int orderId, int productConditionId)
        {
            var detail = _orderDetailRepository.FindSingle(x => x.ProductId == productId
           && x.OrderId == orderId && x.ProductConditionId == productConditionId);
            _orderDetailRepository.Remove(detail);
        }
    }
}
