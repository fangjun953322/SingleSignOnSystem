#pragma checksum "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bacd42e26260e6782dc1f708270fe868ef65f774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secure), @"mvc.1.0.view", @"/Views/Home/Secure.cshtml")]
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
#line 1 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\_ViewImports.cshtml"
using StockManagerSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\_ViewImports.cshtml"
using StockManagerSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacd42e26260e6782dc1f708270fe868ef65f774", @"/Views/Home/Secure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc99f78deea24a6aeb02b4395a379fa152f59efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 6 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 8 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 9 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 10 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
#nullable restore
#line 16 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 18 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 19 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 20 "E:\projects\mynet\SingleSignOnSystem\StockManagerSystem\Views\Home\Secure.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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
