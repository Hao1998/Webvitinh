#pragma checksum "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da74c0e63bf6a09807f5a4352f8f129c41fc7e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Content_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Content/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Content_Index))]
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
#line 1 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da74c0e63bf6a09807f5a4352f8f129c41fc7e3", @"/Areas/Admin/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c330a7985887ff74e7fa83f85c24ebfc4df7420", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
  
    ViewBag.Title = "Quản lý tin tức";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("header", async() => {
                BeginContext(172, 25, true);
                WriteLiteral("\r\n    Danh sách tin tức\r\n");
                EndContext();
            }
            );
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(220, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(227, 269, true);
            WriteLiteral(@"<div class=""row"">

    <div class=""col-lg-12"">

        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                Danh sách tin tức
            </div>

            <!-- /.panel-heading -->
            <div class=""panel-body"">
");
            EndContext();
#line 25 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                 using (Html.BeginForm("Index", "Content", FormMethod.Get))
                {

#line default
#line hidden
            BeginContext(592, 201, true);
            WriteLiteral("                    <div class=\"row form-group\">\r\n                        <div class=\"col-lg-12\">\r\n                            <div class=\"col-md-4\">\r\n                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 793, "\"", 822, 1);
#line 30 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
WriteAttributeValue("", 801, ViewBag.SearchString, 801, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(823, 429, true);
            WriteLiteral(@" class=""form-control"" name=""searchString"" />
                            </div>
                            <div class=""col-md-4"">
                                <button type=""submit"" class=""btn btn-success"">Tìm kiếm</button>
                                <a class=""btn btn-primary"" href=""/Admin/Content/Create"">Thêm mới</a>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 38 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1271, 555, true);
            WriteLiteral(@"
                <div class=""table-responsive"">
                    <table class=""table table-striped table-bordered table-hover"">
                        <thead>
                            <tr>

                                <th>Tiêu đề</th>
                                <th>Hình ảnh</th>
                                <th>Ngày đăng</th>
                                <th>Trạng thái</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 53 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                             foreach (var item in ViewBag.OnePageOfProduct)
                            {

#line default
#line hidden
            BeginContext(1934, 35, true);
            WriteLiteral("                                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1969, "\"", 1986, 2);
            WriteAttributeValue("", 1974, "row_", 1974, 4, true);
#line 55 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
WriteAttributeValue("", 1978, item.Id, 1978, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1987, 45, true);
            WriteLiteral(">\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2033, 9, false);
#line 57 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2042, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2090, 10, false);
#line 58 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                   Write(item.Image);

#line default
#line hidden
            EndContext();
            BeginContext(2100, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2148, 15, false);
#line 59 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                   Write(item.CreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 87, true);
            WriteLiteral("</td>\r\n                                    <td><a href=\"#\" class=\"btn-active\" data-id=\"");
            EndContext();
            BeginContext(2251, 7, false);
#line 60 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2258, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(2261, 61, false);
#line 60 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                                                                     Write(Html.Raw(item.Status ? "<strong>Kích hoạt</strong>" : "Khoá"));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 95, true);
            WriteLiteral("</a></td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2417, "\"", 2452, 2);
            WriteAttributeValue("", 2424, "/Admin/Content/Edit/", 2424, 20, true);
#line 62 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
WriteAttributeValue("", 2444, item.Id, 2444, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2453, 71, true);
            WriteLiteral(">Sửa</a>\r\n                                        <a href=\"#\" data-id=\"");
            EndContext();
            BeginContext(2525, 7, false);
#line 63 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2532, 115, true);
            WriteLiteral("\" class=\"btn-delete\">Delete</a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 66 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2678, 84, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    ");
            EndContext();
            BeginContext(2763, 139, false);
#line 69 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Content\Index.cshtml"
               Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfProduct, page => Url.Action("Index", new { page, @searchString = @ViewBag.SearchString })));

#line default
#line hidden
            EndContext();
            BeginContext(2902, 160, true);
            WriteLiteral("\r\n                </div>\r\n                <!-- /.table-responsive -->\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
