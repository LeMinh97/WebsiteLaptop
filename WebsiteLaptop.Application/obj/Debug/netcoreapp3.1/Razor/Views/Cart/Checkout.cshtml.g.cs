#pragma checksum "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4a84ba351670e1b0461eb03f9aac006e0bffb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4a84ba351670e1b0461eb03f9aac006e0bffb8", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0516932e5fb6f913aeebe83e1f6b9ff3d681dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "paymentMethod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/checkout.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Thanh toán";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <recaptcha-script validation-message-element-id=\"recaptchaErrorMessage\" />\r\n\r\n    ");
#nullable restore
#line 8 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Trang chủ</a><span>&raquo;</span></li>
                    <li><strong>Thanh toán</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<section class=""main-container col2-right-layout"">
    <div class=""main container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""page-title"">
                    <h2>Thanh toán</h2>
                </div>
                <div class=""page-content checkout-page"">
");
#nullable restore
#line 34 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                     if (ViewData["Success"] != null)
                    {
                        if ((bool)ViewData["Success"] == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-success\">\r\n                                Cảm ơn bạn đã đặt hàng của bạn. Chúng tôi sẽ sớm xác nhận đơn đặt hàng của bạn.\r\n                            </div>\r\n");
#nullable restore
#line 41 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">\r\n                                Có lỗi trong tiến trình đặt hàng. Vui lòng liên hệ với quản trị viên.\r\n                            </div>\r\n");
#nullable restore
#line 48 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"

                        }


                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de4a84ba351670e1b0461eb03f9aac006e0bffb89294", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <h4 class=""checkout-sep"">1. Phương thức thanh toán</h4>
                            <div class=""box-border"">
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <h5>Thanh toán với tư cách khách hoặc Đăng ký</h5>
                                        <p>Đăng ký với chúng tôi để thuận tiện trong tương lai:</p>
                                        <br>
                                        <h4>Đăng ký và tiết kiệm thời gian!</h4>
                                        <p>Đăng ký với chúng tôi để thuận tiện trong tương lai:</p>
                                        <p><i class=""fa fa-check-circle text-primary""></i> Thanh toán nhanh chóng và dễ dàng</p>
                                        <p><i class=""fa fa-check-circle text-primary""></i> Dễ dàng truy cập vào lịch sử và trạng thái đơn hàng của bạn</p>
                                        <button class=""button"" o");
                WriteLiteral(@"nclick=""window.location.href='/register.html'""><i class=""fa fa-angle-double-right""></i>&nbsp; <span>Tiếp tục</span></button>
                                    </div>
                                    <div class=""col-sm-6"">
                                        <h5>Đăng nhập</h5>
                                        <p>Đã đăng ký? Vui lòng đăng nhập bên dưới:</p>
                                        <button class=""button"" onclick=""window.location.href='/login.html'""><i class=""icon-login""></i>&nbsp; <span>Đăng nhập</span></button>
                                    </div>
                                </div>
                            </div>

                            <h4 class=""checkout-sep"">2. Thông tin vận chuyển</h4>
                            <div class=""box-border"">
                                <ul>
                                    <li class=""row"">
                                        <div class=""col-sm-6"">
                                            <label class");
                WriteLiteral("=\"required\">Họ và tên</label>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de4a84ba351670e1b0461eb03f9aac006e0bffb812060", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 85 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->
                                        <div class=""col-sm-6"">
                                            <label class=""required"">Số điện thoại</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de4a84ba351670e1b0461eb03f9aac006e0bffb814158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 90 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerMobile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </li>
                                    <!--/ .row -->
                                    <!--/ .row -->

                                    <li class=""row"">
                                        <div class=""col-xs-12"">
                                            <label class=""required"">Địa chỉ</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de4a84ba351670e1b0461eb03f9aac006e0bffb816401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 99 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerAddress);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->

                                    </li>
                                    <!--/ .row -->


                                    <li class=""row"">
                                        <div class=""col-sm-12"">
                                            <label class=""required"">Ghi chú</label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de4a84ba351670e1b0461eb03f9aac006e0bffb818654", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 110 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <!--/ [col] -->

                                    </li>
                                    <!--/ .row -->


                                </ul>
                            </div>
                            <h4 class=""checkout-sep"">3. Thông tin thanh toán</h4>
                            <div class=""box-border"">
                                <ul>
");
#nullable restore
#line 123 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                     for (int i = 0; i < Model.PaymentMethods.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de4a84ba351670e1b0461eb03f9aac006e0bffb821322", async() => {
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de4a84ba351670e1b0461eb03f9aac006e0bffb821638", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 127 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PaymentMethod);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                                                            WriteLiteral(Model.PaymentMethods[i].Value);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                                ");
#nullable restore
#line 128 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                           Write(Model.PaymentMethods[i].Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 126 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PaymentMethods[i].Value);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 131 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </ul>
                                <button class=""button""><i class=""fa fa-angle-double-right""></i>&nbsp; <span>Tiếp tục</span></button>
                            </div>
                            <h4 class=""checkout-sep last"">4. Xem trước đơn hàng</h4>
                            <div class=""box-border"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered cart_summary"">
                                        <thead>
                                            <tr>
                                                <th class=""cart_product"">Sản phẩm</th>
                                                <th>Mô tả</th>
                                                <th>Giá</th>
                                                <th>Số lượng</th>
                                                <th>Tổng tiền</th>
                                            </tr>
                         ");
                WriteLiteral("               </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 149 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                             foreach (var item in Model.Carts)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td class=\"cart_product\"><a");
                BeginWriteAttribute("href", " href=\"", 8010, "\"", 8063, 5);
                WriteAttributeValue("", 8017, "/", 8017, 1, true);
