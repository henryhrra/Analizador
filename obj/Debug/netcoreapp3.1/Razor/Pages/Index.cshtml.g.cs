#pragma checksum "C:\Users\henry\Desktop\Analizador\Analizador\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c63f9e0ee47edf616100f6b0679203fea9882b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Analizador.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Analizador.Pages
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
#line 1 "C:\Users\henry\Desktop\Analizador\Analizador\Pages\_ViewImports.cshtml"
using Analizador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c63f9e0ee47edf616100f6b0679203fea9882b1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70efda3cb07ab4ee4d4976becd2eec035014d241", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\henry\Desktop\Analizador\Analizador\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""contenedor"">
    <div>
        <div class=""baner"">
            <h1> Analizador de Texto </h1>
            <input class=""form-control"" id=""string"" type=""text"" />
            <button id=""Analizer""> Analizar </button>
        </div>
        <div class=""Resultados"">
            <div style=""display:flex; height:50%;"">
                <div class=""contadores""><label>Consonantes = </label><label id=""con""> 0</label></div>
                <div class=""contadores""><label>Vocales = </label><label id=""voc""> 0</label></div>
                <div class=""contadores""><label>Mayúsculas = </label><label id=""may""> 0</label></div>
                <div class=""contadores""><label>Minúsculas = </label><label id=""min""> 0</label></div>
            </div>
            <div style=""display:flex; height:50%;"">
                <div class=""contadores""><label>Números = </label><label id=""nun""> 0</label></div>
                <div class=""contadores""><label>Otros = </label><label id=""oto""> 0</label></div>
         ");
            WriteLiteral("       <div class=\"contadores\"><label>Palabras = </label><label id=\"pal\"> 0</label></div>\r\n            </div>          \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
