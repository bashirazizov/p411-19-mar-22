#pragma checksum "C:\Users\Bashir Azizov\Desktop\p411\p411-19-mar-22\vesper\vesper\Views\Projects\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6147e5e6929486a5360c9e9b8b0d4795ad08df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Search), @"mvc.1.0.view", @"/Views/Projects/Search.cshtml")]
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
#line 1 "C:\Users\Bashir Azizov\Desktop\p411\p411-19-mar-22\vesper\vesper\Views\_ViewImports.cshtml"
using vesper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bashir Azizov\Desktop\p411\p411-19-mar-22\vesper\vesper\Views\_ViewImports.cshtml"
using vesper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6147e5e6929486a5360c9e9b8b0d4795ad08df", @"/Views/Projects/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17897c4fa94152f53af907319263bbc8fc6ab07f", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main id=""main"">
    <section class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h2>Search</h2>
                <ol>
                    <li><a href=""index.html"">Home</a></li>
                    <li>Search</li>
                </ol>
            </div>

        </div>
    </section>

    <section>
        <div class=""container"">
            <input type=""Text"" placeholder=""Search..."" id=""search"" class=""form-control"" />
        </div>
    </section>

    <section id=""portfolio"" class=""portfolio"">
        <div class=""container"">
            <div class=""row portfolio-container"" id=""search-results"">
            </div>
        </div>
    </section>
</main>

<input type=""hidden"" id=""projCount""");
            BeginWriteAttribute("value", " value=\"", 820, "\"", 842, 1);
#nullable restore
#line 30 "C:\Users\Bashir Azizov\Desktop\p411\p411-19-mar-22\vesper\vesper\Views\Projects\Search.cshtml"
WriteAttributeValue("", 828, ViewBag.Count, 828, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
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