#nullable restore
#line 152 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8018, item.Product.Alias, 8018, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8037, "-p.", 8037, 3, true);
#nullable restore
#line 152 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8040, item.Product.Id, 8040, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8058, ".html", 8058, 5, true);
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 8069, "\"", 8094, 1);
#nullable restore
#line 152 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8075, item.Product.Image, 8075, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8095, "\"", 8119, 1);
#nullable restore
#line 152 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8101, item.Product.Name, 8101, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a></td>\r\n                                                    <td class=\"cart_description\">\r\n                                                        <p class=\"product-name\"><a");
                BeginWriteAttribute("href", " href=\"", 8297, "\"", 8350, 5);
                WriteAttributeValue("", 8304, "/", 8304, 1, true);
#nullable restore
#line 154 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8305, item.Product.Alias, 8305, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8324, "-p.", 8324, 3, true);
#nullable restore
#line 154 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 8327, item.Product.Id, 8327, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8345, ".html", 8345, 5, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 154 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                                                                                    Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a></p>\r\n                                                        <small><a href=\"#\">Tình trạng : ");
#nullable restore
#line 155 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                                   Write(item.ProductCondition.Condition);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></small><br>\r\n                                                    </td>\r\n                                                    <td class=\"price\"><span>");
#nullable restore
#line 157 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                       Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></td>\r\n                                                    <td class=\"qty\">");
#nullable restore
#line 158 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"price\"><span>");
#nullable restore
#line 159 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                        Write((item.Price * item.Quantity).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 161 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <td colspan=""3""><strong>Tổng tiền</strong></td>
                                                <td colspan=""2""><strong>");
#nullable restore
#line 169 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                                                                   Write(Model.Carts.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </strong></td>
                                            </tr>
                                        </tfoot>
                                    </table>
                                </div>
                                <recaptcha /><span class=""text-danger"" id=""recaptchaErrorMessage""></span>
                                <button type=""button"" class=""button"" onclick=""window.location.href='/cart.html'""><span>Quay lại giỏ hàng</span></button>

                                <button type=""submit"" class=""button pull-right""><span>Đặt hàng</span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 180 "E:\KLTN\WebsiteLaptop\WebsiteLaptop.Application\Views\Cart\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Main Container End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
