#pragma checksum "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65d43cce8c4865093a35db6a9ceffd7556eb2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Catalog), @"mvc.1.0.view", @"/Views/Product/Catalog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65d43cce8c4865093a35db6a9ceffd7556eb2c0", @"/Views/Product/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteLaptop.Application.Models.ProductViewModels.CatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortBy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
  
    ViewData["Title"] = Model.Category.Name;
    //ViewData["MetaKeyword"] = Model.Category.SeoKeywords;
    //ViewData["MetaDescription"] = Model.Category.SeoDescription;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Trang chủ</a><span>&raquo;</span></li>
                    <li><strong>");
#nullable restore
#line 15 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                           Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></li>
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
                        <h2>");
#nullable restore
#line 29 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"toolbar column\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65d43cce8c4865093a35db6a9ceffd7556eb2c07399", async() => {
                WriteLiteral("\r\n                            <div class=\"sorter\">\r\n                                <div class=\"short-by\">\r\n                                    <label>Sắp xếp theo:</label>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65d43cce8c4865093a35db6a9ceffd7556eb2c07875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 37 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortTypes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"short-by page\">\r\n                                    <label>Show:</label>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65d43cce8c4865093a35db6a9ceffd7556eb2c010333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 41 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 42 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PageSizes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1149, "/", 1149, 1, true);
#nullable restore
#line 32 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
AddHtmlAttributeValue("", 1150, Model.Category.Alias, 1150, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1171, "-c.", 1171, 3, true);
#nullable restore
#line 32 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
AddHtmlAttributeValue("", 1174, Model.Category.Id, 1174, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1194, ".html", 1194, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
#nullable restore
#line 49 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                             foreach (var item in Model.Data.Results)
                            {
                                var url = "/" + item.Alias + "-p." + item.Id + ".html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Giảm giá</div>
                                                <div class=""icon-new-label new-right"">Mới</div>
                                                <div class=""pr-img-area"">
                                                    <a title=""Ipsums Dolors Untra""");
            BeginWriteAttribute("href", " href=\"", 3016, "\"", 3027, 1);
#nullable restore
#line 59 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3023, url, 3023, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\"");
            BeginWriteAttribute("src", " src=\"", 3118, "\"", 3135, 1);
#nullable restore
#line 60 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3124, item.Image, 3124, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3136, "\"", 3152, 1);
#nullable restore
#line 60 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3142, item.Name, 3142, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 3177, "\"", 3194, 1);
#nullable restore
#line 60 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3183, item.Image, 3183, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3195, "\"", 3211, 1);
#nullable restore
#line 60 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 3201, item.Name, 3201, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></figure>\r\n                                                    </a>\r\n                                                </div>\r\n");
            WriteLiteral(@"                                            </div>
                                            <div class=""item-info"">
                                                <div class=""info-inner"">
                                                    <div class=""item-title""> <a");
            BeginWriteAttribute("title", " title=\"", 4368, "\"", 4386, 1);
#nullable restore
#line 73 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 4376, item.Name, 4376, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4387, "\"", 4398, 1);
#nullable restore
#line 73 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
WriteAttributeValue("", 4394, url, 4394, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </div>\r\n                                                    <div class=\"item-content\">\r\n");
            WriteLiteral("                                                        <div class=\"item-price\">\r\n                                                            <div class=\"price-box\"> <span class=\"regular-price\"> <span class=\"price\">");
#nullable restore
#line 77 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                                                                                                                                Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </span> </div>
                                                        </div>
                                                        <div class=""pro-action"">
                                                            <button type=""button"" class=""add-to-cart"" data-id=""");
#nullable restore
#line 80 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                                                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""><span> Thêm vào giỏ</span> </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
#nullable restore
#line 88 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                    ");
#nullable restore
#line 93 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Product\Catalog.cshtml"
                Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Main Container End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteLaptop.Application.Models.ProductViewModels.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
