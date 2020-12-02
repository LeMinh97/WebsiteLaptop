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
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking
    {
        private Status status;

        public Product()
        {}

        public Product(string name, int categoryId, string image, decimal price, decimal originalPrice, decimal? promotionPrice, string description, string content, bool? homeFlag, bool? hotFlag, string tags, string unit, Status status)
        {
            Name = name;
            CategoryId = categoryId;
            Image = image;
            Price = price;
            OriginalPrice = originalPrice;
            PromotionPrice = promotionPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Tags = tags;
            Unit = unit;
            Status = status;
        }

        public Product(int id, string name, int categoryId, string image, decimal price, decimal originalPrice, decimal? promotionPrice, string description, string content, bool? homeFlag, bool? hotFlag, string tags, string unit, Status status)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Image = image;
            Price = price;
            OriginalPrice = originalPrice;
            PromotionPrice = promotionPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Tags = tags;
            Unit = unit;
            Status = status;
        }

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

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
    }
}
