#pragma checksum "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de6edf1f2306de27c441c9213dfcdc2191a1505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
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
#line 1 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Service.ViewModels.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de6edf1f2306de27c441c9213dfcdc2191a1505", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"navleft-container\">\r\n    <div class=\"mega-menu-title\">\r\n        <h3><span>All Categories</span></h3>\r\n    </div>\r\n\r\n    <!-- Shop by category -->\r\n    <div class=\"mega-menu-category\">\r\n        <ul class=\"nav\">\r\n");
#nullable restore
#line 10 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
             foreach (var item in Model.Where(x => x.ParentId == null))
            {
                if (Model.Any(x => x.ParentId == item.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 481, "\"", 518, 5);
            WriteAttributeValue("", 488, "/", 488, 1, true);
#nullable restore
#line 15 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 489, item.Alias, 489, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 500, "-c.", 500, 3, true);
#nullable restore
#line 15 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 503, item.Id, 503, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 513, ".html", 513, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <div class=\"wrap-popup column1\">\r\n                            <div class=\"popup\">\r\n                                <ul class=\"nav\">\r\n");
#nullable restore
#line 19 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                     foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 881, "\"", 924, 5);
            WriteAttributeValue("", 888, "/", 888, 1, true);
#nullable restore
#line 21 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 889, subItem.Alias, 889, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 903, "-c.", 903, 3, true);
#nullable restore
#line 21 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 906, subItem.Id, 906, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 919, ".html", 919, 5, true);
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 21 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                            Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 22 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 27 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nosub\"><a");
            BeginWriteAttribute("href", " href=\"", 1238, "\"", 1275, 5);
            WriteAttributeValue("", 1245, "/", 1245, 1, true);
#nullable restore
#line 31 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1246, item.Alias, 1246, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1257, "-c.", 1257, 3, true);
#nullable restore
#line 31 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 1260, item.Id, 1260, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1270, ".html", 1270, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\CategoryMenu\Default.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
