#pragma checksum "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Footwear\QuickOrderConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9ad6e5b5f5d4025632ef8b803050947d9206b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Footwear_QuickOrderConfirmation), @"mvc.1.0.view", @"/Views/Footwear/QuickOrderConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9ad6e5b5f5d4025632ef8b803050947d9206b7", @"/Views/Footwear/QuickOrderConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8efb367f238a2f295c677430e1ff18bc9fa2ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Footwear_QuickOrderConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Guid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Footwear\QuickOrderConfirmation.cshtml"
   
    ViewData["Title"] = "Order Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thanks for your order!</h1>\r\n<h4>Your order Id is: ");
#nullable restore
#line 8 "C:\Users\micha\Documents\Microservices\Docker Projects\CarvedRock.Docker\CarvedRock.App\Views\Footwear\QuickOrderConfirmation.cshtml"
                 Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Guid> Html { get; private set; }
    }
}
#pragma warning restore 1591
