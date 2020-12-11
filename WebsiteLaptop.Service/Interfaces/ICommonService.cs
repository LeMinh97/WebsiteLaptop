using System;
using System.Collections.Generic;
using System.Text;
using WebsiteLaptop.Service.ViewModels.Common;

namespace WebsiteLaptop.Service.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
    }
}
