using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.Interfaces;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("Orders")]
    public class Order : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Order() { }

        public Order(string customerName, string customerAddress, string customerMobile, string customerMessage,
            OrderStatus orderStatus, PaymentMethod paymentMethod, Status status, Guid customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            OrderStatus = orderStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        public Order(int id, string customerName, string customerAddress, string customerMobile, string customerMessage,
           OrderStatus orderStatus, PaymentMethod paymentMethod, Status status, Guid customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            OrderStatus = orderStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }
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

        [DefaultValue(Status.Active)]
        public Status Status { set; get; } = Status.Active;

        public Guid CustomerId { set; get; }

        [ForeignKey("CustomerId")]
        public virtual AppUser User { set; get; }

        public virtual ICollection<OrderDetail> OrderDetails { set; get; }
        public virtual ICollection<Bill> Bills { set; get; }
        public virtual ICollection<Delivery> Deliveries { set; get; }
    }
}
