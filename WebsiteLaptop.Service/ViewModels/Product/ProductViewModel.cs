using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebsiteLaptop.Data.Enums;

namespace WebsiteLaptop.Service.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        [Required]
        public decimal OriginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        [StringLength(255)]
        public string Unit { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Harđrive { get; set; }
        public string Screen { get; set; }
        public string GPU { get; set; }
        public string Pin { get; set; }
        public string ConnectPort { get; set; }
        public string OS { get; set; }
        public string Design { get; set; }
        public string Size { get; set; }
        public string YearLaunch { get; set; }
        public string Brand { get; set; }

        public ProductCategoryViewModel ProductCategory { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; }

        public string Alias { get; set; }
    }
}
