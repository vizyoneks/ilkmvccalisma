#pragma checksum "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c64b13f8b04776577407fdb4df9ad2caf98654a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\_ViewImports.cshtml"
using CustomTagHelper;

#line default
#line hidden
#line 2 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\_ViewImports.cshtml"
using CustomTagHelper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c64b13f8b04776577407fdb4df9ad2caf98654a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7ef08d5acbf38bfa9689fee84f0163b9fff63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::CustomTagHelper.TagHelpers.ListGroupTagHelper __CustomTagHelper_TagHelpers_ListGroupTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

    var cities = new List<string>() { "İstanbul", "Ankara" };

#line default
#line hidden
            BeginContext(106, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(111, 17, false);
#line 6 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(140, 19, false);
#line 7 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 70, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n\r\n\r\n");
            EndContext();
            BeginContext(229, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ul", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a2e943cc64e43f1b3be69eaa084152b", async() => {
            }
            );
            __CustomTagHelper_TagHelpers_ListGroupTagHelper = CreateTagHelper<global::CustomTagHelper.TagHelpers.ListGroupTagHelper>();
            __tagHelperExecutionContext.Add(__CustomTagHelper_TagHelpers_ListGroupTagHelper);
#line 12 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml"
__CustomTagHelper_TagHelpers_ListGroupTagHelper.Items = cities;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("items", __CustomTagHelper_TagHelpers_ListGroupTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(253, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(257, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2d5f10ed264197a9f1cd856deda6ec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 14 "C:\Users\bilgea\Desktop\VizyoneksEgitim\CustomTagHelper\CustomTagHelper\Views\Home\About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(cities);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
