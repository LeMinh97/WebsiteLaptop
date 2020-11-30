using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.IRepositories;

namespace WebsiteLaptop.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
