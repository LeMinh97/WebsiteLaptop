using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Infrastructure.Interfaces;

namespace WebsiteLaptop.Data.IRepositories
{
    public interface IContactRepository : IRepository<Contact, string>
    {
    }
}
