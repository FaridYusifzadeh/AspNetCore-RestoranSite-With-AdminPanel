#pragma checksum "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f56b61978570bae63711a6bbcb071cc0b5daf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Pato_Palace_Admin_Views_Menu_Content_Index), @"mvc.1.0.view", @"/Areas/Pato_Palace_Admin/Views/Menu_Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Pato_Palace_Admin/Views/Menu_Content/Index.cshtml", typeof(AspNetCore.Areas_Pato_Palace_Admin_Views_Menu_Content_Index))]
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
#line 1 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\_ViewImports.cshtml"
using Pato_Palace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f56b61978570bae63711a6bbcb071cc0b5daf1", @"/Areas/Pato_Palace_Admin/Views/Menu_Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48956972a317159e9933a6f4320c619733046569", @"/Areas/Pato_Palace_Admin/Views/_ViewImports.cshtml")]
    public class Areas_Pato_Palace_Admin_Views_Menu_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Menu_Content>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(75, 502, true);
            WriteLiteral(@"
<div class=""row m-t-30"">
    <div class=""col-md-12"">
        <!-- DATA TABLE-->
        <div class=""table-responsive m-b-40"">
            <h1>Menu_Content</h1>
            <table class=""table table-borderless table-data3"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Title</th>
                        <th>Description</th>
                        <th>Price</th>
                        <th>
                            ");
            EndContext();
            BeginContext(577, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f442a1a0eb5c466f9e8af17b0cff9ccf", async() => {
                BeginContext(625, 42, true);
                WriteLiteral(" <i class=\"fas fa-pencil-alt\"></i>  Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(671, 111, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                      
                        int count = 1;
                    

#line default
#line hidden
            BeginContext(869, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                     foreach (var menu in Model)
                    {

#line default
#line hidden
            BeginContext(944, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1007, 5, false);
#line 31 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1052, 10, false);
#line 32 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                           Write(menu.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1103, 66, false);
#line 33 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                            Write(menu.Description.Substring(0, menu.Description.Length / 2) + "...");

#line default
#line hidden
            EndContext();
            BeginContext(1170, 55, true);
            WriteLiteral("</td>\r\n                            <td class=\"process\">");
            EndContext();
            BeginContext(1226, 10, false);
#line 34 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                                           Write(menu.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1309, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786db2fba0cf422e85b0b11735e8173e", async() => {
                BeginContext(1380, 119, true);
                WriteLiteral("\r\n                                    <i class=\" fas fa-eye\" style=\"color:white\"></i>\r\n                                ");
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
#line 36 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                                                         WriteLiteral(menu.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1503, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1537, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "134b43a891804222aa206204e862fac8", async() => {
                BeginContext(1608, 119, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-edit\" style=\"color:white\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                                                         WriteLiteral(menu.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1731, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1765, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "952d014a77e24fedacca6aff023c0d21", async() => {
                BeginContext(1835, 124, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-trash-alt\" style=\"color:white\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                                                         WriteLiteral(menu.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 70, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Menu_Content\Index.cshtml"
                           count++;
                    }

#line default
#line hidden
            BeginContext(2093, 122, true);
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- END DATA TABLE-->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Menu_Content>> Html { get; private set; }
    }
}
#pragma warning restore 1591
