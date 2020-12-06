using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Service.ViewModels.Common;
using WebsiteLaptop.Service.ViewModels.Order;
using WebsiteLaptop.Utilities.Extensions;

namespace WebsiteLaptop.Application.Models
{
    public class CheckoutViewModel : OrderViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
