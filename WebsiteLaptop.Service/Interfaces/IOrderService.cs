using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Service.ViewModels.Order;
using WebsiteLaptop.Service.ViewModels.Product;
using WebsiteLaptop.Utilities.Dtos;

namespace WebsiteLaptop.Service.Interfaces
{
    public interface IOrderService
    {
        void Create(OrderViewModel orderVm);
        void Update(OrderViewModel orderVm);

        PagedResult<OrderViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        OrderViewModel GetDetail(int orderId);

        OrderDetailViewModel CreateDetail(OrderDetailViewModel orderDetailVm);

        void DeleteDetail(int productId, int orderId, int productConditionId);

        void UpdateStatus(int orderId, OrderStatus status);

        List<OrderDetailViewModel> GetOrderDetails(int orderId);

        List<ProductConditionViewModel> GetProductConditions();

        void Save();
    }
}
