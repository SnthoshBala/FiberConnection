#pragma checksum "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44434bd9c0cbd9922afa20526b60a137796a757a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offers_OfferDetails), @"mvc.1.0.view", @"/Views/Offers/OfferDetails.cshtml")]
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
#line 1 "D:\Fiber\FiberConnection\Views\_ViewImports.cshtml"
using FiberConnection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Fiber\FiberConnection\Views\_ViewImports.cshtml"
using FiberConnection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44434bd9c0cbd9922afa20526b60a137796a757a", @"/Views/Offers/OfferDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7109f5b7f410635484f8f2fd9658178ff091ebf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Offers_OfferDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiberConnection.FiberConnection.Offer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/unlimited.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block align-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fiber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PlanDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
  
    ViewData["Title"] = "OfferDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .c1 {
        margin: 0 auto; /* Added */
        float: none; /* Added */
        margin-bottom: 10px; /* Added */
    }
</style>
<br />
<h2 class=""text-danger"">Offers</h2>
<hr class=""bg-danger"" />
<div class=""container mt-5 mb-3n c1"">
            <div class=""col-md-4 c1"">
                <div class=""card text-white border-danger bg-dark c1"" style=""width: 18rem;"">
                    <div class=""card-body"">
                        <div class=""text-center"">
                            <h5 class=""card-title""> Offers</h5>
                        </div>
                        <div class=""text-center"">
                            <h6 class=""card-text text-danger""> ");
#nullable restore
#line 24 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Voot));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 24 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                Write(Html.DisplayFor(model => model.Voot));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\"> ");
#nullable restore
#line 28 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Ultra));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 28 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                 Write(Html.DisplayFor(model => model.Ultra));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\"> ");
#nullable restore
#line 32 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Hungamaplay));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 32 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                       Write(Html.DisplayFor(model => model.Hungamaplay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\">  ");
#nullable restore
#line 36 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                           Write(Html.DisplayNameFor(model => model.Lionplay));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 36 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                     Write(Html.DisplayFor(model => model.Lionplay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\">");
#nullable restore
#line 40 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.Netflix));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 40 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                  Write(Html.DisplayFor(model => model.Netflix));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\"> ");
#nullable restore
#line 44 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Hotstar));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 44 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                   Write(Html.DisplayFor(model => model.Hotstar));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\"> ");
#nullable restore
#line 48 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.Others));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : <span class=\"text-white\"> ");
#nullable restore
#line 48 "D:\Fiber\FiberConnection\Views\Offers\OfferDetails.cshtml"
                                                                                                                                  Write(Html.DisplayFor(model => model.Others));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"text-center\">\r\n                            <h6 class=\"card-text text-danger\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44434bd9c0cbd9922afa20526b60a137796a757a12931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" Unlimted</h6>
                        </div>
                        <br />
                        <div class=""text-center"">
                            <h6 class=""card-text text-danger""> 24*7 std/isd Free</h6>
                        </div>
                        <br />
                        <br />
                        <div class=""text-center card-footer border-danger"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44434bd9c0cbd9922afa20526b60a137796a757a14717", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiberConnection.FiberConnection.Offer> Html { get; private set; }
    }
}
#pragma warning restore 1591