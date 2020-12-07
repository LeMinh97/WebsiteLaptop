#pragma checksum "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85070e20e5cce212a6eb96847bdece912c1521eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
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
#line 1 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\_ViewImports.cshtml"
using WebsiteLaptop.Service.ViewModels.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85070e20e5cce212a6eb96847bdece912c1521eb", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShoppingCartViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"mini-cart\" id=\"headerCart\">\r\n    <div data-toggle=\"dropdown\" data-hover=\"dropdown\" class=\"basket dropdown-toggle\">\r\n        <a href=\"#\">\r\n            <div class=\"cart-icon\">\r\n                <i class=\"icon-basket-loaded icons\"></i>\r\n");
#nullable restore
#line 7 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                 if (Model.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"cart-total\">");
#nullable restore
#line 9 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 10 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"shoppingcart-inner hidden-xs\"><span class=\"cart-title\">My Cart</span> </div>\r\n        </a>\r\n    </div>\r\n    <div>\r\n        <div class=\"top-cart-content\">\r\n");
#nullable restore
#line 17 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"block-subtitle hidden\">Recently added items</div>\r\n                <ul id=\"cart-sidebar\" class=\"mini-products-list\">\r\n");
#nullable restore
#line 21 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                     foreach (var item in Model)
                    {
                        var url = "/" + item.Product.Alias + "-p." + item.Product.Id + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"item last odd\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1084, 1);
#nullable restore
#line 26 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1080, url, 1080, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1085, "\"", 1111, 1);
#nullable restore
#line 26 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1093, item.Product.Name, 1093, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1173, "\"", 1198, 1);
#nullable restore
#line 27 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1179, item.Product.Image, 1179, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1199, "\"", 1223, 1);
#nullable restore
#line 27 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1205, item.Product.Name, 1205, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"65\">\r\n                            </a>\r\n                            <div class=\"product-details\">\r\n                                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 1374, "\"", 1400, 1);
#nullable restore
#line 30 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1382, item.Product.Name, 1382, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 30 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                           Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"remove-cart\"><i class=\"pe-7s-trash\"></i></a>\r\n                                <p class=\"product-name\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1578, "\"", 1589, 1);
#nullable restore
#line 32 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1585, url, 1585, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                              Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </p>\r\n                                <strong>");
#nullable restore
#line 34 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> x <span class=\"price\">");
#nullable restore
#line 34 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                                  Write((item.Product.PromotionPrice ?? item.Product.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 37 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <div class=\"top-subtotal\">Subtotal: <span class=\"price\">");
#nullable restore
#line 39 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                   Write(Model.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                <div class=""actions"">
                    <button class=""btn-checkout"" type=""button"" onClick=""location.href='/checkout.html'""><i class=""fa fa-check""></i><span>Checkout</span></button>
                    <button class=""view-cart"" type=""button"" onClick=""location.href='/cart.html'""><i class=""fa fa-shopping-cart""></i><span>View Cart</span></button>
                </div>
");
#nullable restore
#line 44 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>You have no product</p>\r\n");
#nullable restore
#line 49 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\HeaderCart\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShoppingCartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
