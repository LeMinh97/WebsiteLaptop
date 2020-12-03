using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebsiteLaptop.Service.ViewModels.Product
{
    public class ProductConditionViewModel
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Condition
        {
            get; set;
        }
    }
}
