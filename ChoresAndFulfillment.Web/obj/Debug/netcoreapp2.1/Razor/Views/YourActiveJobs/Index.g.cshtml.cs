#pragma checksum "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\YourActiveJobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbcdd7b9c9fb869ef8d38ece7713eb9bcbd1f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YourActiveJobs_Index), @"mvc.1.0.view", @"/Views/YourActiveJobs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YourActiveJobs/Index.cshtml", typeof(AspNetCore.Views_YourActiveJobs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dbcdd7b9c9fb869ef8d38ece7713eb9bcbd1f61", @"/Views/YourActiveJobs/Index.cshtml")]
    public class Views_YourActiveJobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\YourActiveJobs\Index.cshtml"
  
    ViewData["Title"] = "Your Finished Jobs";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 65, true);
            WriteLiteral("<h3>Your active jobs:</h3>\r\n<br />\r\n<ul class=\"list-group\">\r\n    ");
            EndContext();
            BeginContext(169, 26, false);
#line 9 "C:\Users\Vasko\source\repos\Chores_And_Fulfillment\ChoresAndFulfillment.Web\Views\YourActiveJobs\Index.cshtml"
Write(Html.Raw(ViewData["Jobs"]));

#line default
#line hidden
            EndContext();
            BeginContext(195, 9, true);
            WriteLiteral("\r\n</ul>\r\n");
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
