#pragma checksum "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d192052285b44aa85d58e6f36aaa5b9655c259cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d192052285b44aa85d58e6f36aaa5b9655c259cd", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b06a8be2711fe31aa24a5f06bf14de4a35a23a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebsiteLaptop.Service.ViewModels.Product.ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "All product categories";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Product categories</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col1-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>Product categories</h2>
                    </div>

                    <div class=""product-grid-area"">
                        <ul class=""products-grid"">
");
#nullable restore
#line 32 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var url = "/" + item.Alias + "-c." + item.Id + ".html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Sale</div>
                                                <div class=""icon-new-label new-right"">New</div>
                                                <div class=""pr-img-area"">
                                                    <a");
            BeginWriteAttribute("title", " title=\"", 1837, "\"", 1855, 1);
#nullable restore
#line 42 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 1845, item.Name, 1845, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1856, "\"", 1867, 1);
#nullable restore
#line 42 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 1863, url, 1863, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\"");
            BeginWriteAttribute("src", " src=\"", 1958, "\"", 1975, 1);
#nullable restore
#line 43 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 1964, item.Image, 1964, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1976, "\"", 1992, 1);
#nullable restore
#line 43 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 1982, item.Name, 1982, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 2017, "\"", 2034, 1);
#nullable restore
#line 43 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 2023, item.Image, 2023, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2035, "\"", 2051, 1);
#nullable restore
#line 43 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"
WriteAttributeValue("", 2041, item.Name, 2041, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </li>
");
#nullable restore
#line 51 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebsiteLaptop.Service.ViewModels.Product.ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
