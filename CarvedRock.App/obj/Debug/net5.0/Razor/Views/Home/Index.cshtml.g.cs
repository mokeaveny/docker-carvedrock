#pragma checksum "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf9758d6b5b9079479ae907ab4498eba2ad0192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\_ViewImports.cshtml"
using CarvedRock.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\_ViewImports.cshtml"
using CarvedRock.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf9758d6b5b9079479ae907ab4498eba2ad0192", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8efb367f238a2f295c677430e1ff18bc9fa2ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- MOBILE SEARCH -->\r\n<section class=\"header-nav--search d-block d-sm-block d-md-none\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf9758d6b5b9079479ae907ab4498eba2ad01924019", async() => {
                WriteLiteral("\r\n        <input aria-label=\"Search\" class=\"form-control\" placeholder=\"What can we help you find?\" type=\"search\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</section>

<!-- HEADER -->
<div class=""jumbotron jumbotron-fluid crf-hero d-flex"">
    <div class=""container d-flex flex-column justify-content-center align-items-sm-stretch align-items-md-center"">
        <h1 class=""col-sm-12"">GET A GRIP</h1>
        <h2>20% OFF</h2>
        <p class=""lead"">THROUGHOUT THE SEASON</p>
    </div>
</div>

<!-- SALE BANNER -->
<div class=""container crf-cigar-banner"">
    <div class=""row"">
        <div class=""crf-cigar-banner--container d-flex justify-content-center align-items-center"">
            <img alt=""Brown Boots"" class=""order-sm-0 order-md-0"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/img-brownboots.jpg"">
            <div class=""crf-cigar-banner--text order-sm-2 order-md-1"">
                <div class=""text-light"">Couples retreat weekend</div>
                <div class=""text-secondary"">Save an extra 20%</div>
                <div class=""text-primary"">when you buy 2 pairs of boots</div>
          ");
            WriteLiteral(@"  </div><img alt=""Grey Boots"" class=""order-sm-1 order-md-2"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/img-greyboots.jpg"">
        </div>
    </div>
</div>

<!-- STORIES -->
<div class=""container crf-story"">
    <div class=""row"">
        <div class=""col-lg-3 col-md-6"">
            <a href=""#"">
                <div class=""crf-story--image""><img alt=""Splash Chic"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/story-1.jpg"" /></div>
                <div class=""crf-story--text"">
                    <h3>Splash Chic</h3>
                    <div>Women's Wet Gear</div>
                </div>
            </a>
        </div>
        <div class=""col-lg-3 col-md-6"">
            <a href=""#"">
                <div class=""crf-story--image""><img alt=""Kid Klimbers"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/story-2.jpg"" /></div>
                <div cl");
            WriteLiteral(@"ass=""crf-story--text"">
                    <h3>Kid Klimbers</h3>
                    <div>Children's Gear</div>
                </div>
            </a>
        </div>
        <div class=""col-lg-3 col-md-6"">
            <a href=""#"">
                <div class=""crf-story--image""><img alt=""Pack It In"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/story-4.jpg"" /></div>
                <div class=""crf-story--text"">
                    <h3>Pack It In</h3>
                    <div>Camping Gear</div>
                </div>
            </a>
        </div>
        <div class=""col-lg-3 col-md-6"">
            <a href=""#"">
                <div class=""crf-story--image""><img alt=""Nature's AC"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/story-3.jpg"" /></div>
                <div class=""crf-story--text"">
                    <h3>Nature's AC</h3>
                    <div>Men's Shorts</div>
               ");
            WriteLiteral(@" </div>
            </a>
        </div>
    </div>
</div>

<!-- VISTAS -->
<div class=""container crf-full-banner"">
    <div class=""row"">
        <div class=""col d-md-flex align-items-md-stretch flex-md-nowrap"">
            <div class=""crf-full-banner--image flex-sm-grow-1"">
                <h4 class=""d-lg-none"">Trail Review</h4>
            </div>
            <div class=""crf-full-banner--text d-flex flex-column align-items-center justify-content-center flex-sm-grow-1"">
                <h4>Trail Review</h4>
                <div>Asphalt</div>
                <div>National Park</div>
                <a class=""btn btn-default"" href=""#"">See Review</a>
            </div>
        </div>
    </div>
</div>");
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