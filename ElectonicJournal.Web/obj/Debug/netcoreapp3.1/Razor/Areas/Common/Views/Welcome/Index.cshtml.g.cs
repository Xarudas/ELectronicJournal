#pragma checksum "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Welcome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b887b642c4760ae82e7f7d2adb1369414b7d7c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Common_Views_Welcome_Index), @"mvc.1.0.view", @"/Areas/Common/Views/Welcome/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\_ViewImports.cshtml"
using ElectronicJournal.Web.Areas.Startup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b887b642c4760ae82e7f7d2adb1369414b7d7c9", @"/Areas/Common/Views/Welcome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0335826a6e75dee79add0247c74f19c2883afe", @"/Areas/Common/Views/_ViewImports.cshtml")]
    public class Areas_Common_Views_Welcome_Index : ElectronicJournal.Web.Views.ElectronicJournalRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Welcome\Index.cshtml"
  
    ViewBag.Title = ElectronicJournalPageNames.DisplayPageNames.CommonWelcome;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Добро пожаловать ");
#nullable restore
#line 6 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Welcome\Index.cshtml"
                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
