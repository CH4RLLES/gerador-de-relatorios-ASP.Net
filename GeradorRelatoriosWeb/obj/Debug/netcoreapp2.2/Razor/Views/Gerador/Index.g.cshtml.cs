#pragma checksum "D:\Source\Repos\gerador\GeradorRelatoriosWeb\Views\Gerador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb9ef792cd712218f86fb760cccc074a802e564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gerador_Index), @"mvc.1.0.view", @"/Views/Gerador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gerador/Index.cshtml", typeof(AspNetCore.Views_Gerador_Index))]
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
#line 1 "D:\Source\Repos\gerador\GeradorRelatoriosWeb\Views\_ViewImports.cshtml"
using GeradorRelatoriosWeb;

#line default
#line hidden
#line 2 "D:\Source\Repos\gerador\GeradorRelatoriosWeb\Views\_ViewImports.cshtml"
using GeradorRelatoriosWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb9ef792cd712218f86fb760cccc074a802e564", @"/Views/Gerador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c665c84a10f7912f283f84173066caa367402e0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Gerador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuarioLogado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Source\Repos\gerador\GeradorRelatoriosWeb\Views\Gerador\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutLogado.cshtml";

#line default
#line hidden
            BeginContext(116, 17, true);
            WriteLiteral("\r\n<h1>Bem vindo, ");
            EndContext();
            BeginContext(134, 10, false);
#line 7 "D:\Source\Repos\gerador\GeradorRelatoriosWeb\Views\Gerador\Index.cshtml"
          Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(144, 62, true);
            WriteLiteral("!</h1>\r\n<h4> Selecione no menu, o relatório desejado.</h4>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuarioLogado> Html { get; private set; }
    }
}
#pragma warning restore 1591
