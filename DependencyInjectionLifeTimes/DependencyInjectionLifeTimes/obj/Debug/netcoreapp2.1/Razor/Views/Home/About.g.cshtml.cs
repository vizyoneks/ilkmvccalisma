#pragma checksum "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99764fe12973cd2a74cce1fc8c761762810540d7"
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
#line 1 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\_ViewImports.cshtml"
using DependencyInjectionLifeTimes;

#line default
#line hidden
#line 2 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\_ViewImports.cshtml"
using DependencyInjectionLifeTimes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99764fe12973cd2a74cce1fc8c761762810540d7", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7cd1c91f78f5c63c2c038477ab53c471c1a0ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 32, true);
            WriteLiteral("</h3>\r\n\r\n<p>\r\n    Transient 1 : ");
            EndContext();
            BeginContext(127, 17, false);
#line 8 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
             Write(ViewBag.Transient);

#line default
#line hidden
            EndContext();
            BeginContext(144, 27, true);
            WriteLiteral(" <br />\r\n    Transient 2 : ");
            EndContext();
            BeginContext(172, 18, false);
#line 9 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
             Write(ViewBag.Transient2);

#line default
#line hidden
            EndContext();
            BeginContext(190, 26, true);
            WriteLiteral(" <br />\r\n\r\n    Scoped 1 : ");
            EndContext();
            BeginContext(217, 14, false);
#line 11 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
          Write(ViewBag.Scoped);

#line default
#line hidden
            EndContext();
            BeginContext(231, 24, true);
            WriteLiteral(" <br />\r\n    Scoped 2 : ");
            EndContext();
            BeginContext(256, 15, false);
#line 12 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
          Write(ViewBag.Scoped2);

#line default
#line hidden
            EndContext();
            BeginContext(271, 29, true);
            WriteLiteral(" <br />\r\n\r\n    SingleTon 1 : ");
            EndContext();
            BeginContext(301, 17, false);
#line 14 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
             Write(ViewBag.Singleton);

#line default
#line hidden
            EndContext();
            BeginContext(318, 27, true);
            WriteLiteral(" <br />\r\n    SingleTon 2 : ");
            EndContext();
            BeginContext(346, 18, false);
#line 15 "C:\Users\bilgea\Desktop\VizyoneksEgitim\DependencyInjectionLifeTimes\DependencyInjectionLifeTimes\Views\Home\About.cshtml"
             Write(ViewBag.Singleton2);

#line default
#line hidden
            EndContext();
            BeginContext(364, 15, true);
            WriteLiteral(" <br />\r\n</p>\r\n");
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