﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteLaptop.Service.ViewModels.Product;

namespace WebsiteLaptop.Application.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public ProductConditionViewModel ProductCondition { get; set; }
    }
}
