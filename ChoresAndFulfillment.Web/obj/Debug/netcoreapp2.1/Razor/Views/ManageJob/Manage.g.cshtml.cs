#pragma checksum "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ManageJob\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73163af2ff5b08001ff01a2f49639fb67773c8b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageJob_Manage), @"mvc.1.0.view", @"/Views/ManageJob/Manage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageJob/Manage.cshtml", typeof(AspNetCore.Views_ManageJob_Manage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73163af2ff5b08001ff01a2f49639fb67773c8b6", @"/Views/ManageJob/Manage.cshtml")]
    public class Views_ManageJob_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ManageJob\Manage.cshtml"
  
    ViewData["Title"] = "Manage";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 164, true);
            WriteLiteral("<br/>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-8\">\r\n        <h3 style=\"margin:1px;\">\r\n            All job applications:\r\n        </h3>\r\n        <ul>\r\n            ");
            EndContext();
            BeginContext(256, 37, false);
#line 13 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ManageJob\Manage.cshtml"
       Write(Html.Raw(ViewData["JobApplications"]));

#line default
#line hidden
            EndContext();
            BeginContext(293, 90, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-sm-4\">\r\n        <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 383, "\"", 418, 2);
            WriteAttributeValue("", 390, "../Delete/", 390, 10, true);
#line 17 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\ManageJob\Manage.cshtml"
WriteAttributeValue("", 400, ViewData["JobId"], 400, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 72, true);
            WriteLiteral(">Delete Job (This action is irreversible.)</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
