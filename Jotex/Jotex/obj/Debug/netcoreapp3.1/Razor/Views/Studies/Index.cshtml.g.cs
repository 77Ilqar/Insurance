#pragma checksum "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0785e8ff808b234b8ed3495af79dcb0e76201c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studies_Index), @"mvc.1.0.view", @"/Views/Studies/Index.cshtml")]
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
#line 1 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0785e8ff808b234b8ed3495af79dcb0e76201c37", @"/Views/Studies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79ad419387654aae9503df92865c496db1ad093", @"/Views/_ViewImports.cshtml")]
    public class Views_Studies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudyViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Case studies</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Case studies</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start case-studies-section -->
<section class=""case-studies-section case-studies-pg-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1"">
                <div class=""section-title-s4"">
                    <span>");
#nullable restore
#line 29 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
                     Write(Model.Studies.ElementAt(0).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h2>");
#nullable restore
#line 30 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
                   Write(Model.Studies.ElementAt(0).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 31 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
                  Write(Model.Studies.ElementAt(0).Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n    <div class=\"content-area\">\r\n        <div class=\"case-studies-grids case-studies-slider\">\r\n");
#nullable restore
#line 38 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
             foreach (var item in Model.AgentPictures)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid\">\r\n                    <div class=\"img-holder\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0785e8ff808b234b8ed3495af79dcb0e76201c375631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1581, "~/images/case-studies/", 1581, 22, true);
#nullable restore
#line 42 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
AddHtmlAttributeValue("", 1603, item.Picture, 1603, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 51 "C:\Users\mamma\source\repos\Jotex\Jotex\Views\Studies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- end case-studies-section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591