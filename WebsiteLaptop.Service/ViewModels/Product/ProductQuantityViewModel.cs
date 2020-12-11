using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteLaptop.Service.ViewModels.Product
{
    public class ProductQuantityViewModel
    {
        public int ProductId { get; set; }

        public int ProductConditionId { get; set; }

        public int Quantity { get; set; }

        public ProductViewModel Product { get; set; }

        public ProductConditionViewModel ProductCondition { get; set; }

    }
}
