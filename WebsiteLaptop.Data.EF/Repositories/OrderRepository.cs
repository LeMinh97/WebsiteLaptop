using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.IRepositories;

namespace WebsiteLaptop.Data.EF.Repositories
{
    public class OrderRepository : EFRepository<Order, int>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
