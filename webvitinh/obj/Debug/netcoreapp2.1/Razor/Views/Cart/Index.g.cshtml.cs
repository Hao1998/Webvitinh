#pragma checksum "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c3efa7f66ef2c55a379e8d7bb716af1f49c171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\_ViewImports.cshtml"
using webvitinh;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\_ViewImports.cshtml"
using webvitinh.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3efa7f66ef2c55a379e8d7bb716af1f49c171", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0e9901c95d01e438f2a6ec526ade9ddfb89b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<webvitinh.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/js/Controller/cartController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("jsFooter", async() => {
                BeginContext(137, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(142, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2175e2dbd04ee1ae0aa46ee9fbcc74", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(206, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(209, 54, true);
            WriteLiteral("<div class=\"content\">\n    <div class=\"section group\">\n");
            EndContext();
#line 11 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(305, 494, true);
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <td>Product's code</td>
                        <td>Product's name</td>
                        <td>Product's image</td>
                        <td>Product's quantity</td>
                        <td>Product's price</td>
                        <td>Total money</td>
                        <td>Total money</td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 26 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(870, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(932, 15, false);
#line 29 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                           Write(item.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(947, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(986, 17, false);
#line 30 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 42, true);
            WriteLiteral("</td>\n                            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1045, "\"", 1087, 2);
            WriteAttributeValue("", 1051, "/imgaes_vitinh_2/", 1051, 17, true);
#line 31 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1068, item.Product.Image, 1068, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1088, 101, true);
            WriteLiteral(" width=\"100\" /></td>\n                            <td><input type=\"text\" class=\"txtQuantity\" data-id=\"");
            EndContext();
            BeginContext(1190, 15, false);
#line 32 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                                                                           Write(item.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1205, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1206, "\"", 1228, 1);
#line 32 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1214, item.Quantity, 1214, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 41, true);
            WriteLiteral(" /></td>\n                            <td>");
            EndContext();
            BeginContext(1271, 54, false);
#line 33 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                           Write(item.Product.Price.GetValueOrDefault(0).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1365, 72, false);
#line 34 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                            Write((item.Product.Price.GetValueOrDefault(0) * item.Quantity).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 59, true);
            WriteLiteral("</td>\n                            <td><a href=\"#\" data-id=\"");
            EndContext();
            BeginContext(1498, 15, false);
#line 35 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                                                Write(item.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1513, 67, true);
            WriteLiteral("\" class=\"btn-delete\">Delete</a></td>\n                        </tr>\n");
            EndContext();
#line 37 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1602, 452, true);
            WriteLiteral(@"                </tbody>
            </table>
            <button id=""btnContinue"" class=""btn"">Continue shopping</button>
            <button id=""btnUpdate"" class=""btn"">Refresh your cart</button>
            <button id=""btnDeleteAll"" class=""btn"">Delete your cart</button>
            <button id=""btnPayment"" class=""btn"">Check out</button>
            <button class=""btn"">
                <a href=""/thanh-toan-paypal"">Paypal</a>
            </button>
");
            EndContext();
#line 47 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2087, 117, true);
            WriteLiteral("            <spand class=\"alert alert-danger\">There are no products !!! please go back and buy some ^__^. !!</spand>\n");
            EndContext();
#line 51 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2214, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<webvitinh.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591