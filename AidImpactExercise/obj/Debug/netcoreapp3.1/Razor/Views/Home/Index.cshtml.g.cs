#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ca7e30f6e162834c12fb115778128e454a103d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ca7e30f6e162834c12fb115778128e454a103d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65554f7e1e08dd9355aa3f1863bd95215b20f977", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to AidMap</h1>
    <p>The first solution that helps you to discover the main french cities</p>

    <div class=""container mt-5"">
        <div class=""row"">
            <div class=""col-md-3"">
                <ul class=""list-group"">

                    <li class=""list-group-item"">
                        <h3>Paris</h3><br />
                        <button type=""button"" class=""paris btn btn-primary text-right"">Afficher</button>
                    </li>
                    <li class=""list-group-item"">
                        <h3>Lyon</h3><br />
                        <button type=""button"" class=""lyon btn btn-primary text-right lyon"">Afficher</button>
                    </li>
                    <li class=""list-group-item"">
                        <h3>Toulouse</h3><br />
                        <button type=""button"" class=""toulouse btn btn-primary text-right toulouse"">Afficher</button>
                    </li>
                <");
            WriteLiteral("/ul>\r\n            </div>\r\n            \r\n            <div class=\"col-md-9\" style=\"height: 500px; width: 1300px;\" id=\"myMap\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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