#pragma checksum "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f30a1fece7da3534ceb9e2cf42c7c7ac26a473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Service.ViewModels.System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f30a1fece7da3534ceb9e2cf42c7c7ac26a473", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283f1986a438c80f6bf194f74ef0cd006624406", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FunctionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"sidebar-menu\" class=\"main_menu_side hidden-print main_menu\">\r\n    <div class=\"menu_section\">\r\n        <h3>Functions</h3>\r\n        <ul class=\"nav side-menu\">\r\n");
#nullable restore
#line 6 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
             foreach (var item in Model.Where(x => string.IsNullOrEmpty(x.ParentId)))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <a><i");
            BeginWriteAttribute("class", " class=\"", 348, "\"", 372, 2);
            WriteAttributeValue("", 356, "fa", 356, 2, true);
#nullable restore
#line 9 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue(" ", 358, item.IconCss, 359, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 9 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-chevron-down\"></span></a>\r\n");
#nullable restore
#line 10 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                     if (Model.Any(x => x.ParentId == item.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"nav child_menu\">\r\n");
#nullable restore
#line 13 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                             foreach (var jitem in Model.Where(x => x.ParentId == item.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 756, 1);
#nullable restore
#line 15 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 746, jitem.URL, 746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                    Write(jitem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 16 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 19 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 22 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n</div> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FunctionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
