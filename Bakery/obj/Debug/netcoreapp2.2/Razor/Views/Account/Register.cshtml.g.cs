#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c77656c35f4115184d1135ff77fc05f6ea86739d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
using Bakery.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77656c35f4115184d1135ff77fc05f6ea86739d", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(79, 59, true);
            WriteLiteral("\n<h1>Register a new user</h1>\n<hr />\n<div class=\"content\">\n");
            EndContext();
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
   using (Html.BeginForm("Register", "Account", FormMethod.Post))
  {
      

#line default
#line hidden
            BeginContext(215, 33, false);
#line 14 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(256, 34, false);
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(298, 35, false);
#line 16 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(341, 38, false);
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(387, 42, false);
#line 18 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(437, 45, false);
#line 19 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
 Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(483, 70, true);
            WriteLiteral("      <input type=\"submit\" value=\"Register\" class=\"btn btn-default\"/>\n");
            EndContext();
#line 21 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Account/Register.cshtml"
  }

#line default
#line hidden
            BeginContext(557, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
