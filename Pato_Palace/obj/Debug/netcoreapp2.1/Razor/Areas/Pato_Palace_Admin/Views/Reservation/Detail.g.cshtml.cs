#pragma checksum "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Reservation\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d03fb704ef58661ce17f3ac8a2da0fa73920a54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Pato_Palace_Admin_Views_Reservation_Detail), @"mvc.1.0.view", @"/Areas/Pato_Palace_Admin/Views/Reservation/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Pato_Palace_Admin/Views/Reservation/Detail.cshtml", typeof(AspNetCore.Areas_Pato_Palace_Admin_Views_Reservation_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d03fb704ef58661ce17f3ac8a2da0fa73920a54", @"/Areas/Pato_Palace_Admin/Views/Reservation/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48956972a317159e9933a6f4320c619733046569", @"/Areas/Pato_Palace_Admin/Views/_ViewImports.cshtml")]
    public class Areas_Pato_Palace_Admin_Views_Reservation_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Reservation\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(62, 140, true);
            WriteLiteral("\r\n<div class=\"container-fluid\" style=\"margin-top:110px;\">\r\n\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-12 mt-5\">\r\n            <h3>");
            EndContext();
            BeginContext(203, 11, false);
#line 10 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Reservation\Detail.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(214, 35, true);
            WriteLiteral("</h3>\r\n            <p class=\"mt-5\">");
            EndContext();
            BeginContext(250, 17, false);
#line 11 "C:\Users\Farid\source\repos\Pato_Palace\Pato_Palace\Areas\Pato_Palace_Admin\Views\Reservation\Detail.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(267, 108, true);
            WriteLiteral("</p>\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-12\">\r\n            ");
            EndContext();
            BeginContext(375, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba5067d46bd430c8eb3fc90dcefdbb5", async() => {
                BeginContext(397, 54, true);
                WriteLiteral("<i class=\" far fa-arrow-alt-circle-left\"></i>  Go Back");
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
            BeginContext(455, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
