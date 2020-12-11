using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Service.ViewModels.Product;

namespace WebsiteLaptop.Service.ViewModels.Order
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }

        public int OrderId { set; get; }

        public int ProductId { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public int ProductConditionId { get; set; }

        public OrderViewModel Order { set; get; }

        public ProductViewModel Product { set; get; }

        public ProductConditionViewModel ProductCondition { get; set; }
    }
}
