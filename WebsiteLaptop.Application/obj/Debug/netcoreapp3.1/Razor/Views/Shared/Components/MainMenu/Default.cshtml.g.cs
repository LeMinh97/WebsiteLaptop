#pragma checksum "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12508beeb9b35c886a349f37787bcc90250dadb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12508beeb9b35c886a349f37787bcc90250dadb0", @"/Views/Shared/Components/MainMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""mtmegamenu"">
    <ul class=""hidden-xs"">
        <li class=""mt-root demo_custom_link_cms"">
            <div class=""mt-root-item"">
                <a href=""/"">
                    <div class=""title title_font""><span class=""title-text"">Home</span></div>
                </a>
            </div>

        </li>
        <li class=""mt-root"">
            <div class=""mt-root-item"">
                <a href=""/products.html"">
                    <div class=""title title_font""><span class=""title-text"">Products</span></div>
                </a>
            </div>
            <ul class=""menu-items col-xs-12"">
");
#nullable restore
#line 19 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                 foreach (var item in Model.Where(c => c.ParentId == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"menu-item depth-1 menucol-1-3 \">\r\n                        <div class=\"title title_font\"> <a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 922, 5);
            WriteAttributeValue("", 892, "/", 892, 1, true);
#nullable restore
#line 22 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 893, item.Alias, 893, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 904, "-c.", 904, 3, true);
#nullable restore
#line 22 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 907, item.Id, 907, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 917, ".html", 917, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                        <ul class=\"submenu\">\r\n");
#nullable restore
#line 24 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                             foreach (var subItem in Model.Where(x => x.ParentId == item.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"menu-item\">\r\n                                    <div class=\"title\"> <a");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1275, 5);
            WriteAttributeValue("", 1239, "/", 1239, 1, true);
#nullable restore
#line 27 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1240, subItem.Alias, 1240, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1254, "-c.", 1254, 3, true);
#nullable restore
#line 27 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
WriteAttributeValue("", 1257, subItem.Id, 1257, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1270, ".html", 1270, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                                                                                                  Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                </li>\r\n");
#nullable restore
#line 29 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 33 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Shared\Components\MainMenu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </ul>
        </li>

        <li class=""mt-root"">
            <div class=""mt-root-item"">
                <a href=""about.html"">
                    <div class=""title title_font""><span class=""title-text"">About</span></div>
                </a>
            </div>
        </li>
        <li class=""mt-root demo_custom_link_cms"">
            <div class=""mt-root-item"">
                <a href=""blog.html"">
                    <div class=""title title_font""><span class=""title-text"">Blog</span></div>
                </a>
            </div>
        </li>
        <li class=""mt-root"">
            <div class=""mt-root-item"">
                <div class=""title title_font""><span class=""title-text"">Best Seller</span></div>
            </div>
            <ul class=""menu-items col-xs-12"">
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
                        <div class=""item-inner"">
                            <div cl");
            WriteLiteral(@"ass=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""single_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html theme""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
                                </div>
                                <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                         ");
            WriteLiteral(@"               <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item-info"">
                                <div class=""info-inner"">
                                    <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item-content"">
                                        <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                        <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                ");
            WriteLiteral(@"        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
                        <div class=""item-inner"">
                            <div class=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""single_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/imag");
            WriteLiteral(@"es/products/product-1.jpg"" alt=""html Template""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
                                </div>
                                <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item-info"">
                                <div class=""info-inner"">
    ");
            WriteLiteral(@"                                <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item-content"">
                                        <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                        <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                        </div>
                                    </div>
                                </div>
                 ");
            WriteLiteral(@"           </div>
                        </div>
                    </div>
                </li>
                <li class=""menu-item depth-1 product menucol-1-3 withimage"">
                    <div class=""product-item"">
                        <div class=""item-inner"">
                            <div class=""icon-sale-label sale-left"">Sale</div>
                            <div class=""icon-new-label new-right"">New</div>
                            <div class=""product-thumbnail"">
                                <div class=""icon-sale-label sale-left"">Sale</div>
                                <div class=""pr-img-area"">
                                    <a title=""Product title here"" href=""single_product.html"">
                                        <figure> <img class=""first-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""> <img class=""hover-img"" src=""/client-side/images/products/product-1.jpg"" alt=""html Template""></figure>
                                    </a>
     ");
            WriteLiteral(@"                           </div>
                                <div class=""pr-info-area"">
                                    <div class=""pr-button"">
                                        <div class=""mt-button add_to_wishlist""> <a href=""wishlist.html""> <i class=""fa fa-heart""></i> </a> </div>
                                        <div class=""mt-button add_to_compare""> <a href=""compare.html""> <i class=""fa fa-signal""></i> </a> </div>
                                        <div class=""mt-button quick-view""> <a href=""quick_view.html""> <i class=""fa fa-search""></i> </a> </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item-info"">
                                <div class=""info-inner"">
                                    <div class=""item-title""> <a title=""Product title here"" href=""single_product.html"">Product title here </a> </div>
                                    <div class=""item");
            WriteLiteral(@"-content"">
                                        <div class=""rating""> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> <i class=""fa fa-star-o""></i> </div>
                                        <div class=""item-price"">
                                            <div class=""price-box""> <span class=""regular-price""> <span class=""price"">$125.00</span> </span> </div>
                                        </div>
                                        <div class=""pro-action"">
                                            <button type=""button"" class=""add-to-cart""><span> Add to Cart</span> </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
            </ul>
        </li>
        <li><a href=""/contact.html"">Contact</a></li>
    </ul");
            WriteLiteral(">\r\n</div>");
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
