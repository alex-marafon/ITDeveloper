#pragma checksum "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\PartialViews\_profile_left_sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2efa3020fef1c1ec0d0fc079583de975957235f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews__profile_left_sidebar), @"mvc.1.0.view", @"/Views/Shared/PartialViews/_profile_left_sidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialViews/_profile_left_sidebar.cshtml", typeof(AspNetCore.Views_Shared_PartialViews__profile_left_sidebar))]
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
#line 1 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#line 2 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2efa3020fef1c1ec0d0fc079583de975957235f", @"/Views/Shared/PartialViews/_profile_left_sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews__profile_left_sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1203, true);
            WriteLiteral(@"<!--  .sidebar-panel -->
<div class=""sidebar-panel"">
    <h5 class=""sidebar-panel-title"">Profile</h5>
</div>
<!-- / .sidebar-panel -->


<div class=""user-info clearfix"">
    <img src=""img/avatars/128.jpg"" alt=""avatar"">
    <span class=""name"">SuggeElson</span>
    <div class=""btn-group"">
        <button type=""button"" class=""btn btn-default btn-xs"">
            <i class=""l-basic-gear""></i>
        </button>
        <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown"">
            settings <span class=""caret""></span>
        </button>
        <ul class=""dropdown-menu right"" role=""menu"">
            <li>
                <a href=""profile.html""><i class=""fa fa-edit""></i>Edit profile</a>
            </li>
            <li>
                <a href=""#""><i class=""fa fa-money""></i>Windraws</a>
            </li>
            <li>
                <a href=""#""><i class=""fa fa-credit-card""></i>Deposits</a>
            </li>
            <li class=""divider""></li>");
            WriteLiteral("\n            <li>\r\n                <a href=\"login.html\"><i class=\"fa fa-power-off\"></i>Logout</a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<!--  .sidebar-panel -->\r\n");
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
