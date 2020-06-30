#pragma checksum "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ffc4992ca07d63edd02034672e248e8048f7d5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ffc4992ca07d63edd02034672e248e8048f7d5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65554f7e1e08dd9355aa3f1863bd95215b20f977", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AidImpactExercise.Models.Point>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success ml-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Point", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
  
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
                        <button type=""button"" class=""paris btn btn-primary text-right"">Display</button>
                    </li>
                    <li class=""list-group-item"">
                        <h3>Lyon</h3><br />
                        <button type=""button"" class=""lyon btn btn-primary text-right lyon"">Display</button>
                    </li>
                    <li class=""list-group-item"">
                        <h3>Toulouse</h3><br />
                        <button type=""button"" class=""toulouse btn btn-primary text-right toulouse"">Display</button>
                    </li>
");
#nullable restore
#line 27 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
                     foreach (var point in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <h3>");
#nullable restore
#line 30 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
                       Write(point.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><br />\r\n                        <p>Longitude : ");
#nullable restore
#line 31 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
                                  Write(point.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Latitude : ");
#nullable restore
#line 32 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
                                 Write(point.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1441, "\'", 1504, 5);
            WriteAttributeValue("", 1451, "displayCustomPoint(", 1451, 19, true);
#nullable restore
#line 33 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
WriteAttributeValue("", 1470, point.Longitude, 1470, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1486, ",", 1486, 1, true);
#nullable restore
#line 33 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1487, point.Latitude, 1488, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1503, ")", 1503, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary text-right\">Display</button>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ffc4992ca07d63edd02034672e248e8048f7d59110", async() => {
                WriteLiteral("\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-outline-secondary\">Delete</button>\n\t\t\t\t\t    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1622, Url.Action("Delete", "Point", point.Id), 1622, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a class=\"btn-outline-info mt-1\"");
            BeginWriteAttribute("href", " href=\"", 1832, "\"", 1960, 1);
#nullable restore
#line 37 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
WriteAttributeValue("", 1839, Url.Action("Modify", "Point", new Point() { Name = point.Name, Longitude = point.Longitude, Latitude = point.Latitude }), 1839, 121, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Modify</a>\r\n                    </li>\n");
#nullable restore
#line 39 "C:\Users\Bourgne\source\repos\AidImpactExercise\AidImpactExercise\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"col-md-9\" style=\"height: 500px; width: 1300px;\" id=\"myMap\">\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ffc4992ca07d63edd02034672e248e8048f7d512346", async() => {
                WriteLiteral("Create a new point");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AidImpactExercise.Models.Point>> Html { get; private set; }
    }
}
#pragma warning restore 1591
