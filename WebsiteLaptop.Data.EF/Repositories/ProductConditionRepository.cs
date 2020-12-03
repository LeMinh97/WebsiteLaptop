using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.IRepositories;

namespace WebsiteLaptop.Data.EF.Repositories
{
    public class ProductConditionRepository : EFRepository<ProductCondition, int>, IProductConditionRepository
    {
        public ProductConditionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
