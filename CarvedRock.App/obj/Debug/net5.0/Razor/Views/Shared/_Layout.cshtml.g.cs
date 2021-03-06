#pragma checksum "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f5612945a840014cdabea98945dc440bf45c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f5612945a840014cdabea98945dc440bf45c8b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8efb367f238a2f295c677430e1ff18bc9fa2ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline form-inline d-none d-sm-none d-md-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Footwear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f5612945a840014cdabea98945dc440bf45c8b5439", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Carved Rock Fitness</title>
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"" rel=""stylesheet"">

    <link href=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/bootstrap/bootstrap-reboot.min.css"" rel=""stylesheet"">
    <link href=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/bootstrap/bootstrap.css"" rel=""stylesheet"">
    <link href=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/bootstrap/bootstrap-grid.css"" rel=""stylesheet"">
    <link href=""/css/main.css"" rel=""stylesheet"">

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLa");
                WriteLiteral("UAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49\" crossorigin=\"anonymous\"></script>\r\n    <script src=\"https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f5612945a840014cdabea98945dc440bf45c8b7713", async() => {
                WriteLiteral(@"
    <div class=""crf"">
        <!-- NAVIGATION -->
        <nav class=""navbar navbar-expand flex-column flex-md-row header-nav--nav"">
            <div class=""container"">
                <div class=""d-md-flex justify-content-between"">
                    <div class=""navbar-brand d-flex justify-content-between align-items-center"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f5612945a840014cdabea98945dc440bf45c8b8340", async() => {
                    WriteLiteral("<img alt=\"Carved Rock Fitness\" src=\"https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/logos/carved-rock-logo.png\">");
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
                WriteLiteral(@" <button aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"" class=""navbar-toggle"" data-target=""#navbarNav"" data-toggle=""collapse"" type=""button""><span class=""icon-bar""></span><span class=""icon-bar""></span><span class=""icon-bar""></span></button>
                    </div>
                    <div class=""collapse navbar-collapse justify-content-center align-items-center"" id=""navbarNav"">
                        <div class=""header-nav--main"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f5612945a840014cdabea98945dc440bf45c8b10452", async() => {
                    WriteLiteral("\r\n                                <input aria-label=\"Search\" class=\"form-control\" placeholder=\"What can we help you find?\" type=\"search\"> <button class=\"btn btn-default\" type=\"submit\">SEARCH</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <ul class=\"navbar-nav\">\r\n                                <li class=\"nav-item\"><a class=\"nav-link\" href=\"#\">Clothing</a></li>\r\n                                <li class=\"nav-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f5612945a840014cdabea98945dc440bf45c8b12297", async() => {
                    WriteLiteral("Footwear");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#"">Equipment</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#"">Bags &amp; Travel</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#"">Trail Reviews</a></li>
                            </ul>
                        </div>
                        <div class=""header-nav--utilities d-flex align-items-center justify-content-end flex-row-reverse flex-row flex-md-row"">
                            <div class=""account d-flex flex-column"">
                                John Doe <a href=""#"">Log Out</a>
                            </div>
                            <div class=""image""><img alt=""John Doe"" src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/profile-pic.jpg""></div>
                        </div>
                    </div>
                </div>
            </div>
        </nav>


  ");
                WriteLiteral("      ");
#nullable restore
#line 51 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


        <!-- FOOTER -->
        <footer class=""d-flex justify-content-stretch"">
            <div class=""crf-footer--category"">
                <div class=""container"">
                    <div class=""row row d-md-flex justify-content-between flex-sm-column flex-lg-row"">
                        <div class=""crf-footer--links active"">
                            <div class=""crf-footer--header text-primary"">Customer Support</div>
                            <ul>
                                <li><a href=""#"">Contact Us</a></li>
                                <li><a href=""#"">Order Tracker</a></li>
                                <li><a href=""#"">Returns &amp; Refunds</a></li>
                                <li><a href=""#"">Size Guide</a></li>
                                <li><a href=""#"">Store Locator</a></li>
                                <li><a href=""#"">Site Map</a></li>
                            </ul>
                        </div>
                        <div class=""crf-footer--link");
                WriteLiteral(@"s"">
                            <div class=""crf-footer--header text-primary"">Company Info</div>
                            <ul>
                                <li><a href=""#"">About Us</a></li>
                                <li><a href=""#"">Careers</a></li>
                                <li><a href=""#"">Press</a></li>
                                <li><a href=""#"">Sustainability</a></li>
                                <li><a href=""#"">Affiliates</a></li>
                                <li><a href=""#"">Students</a></li>
                                <li><a href=""#"">Mobile Apps</a></li>
                            </ul>
                        </div>
                        <div class=""crf-footer--links"">
                            <div class=""crf-footer--header text-primary"">Privacy &amp; Terms</div>
                            <ul>
                                <li><a href=""#"">Privacy &amp; Security</a></li>
                                <li><a href=""#"">Statement</a></li>
         ");
                WriteLiteral(@"                       <li><a href=""#"">Terms &amp; Conditions</a></li>
                            </ul>
                        </div>
                        <div class=""crf-footer--links crf-footer--social"">
                            <div class=""crf-footer--header text-primary d-lg-block  d-none d-sm-none"">Follow Us</div>
                            <ul class=""d-lg-block  d-none d-sm-none"">
                                <li><a href=""#"" class=""crf-footer--icon twitter""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon facebook""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon pinterest""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon instagram""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon googleplus""></a></li>
                            </ul>
                            <div class=""crf-footer--newsletter"">
                                <div class=""crf-fo");
                WriteLiteral(@"oter--header"">Email Updates</div>
                                <div class=""crf-footer--subheader"">Exclusive sales, special offers, and more.</div>
                                <input type=""text"" class=""form-control"" placeholder=""Enter email address"" />
                                <button class=""btn btn-primary"">Sign up</button>
                            </div>
                        </div>
                        <div class=""crf-footer--links crf-footer-m--social d-block   d-lg-none"">
                            <div class=""crf-footer--header text-primary"">Follow Us</div>
                            <ul>
                                <li><a href=""#"" class=""crf-footer--icon twitter""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon facebook""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon pinterest""></a></li>
                                <li><a href=""#"" class=""crf-footer--icon instagram""></a></li>
                 ");
                WriteLiteral(@"               <li><a href=""#"" class=""crf-footer--icon googleplus""></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""crf-footer--logo d-flex"">
                <div class=""container justify-content-start align-items-center d-flex flex-column"">
                    <img src=""https://www.pluralsight.com/content/dam/pluralsight2/teach/author-tools/carved-rock-fitness/logos/pluralsight-white.png"" />
                    <div>This site is created for demonstrative purposes only and does not offer any real products or services.</div>
                </div>
            </div>
            <div class=""crf-footer--copyright text-primary"">");
                WriteLiteral("@Pluralsight 2018</div>\r\n        </footer>\r\n    </div>\r\n    ");
#nullable restore
#line 128 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
