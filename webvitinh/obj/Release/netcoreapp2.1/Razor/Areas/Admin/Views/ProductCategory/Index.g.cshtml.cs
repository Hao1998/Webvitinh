#pragma checksum "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f781ecf7098eb11df2bb1e730ea32737ef425ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductCategory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductCategory/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductCategory_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f781ecf7098eb11df2bb1e730ea32737ef425ef5", @"/Areas/Admin/Views/ProductCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c330a7985887ff74e7fa83f85c24ebfc4df7420", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.ProductCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/jquery.jqGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 4 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(149, 21, true);
                WriteLiteral("\n    Category Pop-up\n");
                EndContext();
            }
            );
            BeginContext(172, 109, true);
            WriteLiteral("\n<!--<form method=\"get\" asp-controller=\"ProductCategory\" asp-action=\"Test\">--->\n<div class=\"panel-body\">\n    ");
            EndContext();
            BeginContext(281, 494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acdfc11ab7eb49bdac29ce00495422fd", async() => {
                BeginContext(351, 74, true);
                WriteLiteral("\n        <div class=\"row form-group\">\n            <div class=\"col-lg-12\">\n");
                EndContext();
                BeginContext(730, 38, true);
                WriteLiteral("            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(775, 429, true);
            WriteLiteral(@"
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th class=""categoryid"">CategoryID</th>
                        <th>Name</th>
                        <th>ParentId</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 39 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1275, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1337, 7, false);
#line 42 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1383, 9, false);
#line 43 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1392, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1431, 13, false);
#line 44 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                           Write(item.ParentId);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1483, 11, false);
#line 45 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 70, true);
            WriteLiteral("</td>\n                            <td><button class=\"opener\" data-id=\"");
            EndContext();
            BeginContext(1565, 7, false);
#line 46 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 51, true);
            WriteLiteral("\">View</button></td>\n                        </tr>\n");
            EndContext();
#line 48 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1645, 38, true);
            WriteLiteral("                    <!--Phân trang-->\n");
            EndContext();
#line 50 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                     if (ViewBag.TotalPage > 1)
                    {
                        var pageDisplay = (int)ViewBag.MaxPage;
                        int totalPage = (int)ViewBag.TotalPage;
                        int currentPage = ((int)ViewBag.Page);

                        // Create numeric links
                        var startPageIndex = Math.Max(1, currentPage - pageDisplay / 2);
                        var endPageIndex = Math.Min(totalPage, currentPage + pageDisplay / 2);
                        var link = "/Admin/ProductCategory/Index";

#line default
#line hidden
            BeginContext(2244, 82, true);
            WriteLiteral("                        <nav>\n                            <ul class=\"pagination\">\n");
            EndContext();
#line 62 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                 if (currentPage > ViewBag.First)
                                {

#line default
#line hidden
            BeginContext(2426, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2468, "\"", 2500, 3);
#line 64 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 2475, link, 2475, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2480, "?page=", 2480, 6, true);
#line 64 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 2486, ViewBag.First, 2486, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2501, 166, true);
            WriteLiteral(" title=\"Front page\" class=\"first\"><i class=\"fa fa-angle-double-left\"></i></a></li>\n                                    <li>\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2667, "\"", 2698, 3);
#line 66 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 2674, link, 2674, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2679, "?page=", 2679, 6, true);
#line 66 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 2685, ViewBag.Prev, 2685, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2699, 111, true);
            WriteLiteral(" title=\"Last page\" class=\"prev\"><i class=\"fa fa-angle-left\"></i></a>\n                                    </li>\n");
            EndContext();
#line 68 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"

                                }

#line default
#line hidden
            BeginContext(2845, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 70 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                 for (int i = startPageIndex; i <= endPageIndex; i++)
                                {
                                    if (currentPage == i)
                                    {


#line default
#line hidden
            BeginContext(3062, 47, true);
            WriteLiteral("                                        <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3109, "\"", 3129, 3);
#line 75 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3116, link, 3116, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3121, "?page=", 3121, 6, true);
#line 75 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3127, i, 3127, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3130, 15, true);
            WriteLiteral(" class=\"active\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3145, "\"", 3160, 2);
            WriteAttributeValue("", 3153, "Page", 3153, 4, true);
#line 75 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue(" ", 3157, i, 3158, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3161, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3163, 1, false);
#line 75 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3164, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 76 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3291, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3337, "\"", 3357, 3);
#line 79 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3344, link, 3344, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3349, "?page=", 3349, 6, true);
#line 79 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3355, i, 3355, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3358, "\"", 3374, 2);
            WriteAttributeValue("", 3366, "Trang", 3366, 5, true);
#line 79 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue(" ", 3371, i, 3372, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3375, 13, true);
            WriteLiteral(" class=\"pos\">");
            EndContext();
            BeginContext(3389, 1, false);
#line 79 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                                                                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3390, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 80 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(3472, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 82 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                 if (currentPage < totalPage)
                                {

#line default
#line hidden
            BeginContext(3568, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3610, "\"", 3641, 3);
#line 84 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3617, link, 3617, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3622, "?page=", 3622, 6, true);
#line 84 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3628, ViewBag.Next, 3628, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3642, 119, true);
            WriteLiteral(" class=\"next\" title=\"Front page\"><i class=\"fa fa-angle-right\"></i></a></li>\n                                    <li> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3761, "\"", 3792, 3);
#line 85 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3768, link, 3768, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3773, "?page=", 3773, 6, true);
#line 85 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
WriteAttributeValue("", 3779, ViewBag.Last, 3779, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3793, 82, true);
            WriteLiteral(" class=\"last\" title=\"Last page\"><i class=\"fa fa-angle-double-right\"></i></a></li>\n");
            EndContext();
#line 86 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3909, 66, true);
            WriteLiteral("\n                            </ul>\n                        </nav>\n");
            EndContext();
#line 90 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\ProductCategory\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(3998, 5897, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
</div>



<div id=""dialog"" align=""center"">
    <table id=""jqGrid"" align=""center""></table>
    <div id=""jqGridPager""></div>
</div>
<script type=""text/javascript"">
    var clearGrid = function () {
        $(""#jqGrid"").jqGrid('GridDestroy');
    };

    $(function () {
        $(""#dialog"").dialog({

            autoOpen: false,
            width: 800,
            height: 550,
            show: {
                effect: ""blind"",
                duration: 1000,
                width: 780
            },
            hide: {
                effect: ""explode"",
                duration: 1000
            },
            close: function (event, ui) {
                //kết  hợp local array với ajax
                $.jgrid.gridUnload('#jqGrid');
                //location.reload();
                //$(""#jqGrid"").jqGrid('GridDestroy');
            }
        });

        $("".opener"").on(""click"", function () {
            $(""#dialog"").dialog(""open"");
        });
   ");
            WriteLiteral(@" });
    $("".opener"").on('click', function () {
        $.ajax({
            type: ""POST"",
            data:
            {
                categoryid: $(this).data('id')
            },
            dataType: 'json',
            url: ""GetDetail"",
            success: function (response) {
                console.log(response);
                //console.log(test);
                var temp = response;
                /*for (var i = 1; i <= response.length; i++) {
                    var item = response[i];
                    gridArrayData.push({
                        id: response.id,
                        name: response.name,
                        description: response.description,
                        price: response.price,
                        categoryId: response.categoryId
                    });
                }*/
                console.log(temp);
                $(document).ready(function () {
                    $(""#jqGrid"").jqGrid({
                        data: response,
                  ");
            WriteLiteral(@"      datatype: ""local"",
                        shrinkToFit: true,
                        colModel: [
                            { key: true, label: 'id', name: 'id' },
                            { label: 'name', name: 'name', editable: true },
                            { label: 'description', name: 'description', editable: true },
                            { label: 'price', name: 'price', editable: true },
                            { label: 'categoryId', name: 'categoryId', editable: true },
                            { label: 'status', name: 'status', editable: true },
                        ],
                        loadonce: true,
                        viewrecords: true,
                        width: 700,
                        height: 450,
                        rowNum: 15,
                        rowList: [10, 15, 20, 30, 50],
                        pager: ""#jqGridPager""
                    });
                    $('#jqGrid').navGrid('#jqGridPager',
                        // the but");
            WriteLiteral(@"tons to appear on the toolbar of the grid
                        { edit: true, add: true, del: true, search: true, refresh: false, view: false, position: ""left"", cloneToTop: false },
                        // options for the Edit Dialog
                        {
                            editCaption: ""The Edit Dialog"",
                            url: 'EditProductCategoryJson',
                            afterSubmit: function () {
                                $(this).jqGrid(""setGridParam"", { datatype: 'local' });
                                return [true];
                            },
                            beforeSubmit: function (postdata, form, oper) {
                                if (confirm('Are you sure you want to update this row?')) {
                                    return [true, ''];
                                } else {
                                    return [false, 'You can not submit!'];
                                }
                            },
               ");
            WriteLiteral(@"             closeAfterEdit: true,
                            errorTextFormat: function (data) {
                                return 'Error: ' + data.responseText
                            }
                        },
                        // options for the Add Dialog
                        {
                            url: ""AddProductCategoryJson"",
                            afterSubmit: function () {
                                $(this).jqGrid(""setGridParam"", {
                                    datatype: 'local'
                                });
                                return [true];
                            },
                            closeAfterAdd: true,
                        },
                        // options for the Delete Dailog
                        {
                            url: ""DeleteProductCategoryJson"",
                            beforeSubmit: function (postdata, form, oper) {
                                if (confirm('Are you wanna delete?')) {

   ");
            WriteLiteral(@"                                 return [true, ''];
                                } else {
                                    return [false, 'You can not delete!'];
                                }
                            },
                            afterSubmit: function () {
                                $(this).jqGrid(""setGridParam"", {
                                    datatype: 'local'
                                });
                                return [true];
                            },
                            errorTextFormat: function (data) {
                                return 'Error: ' + data.responseText
                            }
                        });
                });
            }
        });
    });

</script>

");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(9913, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(9918, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df955f1898b47ab902047b5d7402db5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9988, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(9993, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e5256fbdd8b40429522e57c1e467a9e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10062, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Model.ProductCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
