#pragma checksum "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a45ea531c550a867832b08a8d25d72ca9139222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Common_Views_Info_Index), @"mvc.1.0.view", @"/Areas/Common/Views/Info/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
using ElectronicJournal.Web.Areas.Common.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a45ea531c550a867832b08a8d25d72ca9139222", @"/Areas/Common/Views/Info/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0335826a6e75dee79add0247c74f19c2883afe", @"/Areas/Common/Views/_ViewImports.cshtml")]
    public class Areas_Common_Views_Info_Index : ElectronicJournal.Web.Views.ElectronicJournalRazorPage<GetInfoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
  
    ViewBag.CurrentPageName = ElectronicJournalPageNames.PageNames.CommonInfo;
    ViewBag.Title = ElectronicJournalPageNames.DisplayPageNames.CommonInfo;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Инофрмация о преподавателях</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Имя</th>
            <th scope=""col"">Фамилия</th>
            <th scope=""col"">Предмет</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
         foreach (var teacher in Model.Value.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 23 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
                           Write(teacher.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 24 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
               Write(teacher.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 26 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
                     if (teacher.AcademicSubject != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 28 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
                      Write(teacher.AcademicSubject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Не преподает ни какой предмет</p>\r\n");
#nullable restore
#line 34 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "D:\Job\repos\ElectonicJournal\ElectonicJournal.Web\Areas\Common\Views\Info\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetInfoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
