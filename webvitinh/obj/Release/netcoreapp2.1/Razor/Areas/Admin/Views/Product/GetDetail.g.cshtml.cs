#pragma checksum "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4696a571d667c0492d8e50b239ce2f6487be5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_GetDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/GetDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/GetDetail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_GetDetail))]
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
#line 1 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\_ViewImports.cshtml"
using webvitinh.Areas.Admin;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\_ViewImports.cshtml"
using webvitinh.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4696a571d667c0492d8e50b239ce2f6487be5e", @"/Areas/Admin/Views/Product/GetDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c330a7985887ff74e7fa83f85c24ebfc4df7420", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_GetDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 9, true);
            WriteLiteral("\n<p>\n    ");
            EndContext();
            BeginContext(43, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99d16f0ddec487ab3bc242efabaae46", async() => {
                BeginContext(66, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(80, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(167, 46, false);
#line 10 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.MetalTitle));

#line default
#line hidden
            EndContext();
            BeginContext(213, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(266, 40, false);
#line 13 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(306, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(359, 40, false);
#line 16 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(399, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(452, 47, false);
#line 19 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(499, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(552, 41, false);
#line 22 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(593, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(646, 46, false);
#line 25 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.MoreImages));

#line default
#line hidden
            EndContext();
            BeginContext(692, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(745, 50, false);
#line 28 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.PromotionPrice));

#line default
#line hidden
            EndContext();
            BeginContext(795, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(848, 41, false);
#line 31 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(889, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(942, 46, false);
#line 34 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.IncludeVat));

#line default
#line hidden
            EndContext();
            BeginContext(988, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1041, 44, false);
#line 37 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1138, 46, false);
#line 40 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1237, 42, false);
#line 43 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Detail));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1332, 44, false);
#line 46 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1429, 46, false);
#line 49 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1528, 45, false);
#line 52 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1626, 48, false);
#line 55 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1727, 46, false);
#line 58 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1826, 48, false);
#line 61 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.MetaKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1927, 51, false);
#line 64 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2031, 42, false);
#line 67 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2126, 42, false);
#line 70 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.TopHot));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2221, 45, false);
#line 73 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.Viewcount));

#line default
#line hidden
            EndContext();
            BeginContext(2266, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 79 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2377, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(2424, 45, false);
#line 82 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.MetalTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2522, 39, false);
#line 85 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2614, 39, false);
#line 88 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2706, 46, false);
#line 91 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2752, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2805, 40, false);
#line 94 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2898, 45, false);
#line 97 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoreImages));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2996, 49, false);
#line 100 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.PromotionPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3045, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3098, 40, false);
#line 103 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3191, 45, false);
#line 106 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.IncludeVat));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3289, 43, false);
#line 109 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3385, 45, false);
#line 112 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(3430, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3483, 41, false);
#line 115 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Detail));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3577, 43, false);
#line 118 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(3620, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3673, 45, false);
#line 121 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3771, 44, false);
#line 124 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3815, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3868, 47, false);
#line 127 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3915, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3968, 45, false);
#line 130 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedBy));

#line default
#line hidden
            EndContext();
            BeginContext(4013, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4066, 47, false);
#line 133 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.MetaKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(4113, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4166, 50, false);
#line 136 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(4216, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4269, 41, false);
#line 139 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(4310, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4363, 41, false);
#line 142 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.TopHot));

#line default
#line hidden
            EndContext();
            BeginContext(4404, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4457, 44, false);
#line 145 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Viewcount));

#line default
#line hidden
            EndContext();
            BeginContext(4501, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4553, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022adafdc0b04a8692611369ccbae728", async() => {
                BeginContext(4598, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 148 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4606, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4625, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f93a19c8a9d4575be36227e07e03ad8", async() => {
                BeginContext(4673, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4684, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4703, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2c9fc171f4385b159bff0b6d354be", async() => {
                BeginContext(4750, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4760, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 153 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\GetDetail.cshtml"
}

#line default
#line hidden
            BeginContext(4795, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
