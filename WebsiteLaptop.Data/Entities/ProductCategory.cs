using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Data.Interfaces;
using WebsiteLaptop.Infrastructure.SharedKernel;

namespace WebsiteLaptop.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
