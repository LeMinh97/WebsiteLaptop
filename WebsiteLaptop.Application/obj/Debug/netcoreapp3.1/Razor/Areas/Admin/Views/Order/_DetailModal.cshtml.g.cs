#pragma checksum "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\Order\_DetailModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b87b6ebb5ef3c3e45762d09d8fbfbd92579d6e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order__DetailModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/_DetailModal.cshtml")]
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
#line 1 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Application.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Code KLTN\WebsiteLaptop\WebsiteLaptop.Application\Areas\Admin\Views\_ViewImports.cshtml"
using WebsiteLaptop.Service.ViewModels.System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b87b6ebb5ef3c3e45762d09d8fbfbd92579d6e1", @"/Areas/Admin/Views/Order/_DetailModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6283f1986a438c80f6bf194f74ef0cd006624406", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order__DetailModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""modal-detail"" class=""modal fade in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                <h4 class=""modal-title"">Order detail</h4>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b87b6ebb5ef3c3e45762d09d8fbfbd92579d6e15871", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidId"" value=""0"" />
                            <label for=""txtCustomerName"" class=""col-sm-2 control-label "">Customer name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerName"" class=""form-control"" id=""txtCustomerName"">
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""txtCustomerAddress"" class=""col-sm-2 control-label "">Address</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerAddress"" class=""form-control"" id=""txtCustomerAddress"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtCustomerMobile"" class=""col-sm-2 control-label ");
                WriteLiteral(@""">Phone</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerMobile"" class=""form-control"" id=""txtCustomerMobile"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtCustomerMessage"" class=""col-sm-2 control-label "">Customer message</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtCustomerMessage"" class=""form-control"" id=""txtCustomerMessage"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label "">Payment method</label>
                            <div class=""col-sm-10"">
                                <select id=""ddlPaymentMethod"" class=""form-control""></select>
                            </div>
                       ");
                WriteLiteral(@" </div>
                        <div class=""form-group"">
                            <label f class=""col-sm-2 control-label "">Order status</label>
                            <div class=""col-sm-10"">
                                <select id=""ddlOrderStatus"" class=""form-control""></select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label "">Details</label>
                            <div class=""col-sm-10"">
                                <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>Product Name</th>
                                            <th>Product Condition</th>
                                            <th>Quantity</th>
                                            <td></td>
                                        </tr>
         ");
                WriteLiteral(@"                           </thead>
                                    <tbody id=""tbl-order-details""></tbody>
                                    <tfoot>
                                        <tr>
                                            <td colspan=""5"">
                                                <button class=""btn btn-xs btn-success"" id=""btnAddDetail"" type=""button"">Add</button>
                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>
                                <script type=""x-tmpl-mustache"" id=""template-table-order-details"">
                                    <tr data-id=""{{Id}}"">
                                        <td>{{{Products}}}</td>
                                        <td>{{{ProductConditions}}}</td>
                                        <td><input type=""number"" class=""txtQuantity form-control"" value=""{{Quantity}}"" /></td>
              ");
                WriteLiteral(@"                          <td><button class=""btn btn-xs btn-danger btn-delete-detail"" type=""button""><i class=""fa fa-trash""></i></button></td>
                                    </tr>
                                </script>
                            </div>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                    <button type=""button"" id=""btnConfirm"" class=""btn btn-success"">Confirm payment</button>
                    <button type=""button"" id=""btnPending"" class=""btn btn-warning"">Pending</button>
                    <button type=""button"" id=""btnCancel"" class=""btn btn-primary"">Cancel</button>
");
            WriteLiteral("\r\n                    <button type=\"button\" data-dismiss=\"modal\" class=\"btn btn-danger\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
