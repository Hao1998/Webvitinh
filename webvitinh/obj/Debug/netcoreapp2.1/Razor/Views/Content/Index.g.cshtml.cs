#pragma checksum "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c0f485fc792818041345e2d5fe1c07eb7b42c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c0f485fc792818041345e2d5fe1c07eb7b42c6", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0e9901c95d01e438f2a6ec526ade9ddfb89b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Content>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 225, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"content_top\">\r\n        <div class=\"heading\">\r\n            <h3>Tin tức</h3>\r\n        </div>\r\n        <div class=\"see\">\r\n\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
     foreach (var item in Model)
    {
        var photoPath = "/images/" + (item.Image ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(456, 101, true);
            WriteLiteral("        <div class=\"image group\">\r\n            <div class=\"grid images_3_of_1\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 557, "\"", 573, 1);
#line 23 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 563, photoPath, 563, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(574, 96, true);
            WriteLiteral(" alt=\"\" />\r\n            </div>\r\n            <div class=\"grid news_desc\">\r\n                <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 670, "\"", 711, 4);
            WriteAttributeValue("", 677, "/tin-tuc/", 677, 9, true);
#line 26 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 686, item.MetalTitle, 686, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 702, "-", 702, 1, true);
#line 26 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 703, item.Id, 703, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(712, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(714, 9, false);
#line 26 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(723, 42, true);
            WriteLiteral(" </a></h3>\r\n                <h4>Posted on ");
            EndContext();
            BeginContext(766, 15, false);
#line 27 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                         Write(item.CreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(781, 22, true);
            WriteLiteral(" by <span><a href=\"#\">");
            EndContext();
            BeginContext(804, 14, false);
#line 27 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                                                               Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(818, 34, true);
            WriteLiteral("</a></span></h4>\r\n                ");
            EndContext();
            BeginContext(853, 16, false);
#line 28 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(869, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(914, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 34 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
     if (ViewBag.TotalPage > 1)
    {
        var pageDisplay = (int)ViewBag.MaxPage;
        int totalPage = (int)ViewBag.TotalPage;
        int currentPage = ((int)ViewBag.Page);

        // Create numeric links
        var startPageIndex = Math.Max(1, currentPage - pageDisplay / 2);
        var endPageIndex = Math.Min(totalPage, currentPage + pageDisplay / 2);

        var link = "/tin-tuc";

#line default
#line hidden
            BeginContext(1327, 52, true);
            WriteLiteral("        <nav>\r\n            <ul class=\"pagination\">\r\n");
            EndContext();
#line 47 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                 if (currentPage > ViewBag.First)
                {

#line default
#line hidden
            BeginContext(1449, 26, true);
            WriteLiteral("                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1475, "\"", 1507, 3);
#line 49 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 1482, link, 1482, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1487, "?page=", 1487, 6, true);
#line 49 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 1493, ViewBag.First, 1493, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1508, 135, true);
            WriteLiteral(" title=\"Trang đầu\" class=\"first\"><i class=\"fa fa-angle-double-left\"></i></a></li>\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1643, "\"", 1674, 3);
#line 51 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 1650, link, 1650, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1655, "?page=", 1655, 6, true);
#line 51 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 1661, ViewBag.Prev, 1661, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1675, 99, true);
            WriteLiteral(" title=\"Trang trước\" class=\"prev\"><i class=\"fa fa-angle-left\"></i></a>\r\n                    </li>\r\n");
            EndContext();
#line 53 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(1795, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 55 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                 for (int i = startPageIndex; i <= endPageIndex; i++)
                {
                    if (currentPage == i)
                    {


#line default
#line hidden
            BeginContext(1953, 31, true);
            WriteLiteral("                        <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1984, "\"", 2004, 3);
#line 60 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 1991, link, 1991, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1996, "?page=", 1996, 6, true);
#line 60 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2002, i, 2002, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2005, 15, true);
            WriteLiteral(" class=\"active\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2020, "\"", 2036, 2);
            WriteAttributeValue("", 2028, "Trang", 2028, 5, true);
#line 60 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue(" ", 2033, i, 2034, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2037, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2039, 1, false);
#line 60 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 61 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2123, 30, true);
            WriteLiteral("                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2153, "\"", 2173, 3);
#line 64 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2160, link, 2160, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2165, "?page=", 2165, 6, true);
#line 64 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2171, i, 2171, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2174, "\"", 2190, 2);
            WriteAttributeValue("", 2182, "Trang", 2182, 5, true);
#line 64 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue(" ", 2187, i, 2188, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2191, 13, true);
            WriteLiteral(" class=\"pos\">");
            EndContext();
            BeginContext(2205, 1, false);
#line 64 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2206, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 65 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2259, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 67 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                 if (currentPage < totalPage)
                {

#line default
#line hidden
            BeginContext(2325, 26, true);
            WriteLiteral("                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2382, 3);
#line 69 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2358, link, 2358, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2363, "?page=", 2363, 6, true);
#line 69 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2369, ViewBag.Next, 2369, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2383, 103, true);
            WriteLiteral(" class=\"next\" title=\"Trang sau\"><i class=\"fa fa-angle-right\"></i></a></li>\r\n                    <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2486, "\"", 2517, 3);
#line 70 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2493, link, 2493, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2498, "?page=", 2498, 6, true);
#line 70 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
WriteAttributeValue("", 2504, ViewBag.Last, 2504, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2518, 84, true);
            WriteLiteral(" class=\"last\" title=\"Trang cuối\"><i class=\"fa fa-angle-double-right\"></i></a></li>\r\n");
            EndContext();
#line 71 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2621, 37, true);
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n");
            EndContext();
#line 75 "C:\Users\Admin\Desktop\Git\webvitinh\webvitinh\Views\Content\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2665, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Content>> Html { get; private set; }
    }
}
#pragma warning restore 1591