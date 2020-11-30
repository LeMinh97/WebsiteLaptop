using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebsiteLaptop.Service.ViewModels.System;

namespace WebsiteLaptop.Service.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}
