using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebsiteLaptop.Data.Enums;

namespace WebsiteLaptop.Service.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public OrderStatus OrderStatus { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; } = Status.Active;

        public Guid? CustomerId { set; get; }

        public List<OrderDetailViewModel> OrderDetails { set; get; }
        //public List<BillViewModel> Bills { set; get; }
        //public List<DeliveryViewModel> Deliveries { set; get; }
    }
}
