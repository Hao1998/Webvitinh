#pragma checksum "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9213dffeb81be1fce6db02b9e5a653af0b920571"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Register.cshtml", typeof(AspNetCore.Views_User_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9213dffeb81be1fce6db02b9e5a653af0b920571", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0e9901c95d01e438f2a6ec526ade9ddfb89b41", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webvitinh.Models.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 24, true);
            WriteLiteral("\n\n<div class=\"content\">\n");
            EndContext();
#line 9 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
     using (Html.BeginForm("Register", "User", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(229, 23, false);
#line 11 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(254, 147, true);
            WriteLiteral("        <div class=\"form-horizontal\">\n            <h4>Register\'s Form</h4>\n            <hr />\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(402, 65, false);
#line 17 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(467, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
                 if (ViewBag.Success != null)
                {

#line default
#line hidden
            BeginContext(532, 53, true);
            WriteLiteral("                    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(586, 15, false);
#line 20 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
                                                Write(ViewBag.Success);

#line default
#line hidden
            EndContext();
            BeginContext(601, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 21 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
                }

#line default
#line hidden
            BeginContext(626, 72, true);
            WriteLiteral("            </div>\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(699, 97, false);
#line 24 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.Username, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(796, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(857, 74, false);
#line 26 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.TextBoxFor(model => model.Username, new  { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(931, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(953, 86, false);
#line 27 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 97, true);
            WriteLiteral("\n                </div>\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1137, 97, false);
#line 32 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(1295, 76, false);
#line 34 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.PasswordFor(model => model.Password, new  { @class = "form-control" } ));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1393, 86, false);
#line 35 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 97, true);
            WriteLiteral("\n                </div>\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1577, 104, false);
#line 40 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(1742, 82, false);
#line 42 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.PasswordFor(model => model.ConfirmPassword, new  { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1846, 93, false);
#line 43 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 97, true);
            WriteLiteral("\n                </div>\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(2037, 93, false);
#line 48 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(2191, 70, false);
#line 50 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new  { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2283, 82, false);
#line 51 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 97, true);
            WriteLiteral("\n                </div>\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(2463, 94, false);
#line 56 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2557, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(2618, 70, false);
#line 58 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2688, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2710, 83, false);
#line 59 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2793, 44, true);
            WriteLiteral("\n                </div>\n            </div>\n\n");
            EndContext();
            BeginContext(3276, 54, true);
            WriteLiteral("\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(3331, 94, false);
#line 72 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
           Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3425, 60, true);
            WriteLiteral("\n                <div class=\"col-sm-3\">\n                    ");
            EndContext();
            BeginContext(3486, 71, false);
#line 74 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.TextBoxFor(model => model.Phone, new  { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(3579, 83, false);
#line 75 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3662, 44, true);
            WriteLiteral("\n                </div>\n            </div>\n\n");
            EndContext();
            BeginContext(4735, 93, true);
            WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"g-recaptcha\" data-sitekey=\"");
            EndContext();
            BeginContext(4829, 24, false);
#line 96 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
                                                  Write(ViewData["ReCaptchaKey"]);

#line default
#line hidden
            EndContext();
            BeginContext(4853, 262, true);
            WriteLiteral(@"""></div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                </div>
            </div>
        </div>
");
            EndContext();
#line 105 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
    }

#line default
#line hidden
            BeginContext(5121, 17, true);
            WriteLiteral("</div>\n<div>\n    ");
            EndContext();
            BeginContext(5139, 40, false);
#line 108 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\User\Register.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(5179, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(5207, 65, true);
                WriteLiteral("\n<script src=\'https://www.google.com/recaptcha/api.js\'></script>\n");
                EndContext();
            }
            );
            BeginContext(5274, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webvitinh.Models.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591