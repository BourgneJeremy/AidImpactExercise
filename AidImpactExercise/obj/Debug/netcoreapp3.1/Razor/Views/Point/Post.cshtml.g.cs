#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Point\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4328b8441204d3bd38e8ad0d3af47114db7451b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Point_Post), @"mvc.1.0.view", @"/Views/Point/Post.cshtml")]
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
#line 1 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\_ViewImports.cshtml"
using AidImpactExercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\_ViewImports.cshtml"
using AidImpactExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4328b8441204d3bd38e8ad0d3af47114db7451b1", @"/Views/Point/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65554f7e1e08dd9355aa3f1863bd95215b20f977", @"/Views/_ViewImports.cshtml")]
    public class Views_Point_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AidImpactExercise.Models.Point>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Point\Post.cshtml"
  
    ViewData["Title"] = "Post page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 7 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Point\Post.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Point\Post.cshtml"
Write(Model.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Point\Post.cshtml"
Write(Model.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AidImpactExercise.Models.Point> Html { get; private set; }
    }
}
#pragma warning restore 1591
