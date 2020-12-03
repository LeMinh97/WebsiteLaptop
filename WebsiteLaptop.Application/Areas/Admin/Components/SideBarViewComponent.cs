using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebsiteLaptop.Application.Extensions;
using WebsiteLaptop.Service.Interfaces;
using WebsiteLaptop.Service.ViewModels.System;
using WebsiteLaptop.Utilities.Constants;

namespace WebsiteLaptop.Application.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                functions = await _functionService.GetAll(string.Empty);
            }
            else
            {
                //TODO: Get by permission
                functions = new List<FunctionViewModel>();
            }
            return View(functions);
        }
    }
}
