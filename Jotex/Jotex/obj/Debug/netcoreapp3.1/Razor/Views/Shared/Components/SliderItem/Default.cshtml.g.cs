#pragma checksum "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3093c30c5f452f028d9271ca4fc72546c83bbd4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SliderItem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SliderItem/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3093c30c5f452f028d9271ca4fc72546c83bbd4f", @"/Views/Shared/Components/SliderItem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79ad419387654aae9503df92865c496db1ad093", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SliderItem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SliderItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!-- start of hero slider-->\r\n<section class=\"hero-slider hero-style-1\">\r\n    <div class=\"bottom-links\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3093c30c5f452f028d9271ca4fc72546c83bbd4f4111", async() => {
                WriteLiteral("\r\n                <i class=\"fi flaticon-money-bag\"></i>\r\n                <h4>Make a Claim</h4>\r\n                <p>You can claim your money</p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3093c30c5f452f028d9271ca4fc72546c83bbd4f5680", async() => {
                WriteLiteral("\r\n                <i class=\"fi flaticon-agent\"></i>\r\n                <h4>Find An Agent</h4>\r\n                <p>Want an agent?</p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"swiper-container\">\r\n        <div class=\"swiper-wrapper\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide\">\r\n                    <div class=\"slide-inner slide-bg-image\"");
            BeginWriteAttribute("style", " style=\"", 894, "\"", 952, 4);
            WriteAttributeValue("", 902, "background-image:", 902, 17, true);
            WriteAttributeValue(" ", 919, "url(uploads/slider/", 920, 20, true);
#nullable restore
#line 29 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
WriteAttributeValue("", 939, item.Image, 939, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 950, ");", 950, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"container\">\r\n                            <div data-swiper-parallax=\"300\" class=\"slide-title\">\r\n                                <h2>");
#nullable restore
#line 32 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                            <div data-swiper-parallax=\"400\" class=\"slide-text\">\r\n                                <p>");
#nullable restore
#line 35 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
                              Write(item.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"clearfix\"></div>\r\n                            <div data-swiper-parallax=\"500\" class=\"slide-btns\">\r\n");
#nullable restore
#line 39 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
                                 if (!string.IsNullOrEmpty(item.EndPoint))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1635, "\"", 1656, 1);
#nullable restore
#line 41 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
WriteAttributeValue("", 1642, item.EndPoint, 1642, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"theme-btn\">");
#nullable restore
#line 41 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
                                                                          Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 42 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- end slide-inner -->\r\n                </div>\r\n");
#nullable restore
#line 48 "C:\Users\mamma\Desktop\Insurance\Jotex\Jotex\Views\Shared\Components\SliderItem\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <!-- end swiper-wrapper -->
        <!-- swipper controls -->
        <div class=""swiper-pagination""></div>
        <div class=""pagi"">
            <div class=""swiper-button-next""></div>
            <div class=""swiper-button-prev""></div>
        </div>
    </div>
</section>
<!-- end of hero slider -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SliderItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
