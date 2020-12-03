using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.IRepositories;

namespace WebsiteLaptop.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
