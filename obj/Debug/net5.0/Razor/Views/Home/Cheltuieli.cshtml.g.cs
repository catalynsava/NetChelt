#pragma checksum "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "264e6702411d40de6c2acb223c8acd6cfdd884ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cheltuieli), @"mvc.1.0.view", @"/Views/Home/Cheltuieli.cshtml")]
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
#line 1 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
using NetChelt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264e6702411d40de6c2acb223c8acd6cfdd884ff", @"/Views/Home/Cheltuieli.cshtml")]
    public class Views_Home_Cheltuieli : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetChelt.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
  
    ViewData["Title"] = "Cheltuieli";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>v-ați logat cu succes cu: <br />id=<strong>");
#nullable restore
#line 9 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
                                         Write(UserModel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> cu <br />username=<strong>");
#nullable restore
#line 9 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
                                                                                          Write(UserModel.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> și <br />parola=");
#nullable restore
#line 9 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
                                                                                                                                       Write(UserModel.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 13 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
       var message="Hello, is cheltuieli page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    Message is: <b>");
#nullable restore
#line 14 "C:\code\NetChelt\Views\Home\Cheltuieli.cshtml"
              Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetChelt.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591