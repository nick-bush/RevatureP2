#pragma checksum "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/Post/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d6222aac717912fc0cb1109953f7fd600f0060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/_ViewImports.cshtml"
using GoalDigger.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/_ViewImports.cshtml"
using GoalDigger.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d6222aac717912fc0cb1109953f7fd600f0060", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77512611fea21f914f79fdd5098a88287a2ca73b", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GoalDigger.MVC.Models.PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 4 "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/Post/Index.cshtml"
   foreach (var item in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 6 "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/Post/Index.cshtml"
   Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 7 "/Users/alexander/Desktop/P2_again/GoalDigger/GoalDigger.MVC/Views/Post/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GoalDigger.MVC.Models.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591