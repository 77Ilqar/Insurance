#pragma checksum "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5441faf211f3a4223ede7236433763b4a46730cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5441faf211f3a4223ede7236433763b4a46730cb", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79ad419387654aae9503df92865c496db1ad093", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceViewModel>
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
        private global::AspNetCore.Views_Services_Index.__Generated__TestimonialItemViewComponentTagHelper __TestimonialItemViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
   var a = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
   var b = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
   var toogle = "in active";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Service single</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Service single</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start service-single-section -->
<section class=""service-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""service-single-tab"">
                    <ul class=""nav tab-links clearfix"">
");
#nullable restore
#line 32 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                         foreach (var item in Model.Services.ElementAt(0).Categories)
                        {

                            var id = "0";
                            a++;
                            id += a;
                            if (a == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1472, "\"", 1483, 2);
            WriteAttributeValue("", 1479, "#", 1479, 1, true);
#nullable restore
#line 41 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue("", 1480, id, 1480, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 1547, "\"", 1565, 1);
#nullable restore
#line 42 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue("", 1555, item.Icon, 1555, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <h3>");
#nullable restore
#line 43 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 46 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1887, "\"", 1898, 2);
            WriteAttributeValue("", 1894, "#", 1894, 1, true);
#nullable restore
#line 50 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue("", 1895, id, 1895, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 1962, "\"", 1980, 1);
#nullable restore
#line 51 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue("", 1970, item.Icon, 1970, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <h3>");
#nullable restore
#line 52 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 55 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 61 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                         foreach (var item in Model.Services.ElementAt(0).Categories)
                        {
                            var id = "0";
                            b++;
                            id += b;
                            
                            if (b > 1)
                            {
                                toogle = "";
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 2709, "\"", 2738, 3);
            WriteAttributeValue("", 2717, "tab-pane", 2717, 8, true);
            WriteAttributeValue(" ", 2725, "fade", 2726, 5, true);
#nullable restore
#line 71 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue(" ", 2730, toogle, 2731, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2739, "\"", 2747, 1);
#nullable restore
#line 71 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
WriteAttributeValue("", 2744, id, 2744, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"content-area clearfix\">\r\n                                        <div class=\"grid info-grid\">\r\n                                            <h3>");
#nullable restore
#line 74 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <p>");
#nullable restore
#line 75 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                          Write(Html.Raw(item.Subtitle));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <!--<p><strong>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</strong></p>-->
                                            <table>
                                                <tbody>
");
#nullable restore
#line 79 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                     foreach (var detail in Model.CategoryDetails)
                                                    {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                             if (item.Id == detail.CategoryId)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
#nullable restore
#line 84 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                                   Write(detail.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 85 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                                   Write(detail.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                             
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </tbody>
                                            </table>
                                        </div>
                                        <div class=""grid"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5441faf211f3a4223ede7236433763b4a46730cb13557", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4373, "~/images/service-single/", 4373, 24, true);
#nullable restore
#line 93 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 4397, item.Image, 4397, 11, false);

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
                                    </div>
                                    <div class=""bottom-info"">
                                        <div class=""text"">
                                            <h4>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</h4>
                                            <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                                        </div>
                                        <div class=""pdf-dwn-area"">
                                            <a href=""#"">
                          ");
            WriteLiteral("                      <i class=\"ti-receipt\"></i>\r\n                                                <h5>");
#nullable restore
#line 104 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                               Write(Model.Services.ElementAt(0).Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <p>");
#nullable restore
#line 105 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                              Write(Model.Services.ElementAt(0).Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 105 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                                                                               Write(Model.Services.ElementAt(0).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </a>
                                        </div>
                                    </div>
                                    <div class=""features-grid clearfix"">
                                        <div class=""grid"">
                                            <div class=""icon"">
                                                <i class=""fi flaticon-house""></i>
                                            </div>
                                            <h3>House protected</h3>
                                            <p>Window at the dull weather</p>
                                        </div>
                                        <div class=""grid"">
                                            <div class=""icon"">
                                                <i class=""fi flaticon-umbrella-1""></i>
                                            </div>
                                            <h3>Helth protected</h3>
            ");
            WriteLiteral(@"                                <p>Window at the dull weather</p>
                                        </div>
                                        <div class=""grid"">
                                            <div class=""icon"">
                                                <i class=""fi flaticon-cost""></i>
                                            </div>
                                            <h3>Small Premium</h3>
                                            <p>Window at the dull weather</p>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 133 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Services\Index.cshtml"
                            
                                
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end service-single-section -->


<!-- start testimonials-section-s2 -->
<section class=""testimonials-section-s2 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""section-title"">
                    <span>Testimonials</span>
                    <h2>What People Says About Us</h2>
                </div>

                <div class=""testimonials-s2-nav"">
                    <div class=""slider-s2-arrows"">
                        <div class=""slider-prev""><i class=""fi flaticon-left-arrow-angle-big-gross-symbol""></i></div>
                        <div class=""slider-next""><i class=""fi flaticon-arrow-angle-pointing-to-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""testimonials");
            WriteLiteral("-slider-holder\">\r\n                    <div class=\"testimonials-slider-s2\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:testimonial-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5441faf211f3a4223ede7236433763b4a46730cb20354", async() => {
            }
            );
            __TestimonialItemViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Services_Index.__Generated__TestimonialItemViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TestimonialItemViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end testimonials-section-s2 -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:testimonial-item")]
        public class __Generated__TestimonialItemViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__TestimonialItemViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("TestimonialItem", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
