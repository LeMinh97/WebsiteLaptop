using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("ProductQuantities")]
    public class ProductQuantity : DomainEntity<int>
    {

        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Column(Order = 2)]
        public int ProductConditionId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("ProductConditionId")]
        public virtual ProductCondition ProductCondition { get; set; }
    }
}
