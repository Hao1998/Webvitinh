#pragma checksum "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ade9b6274aac6210606d874f596653b9604d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Test), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Test.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Test))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ade9b6274aac6210606d874f596653b9604d28", @"/Areas/Admin/Views/Product/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c330a7985887ff74e7fa83f85c24ebfc4df7420", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Model.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/grid.locale-en.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Admin/Scripts/jqGrid/jquery.jqGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(136, 29, true);
                WriteLiteral("\n    Test local data product\n");
                EndContext();
            }
            );
            BeginContext(167, 3794, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc457850ee934e2e914b33092443bfbf", async() => {
                BeginContext(202, 37, true);
                WriteLiteral("\n    <script>\n        var mydata = [\n");
                EndContext();
#line 13 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(290, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(308, 7, true);
                WriteLiteral("{ id: \'");
                EndContext();
                BeginContext(316, 7, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                    Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(323, 10, true);
                WriteLiteral("\', name: \'");
                EndContext();
                BeginContext(334, 9, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                      Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(343, 9, true);
                WriteLiteral("\',price:\"");
                EndContext();
                BeginContext(353, 10, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(363, 16, true);
                WriteLiteral("\",description: \'");
                EndContext();
                BeginContext(380, 10, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                    Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(390, 22, true);
                WriteLiteral("\' + \"$\", categoryId: \'");
                EndContext();
                BeginContext(413, 15, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                                                     Write(item.CategoryId);

#line default
#line hidden
                EndContext();
                BeginContext(428, 11, true);
                WriteLiteral("\', status:\"");
                EndContext();
                BeginContext(440, 11, false);
#line 15 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
                                                                                                                                                Write(item.Status);

#line default
#line hidden
                EndContext();
                BeginContext(451, 4, true);
                WriteLiteral("\"},\n");
                EndContext();
#line 16 "C:\Users\Admin\Downloads\DoAndotNetCore-master\DoAndotNetCore-master\webvitinh\Areas\Admin\Views\Product\Test.cshtml"
            }

#line default
#line hidden
                BeginContext(469, 3478, true);
                WriteLiteral(@"        ];


        $(document).ready(function () {
            $(""#jqGrid"").jqGrid({
                //url: ""GetData"",
                // we set the changes to be made at client side using predefined word clientArray
                datatype: ""local"",
                data: mydata,
                shrinkToFit: false,
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
                width: 1000,
                height: 600,
                rowNum: 30,
                rowList: [10, 15, 20, 30, 50],
                page");
                WriteLiteral(@"r: ""#jqGridPager""
            });
            $('#jqGrid').navGrid('#jqGridPager',
                // the buttons to appear on the toolbar of the grid
                { edit: true, add: true, del: true, search: true, refresh: false, view: false, position: ""left"", cloneToTop: false },
                // options for the Edit Dialog
                {
                    editCaption: ""The Edit Dialog"",
                    url: 'EditProductJson',
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
                    closeAfterEdit: true,
");
                WriteLiteral(@"                    errorTextFormat: function (data) {
                        return 'Error: ' + data.responseText
                    }
                },
                // options for the Add Dialog
                {
                    url: ""AddProductJson"",
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
                    url: ""DeleteProductJson"",
                    beforeSubmit: function (postdata, form, oper) {
                        if (confirm('Are you wanna delete?')) {

                            return [true, ''];
                        } else {
                            return [false, 'You can not delete!'];
                        }
                    },
                  ");
                WriteLiteral(@"  afterSubmit: function () {
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
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3961, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            DefineSection("jsFooter", async() => {
                BeginContext(3982, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3987, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab719b23b0fe406caa1ca5407809afe1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4057, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4062, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ed7954eb960483294d8fc85933a2708", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4131, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(4134, 131, true);
            WriteLiteral("\n<table id=\"jqGrid\" align=\"center\"></table>\n<div id=\"jqGridPager\"></div>\n<!--<input id=\"btn\" type=\"button\" value=\"Load data\" />-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Model.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591