#pragma checksum "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14fe7e5516811a74064c0c143c5f9b19172d82d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AlertsPartial), @"mvc.1.0.view", @"/Views/Shared/AlertsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AlertsPartial.cshtml", typeof(AspNetCore.Views_Shared_AlertsPartial))]
namespace AspNetCore
{
    #line hidden
#line 2 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 3 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 5 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using CloudscribeDocker;

#line default
#line hidden
#line 4 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 6 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 7 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Authentication;

#line default
#line hidden
#line 8 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#line 9 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 10 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 4 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 3 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 13 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.Models;

#line default
#line hidden
#line 14 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.Identity;

#line default
#line hidden
#line 15 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.Web;

#line default
#line hidden
#line 16 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.Web.Components;

#line default
#line hidden
#line 17 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.Web.Design;

#line default
#line hidden
#line 18 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Web.Navigation;

#line default
#line hidden
#line 19 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
#line 20 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Pagination.Models;

#line default
#line hidden
#line 21 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.SimpleContent.Models;

#line default
#line hidden
#line 22 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Core.SimpleContent;

#line default
#line hidden
#line 23 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.SimpleContent.Web.TagHelpers;

#line default
#line hidden
#line 24 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.SimpleContent.Web;

#line default
#line hidden
#line 25 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.SimpleContent.Web.Design;

#line default
#line hidden
#line 2 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
using cloudscribe.Web.Common;

#line default
#line hidden
#line 28 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Web.Common.Components;

#line default
#line hidden
#line 29 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Web.Common.Helpers;

#line default
#line hidden
#line 30 "C:\CloudscribeDocker\CloudscribeDocker\Views\_ViewImports.cshtml"
using cloudscribe.Web.Common.Models;

#line default
#line hidden
#line 1 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
using cloudscribe.Web.Common.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14fe7e5516811a74064c0c143c5f9b19172d82d9", @"/Views/Shared/AlertsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698db970889ba1cc6078800aff35455fcb031310", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AlertsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
  
    var alerts = TempData.GetAlerts();
    foreach (var alert in alerts)
    {
        var dismissableClass = alert.Dismissable ? "alert-dismissable" : null;

#line default
#line hidden
            BeginContext(375, 25, true);
            WriteLiteral("        <div role=\"alert\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 400, "\"", 455, 4);
            WriteAttributeValue("", 408, "alert", 408, 5, true);
            WriteAttributeValue(" ", 413, "alert-", 414, 7, true);
#line 11 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
WriteAttributeValue("", 420, alert.AlertStyle, 420, 17, false);

#line default
#line hidden
#line 11 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
WriteAttributeValue(" ", 437, dismissableClass, 438, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 12 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
             if (alert.Dismissable)
            {

#line default
#line hidden
            BeginContext(511, 91, true);
            WriteLiteral("                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\'", 602, "\'", 627, 1);
#line 14 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
WriteAttributeValue("", 615, sr["Close"], 615, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(628, 19, true);
            WriteLiteral(">&times;</button>\r\n");
            EndContext();
#line 15 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(662, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(675, 23, false);
#line 16 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
       Write(Html.Raw(alert.Message));

#line default
#line hidden
            EndContext();
            BeginContext(698, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\CloudscribeDocker\CloudscribeDocker\Views\Shared\AlertsPartial.cshtml"
    }  

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<CloudscribeCommonResources> sr { get; private set; }
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