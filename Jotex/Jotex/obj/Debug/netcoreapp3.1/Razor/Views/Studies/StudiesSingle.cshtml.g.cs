#pragma checksum "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a019bbc3daf91a7741ae86bbc3ac40046a97c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studies_StudiesSingle), @"mvc.1.0.view", @"/Views/Studies/StudiesSingle.cshtml")]
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
#line 1 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a019bbc3daf91a7741ae86bbc3ac40046a97c3", @"/Views/Studies/StudiesSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79ad419387654aae9503df92865c496db1ad093", @"/Views/_ViewImports.cshtml")]
    public class Views_Studies_StudiesSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudyViewModel>
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

<!-- start project-single-section -->
<section class=""project-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-6"">
                <div class=""img-holder"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3a019bbc3daf91a7741ae86bbc3ac40046a97c34254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 976, "~/images/project-single/", 976, 24, true);
#nullable restore
#line 29 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
AddHtmlAttributeValue("", 1000, Model.StudySingles.ElementAt(0).Image, 1000, 38, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col col-md-6\">\r\n                <div class=\"project-details\">\r\n                    <h2>");
#nullable restore
#line 34 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                   Write(Model.StudySingles.ElementAt(0).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3>");
#nullable restore
#line 35 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                   Write(Model.StudySingles.ElementAt(0).Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 36 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                  Write(Model.StudySingles.ElementAt(0).Text1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"project-info\">\r\n                        <ul class=\"clearfix\">\r\n");
#nullable restore
#line 39 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                             foreach (var item in @Model.StudySingles.ElementAt(0).StudyDetails)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><span>");
#nullable restore
#line 41 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                                     Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 41 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                                                      Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""project-single-tab clearfix"">
                    <ul class=""nav"">
                        <li class=""active"">
                            <a href=""#precautions"" data-toggle=""tab"">Challenge</a>
                        </li>
                        <li>
                            <a href=""#intelligence"" data-toggle=""tab"">Solution</a>
                        </li>
                        <li>
                            <a href=""#specializations"" data-toggle=""tab"">Results</a>
                        </li>
                    </ul>

                    <div class=""tab-content"">
                        <div class=""tab-pane fade in active"" id=""precautions"">
                            <p>");
#nullable restore
#line 65 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                          Write(Model.StudySingles.ElementAt(0).Text2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"intelligence\">\r\n                            <p>");
#nullable restore
#line 68 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                          Write(Model.StudySingles.ElementAt(0).Text3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"tab-pane fade\" id=\"specializations\">\r\n                            <p>");
#nullable restore
#line 71 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                          Write(Model.StudySingles.ElementAt(0).Text4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""related-case-studies"">
                    <h2>Related Case Studies</h2>
                    <div class=""case-studies-grids"">
");
#nullable restore
#line 82 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                         foreach (var item in Model.AgentPictures)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grid\">\r\n                                <div class=\"img-holder\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3a019bbc3daf91a7741ae86bbc3ac40046a97c310857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3632, "~/images/case-studies/", 3632, 22, true);
#nullable restore
#line 86 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
AddHtmlAttributeValue("", 3654, item.Picture, 3654, 13, false);

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
#line 95 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Studies\StudiesSingle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end project-single-section -->\r\n");
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
