using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.Interfaces;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("Deliverys")]
    public class Delivery : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Delivery() { }

        [Required]
        public int OrderId { set; get; }

        public Status Status { set; get; }

        [Required]
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public DateTime DeliveryDate { set; get; }

        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }
    }
}
