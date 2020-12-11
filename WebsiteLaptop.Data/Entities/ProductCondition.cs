using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("ProductConditions")]
    public class ProductCondition : DomainEntity<int>
    {

        [StringLength(250)]
        public string Condition
        {
            get; set;
        }
    }
}
