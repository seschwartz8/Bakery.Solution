#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0fe063e398347b540c845761357dd83b5996ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 5 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0fe063e398347b540c845761357dd83b5996ab8", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 47, true);
            WriteLiteral("\n<h1>User Accounts</h1>\n\n<div class=\"content\">\n");
            EndContext();
#line 10 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
   if (User.Identity.IsAuthenticated)
  {

#line default
#line hidden
            BeginContext(147, 30, true);
            WriteLiteral("      <p>You are logged in as ");
            EndContext();
            BeginContext(178, 18, false);
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
                         Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(196, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 13 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
       using (Html.BeginForm("LogOff", "Account"))
      {

#line default
#line hidden
            BeginContext(260, 62, true);
            WriteLiteral("          <input type=\"submit\" class=\"btn\" value=\"Log out\" />\n");
            EndContext();
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
      }

#line default
#line hidden
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
       
  }

#line default
#line hidden
            BeginContext(334, 33, true);
            WriteLiteral("</div>\n\n<div class=\"links\">\n  <p>");
            EndContext();
            BeginContext(368, 39, false);
#line 21 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(407, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(418, 34, false);
#line 22 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Index.cshtml"
Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(452, 12, true);
            WriteLiteral("</p>\n</div>\n");
            EndContext();
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
