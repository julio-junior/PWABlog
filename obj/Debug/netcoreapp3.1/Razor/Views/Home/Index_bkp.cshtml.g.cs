#pragma checksum "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfefed21f2c5eb5c51f52fe2a0dd881df1376b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index_bkp), @"mvc.1.0.view", @"/Views/Home/Index_bkp.cshtml")]
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
#line 1 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\_ViewImports.cshtml"
using PWABlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\_ViewImports.cshtml"
using PWABlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
using PWABlog.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfefed21f2c5eb5c51f52fe2a0dd881df1376b0e", @"/Views/Home/Index_bkp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index_bkp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.Home.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- Conteúdo Principal -->\n<div class=\"w3-col l8 s12\">\n    <!-- Postagens -->\n");
#nullable restore
#line 7 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
     foreach (PostagemHomeIndex postagem in @Model.Postagens)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"w3-card-4 w3-margin w3-white\">\n            <img src=\"https://via.placeholder.com/650x200?text=Imagem da Postagem\"");
            BeginWriteAttribute("alt", " alt=\"", 362, "\"", 384, 1);
#nullable restore
#line 10 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
WriteAttributeValue("", 368, postagem.Titulo, 368, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\n            <div class=\"w3-container\">\n                <h3>\n                    <b>");
#nullable restore
#line 13 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                  Write(postagem.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                </h3>\n                <h5>\n                    ");
#nullable restore
#line 16 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
               Write(postagem.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"w3-opacity\">");
#nullable restore
#line 16 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                                                            Write(postagem.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </h5>\n            </div>\n\n            <div class=\"w3-container\">\n                <p>");
#nullable restore
#line 21 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
              Write(postagem.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""w3-row"">
                    <div class=""w3-col m8 s12"">
                        <p>
                            <button class=""w3-button w3-padding-large w3-white w3-border"">
                                <b>READ MORE »</b>
                            </button>
                        </p>
                    </div>
                    <div class=""w3-col m4 w3-hide-small"">
                        <p>
                            <span class=""w3-padding-large w3-right"">
                                <b>Comentários </b> <span class=""w3-tag"">");
#nullable restore
#line 33 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                                                                    Write(postagem.NumeroComentarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                <!--<b>Comments </b> <span class=\"w3-badge\">2</span>-->\n                            </span>\n                        </p>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 41 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<!-- Conteúdo Lateral -->
<div class=""w3-col l4"">
    <!-- Categorias -->
    <div class=""w3-card w3-margin"">
        <div class=""w3-container w3-padding"">
            <h4>Categorias</h4>
        </div>
        <div class=""w3-container w3-white"">
            <p>
");
#nullable restore
#line 53 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                 foreach (CategoriaHomeIndex categoria in @Model.Categorias)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"w3-tag w3-light-grey w3-margin-bottom\">");
#nullable restore
#line 55 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                                                                   Write(categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 56 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </p>
        </div>
    </div>
    
    <!-- Etiquetas -->
    <div class=""w3-card w3-margin"">
        <div class=""w3-container w3-padding"">
            <h4>Etiquetas</h4>
        </div>
        <div class=""w3-container w3-white"">
            <p>
");
#nullable restore
#line 68 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                 foreach (EtiquetaHomeIndex etiqueta in @Model.Etiquetas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"w3-tag w3-light-grey w3-margin-bottom\">");
#nullable restore
#line 70 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                                                                   Write(etiqueta.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 71 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </p>
        </div>
    </div>

    <!-- Postagens Populares -->
    <div class=""w3-card w3-margin"">
        <div class=""w3-container w3-padding"">
            <h4>Postagens Populares</h4>
        </div>
        <ul class=""w3-ul w3-hoverable w3-white"">
");
#nullable restore
#line 82 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
            foreach (PostagemPopularHomeIndex postagemPopular in @Model.PostagensPopulares) {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <li class=\"w3-padding-16\">\n                   <img src=\"https://via.placeholder.com/75/BBC9E3\" alt=\"Image\" class=\"w3-left w3-margin-right\" style=\"width:50px\">\n                   <span class=\"w3-large\">");
#nullable restore
#line 85 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                                     Write(postagemPopular.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\n                   <span>");
#nullable restore
#line 86 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
                    Write(postagemPopular.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n               </li>   \n");
#nullable restore
#line 88 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Home\Index_bkp.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>

    <!-- Sobre Mim -->
    <div class=""w3-card w3-margin w3-margin-top"">
        <div class=""w3-container w3-white"">
            <h4>
                <b>Leonardo de Aguiar</b>
            </h4>
            <p>Descrição sobre mim</p>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.Home.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
