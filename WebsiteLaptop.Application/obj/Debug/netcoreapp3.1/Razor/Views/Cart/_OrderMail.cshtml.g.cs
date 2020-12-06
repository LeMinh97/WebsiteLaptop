#pragma checksum "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3c151a3e429e627a61ce897c38fa5e474fbbaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart__OrderMail), @"mvc.1.0.view", @"/Views/Cart/_OrderMail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c151a3e429e627a61ce897c38fa5e474fbbaa", @"/Views/Cart/_OrderMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart__OrderMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteLaptop.Service.ViewModels.Order.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Panda Shop new order</h1>\r\n<table>\r\n    <tr>\r\n        <td>Customer Name</td>\r\n        <td>");
#nullable restore
#line 6 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
       Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Address</td>\r\n        <td>");
#nullable restore
#line 10 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Phone</td>\r\n        <td>");
#nullable restore
#line 14 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
       Write(Model.CustomerMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Date</td>\r\n        <td>");
#nullable restore
#line 18 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
       Write(Model.DateCreated.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <tr>
        <td>Details</td>
        <td>
            <table>
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Quantity</th>
                        <th>Price</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 33 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                     foreach (var item in Model.OrderDetails)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                            Write((item.Quantity * item.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            Total: ");
#nullable restore
#line 46 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\_OrderMail.cshtml"
                              Write(Model.OrderDetails.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n        </td>\r\n    </tr>\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteLaptop.Service.ViewModels.Order.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
