#pragma checksum "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7e366efc86e435a81452b6e5ea6c42123dc3bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7e366efc86e435a81452b6e5ea6c42123dc3bf", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3, 56, false);
#line 2 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_layout_original"));

#line default
#line hidden
            EndContext();
            BeginContext(59, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(102, 47, true);
            WriteLiteral("\r\n\r\n<!doctype html>\r\n\r\n<html class=\"no-js\">\r\n\r\n");
            EndContext();
            BeginContext(150, 45, false);
#line 11 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_head"));

#line default
#line hidden
            EndContext();
            BeginContext(195, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(199, 1909, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b7e366efc86e435a81452b6e5ea6c42123dc3bf4213", async() => {
                BeginContext(205, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(214, 47, false);
#line 15 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_navbar"));

#line default
#line hidden
                EndContext();
                BeginContext(261, 281, true);
                WriteLiteral(@"


    <!-- #wrapper -->
    <div id=""wrapper"">
        <!-- .page-sidebar -->
        <aside id=""sidebar"" class=""page-sidebar hidden-md hidden-sm hidden-xs"">
            <div class=""sidebar-inner"">
                <div class=""sidebar-scrollarea"">


                    ");
                EndContext();
                BeginContext(543, 61, false);
#line 26 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_profile_left_sidebar"));

#line default
#line hidden
                EndContext();
                BeginContext(604, 244, true);
                WriteLiteral("\r\n\r\n                    <div class=\"sidebar-panel\">\r\n                        <h5 class=\"sidebar-panel-title\">Navigation</h5>\r\n                    </div>\r\n\r\n                    <div class=\"side-nav\">\r\n                        <ul class=\"nav\">\r\n\r\n");
                EndContext();
                BeginContext(906, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(937, 57, false);
#line 37 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
                       Write(await Html.PartialAsync("PartialViews/_lis_do_menu_left"));

#line default
#line hidden
                EndContext();
                BeginContext(994, 126, true);
                WriteLiteral("\r\n\r\n                        </ul>\r\n                    </div>\r\n                    <!-- / side-nav -->\r\n\r\n                    ");
                EndContext();
                BeginContext(1121, 59, false);
#line 43 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_menu_inferior_left"));

#line default
#line hidden
                EndContext();
                BeginContext(1180, 157, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <!-- End .sidebar-scrollarea -->\r\n\r\n        </aside>\r\n        <!-- / page-sidebar -->\r\n\r\n        ");
                EndContext();
                BeginContext(1338, 53, false);
#line 52 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("PartialViews/_rightsidebar"));

#line default
#line hidden
                EndContext();
                BeginContext(1391, 233, true);
                WriteLiteral("\r\n\r\n        <!-- .page-content -->\r\n        <div class=\"page-content sidebar-page right-sidebar-page clearfix\">\r\n            <div class=\"page-content-wrapper\">\r\n                <div class=\"page-content-inner\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1625, 51, false);
#line 59 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("PartialViews/_sub_navbar"));

#line default
#line hidden
                EndContext();
                BeginContext(1676, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(1701, 12, false);
#line 61 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1713, 115, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n    <!-- / #wrapper -->\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(1829, 47, false);
#line 73 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_footer"));

#line default
#line hidden
                EndContext();
                BeginContext(1876, 122, true);
                WriteLiteral("\r\n\r\n\r\n    <!-- Back to top -->\r\n    <div id=\"back-to-top\">\r\n        <a href=\"#\">Voltar para o Topo</a>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(1999, 48, false);
#line 81 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("PartialViews/_scripts"));

#line default
#line hidden
                EndContext();
                BeginContext(2047, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2056, 41, false);
#line 83 "C:\Users\Trut4's\Source\Repos\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2097, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2108, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
