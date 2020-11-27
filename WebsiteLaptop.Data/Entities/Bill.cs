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
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill() { }

        [Required]
        public int OrderId { set; get; }

        [Required]
        public decimal TotalMoney { set; get; }
        public Status Status { set; get; }

        public Guid UserId { set; get; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        [Required]
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }
    }
}
