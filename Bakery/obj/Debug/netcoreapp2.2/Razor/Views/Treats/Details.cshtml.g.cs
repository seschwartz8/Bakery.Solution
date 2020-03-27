#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5c6c3b261c9ca6b86fa58d7ce44ca577ab2673f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Details), @"mvc.1.0.view", @"/Views/Treats/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Details.cshtml", typeof(AspNetCore.Views_Treats_Details))]
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
#line 6 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c6c3b261c9ca6b86fa58d7ce44ca577ab2673f", @"/Views/Treats/Details.cshtml")]
    public class Views_Treats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(76, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(82, 10, false);
#line 8 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(92, 57, true);
            WriteLiteral(" Details</h1>\n\n<div class=\"content\">\n  <h3>Flavors:</h3>\n");
            EndContext();
#line 12 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
   if (@Model.Flavors.Count == 0)
  {

#line default
#line hidden
            BeginContext(187, 29, true);
            WriteLiteral("    <p>No flavors found!</p>\n");
            EndContext();
#line 15 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(220, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 17 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
   foreach (var join in @Model.Flavors)
  {

#line default
#line hidden
            BeginContext(265, 45, true);
            WriteLiteral("    <div class=\'treat-has-flavor\'>\n      <h4>");
            EndContext();
            BeginContext(311, 95, false);
#line 20 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
     Write(Html.ActionLink($"{join.Flavor.Name}", "Details", "Flavors", new { id = join.Flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(406, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 21 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
       using (Html.BeginForm("RemoveFlavor", "Treats"))
      {
        

#line default
#line hidden
            BeginContext(485, 42, false);
#line 23 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
   Write(Html.Hidden("joinId", @join.FlavorTreatId));

#line default
#line hidden
            EndContext();
            BeginContext(537, 37, false);
#line 24 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
   Write(Html.Hidden("treatId", @join.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(575, 58, true);
            WriteLiteral("        <input type=\"submit\" value=\"Remove\" class=\'btn\'/>\n");
            EndContext();
#line 26 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
      }

#line default
#line hidden
            BeginContext(641, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 28 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(656, 34, true);
            WriteLiteral("</div>\n\n\n<div class=\"links\">\n  <p>");
            EndContext();
            BeginContext(691, 65, false);
#line 33 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Edit treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(756, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(767, 72, false);
#line 34 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Add a flavor", "AddFlavor", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(839, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(850, 69, false);
#line 35 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/Bakery.Solution/Bakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Delete treat", "Delete", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(919, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
