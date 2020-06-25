#pragma checksum "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2bc136d2516249eb4dbe5e3cbabcbe075ffcbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPostagens_Listar), @"mvc.1.0.view", @"/Views/AdminPostagens/Listar.cshtml")]
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
#line 1 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
using PWABlog.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2bc136d2516249eb4dbe5e3cbabcbe075ffcbd", @"/Views/AdminPostagens/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPostagens_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.Admin.AdminPostagensListarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Listagem de Postagens</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i></button>
        </div>
    </div>
    <div class=""card-body"">
        <a class=""btn btn-primary mb-3"" href=""/admin/postagens/criar"">Criar novo Post</a>
        <table class=""table table-bordered"">
            <thead>
            <tr>
                <th>Id</th>
                <th>Titulo</th>
                <th>Autor</th>
                <th>Categoria</th>
                <th>Ações</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                 foreach (PostagemAdminPostagens postagem in @Model.Postagens) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 28 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                       Write(postagem.IdPostagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 29 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                       Write(postagem.TituloPostagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 30 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                       Write(postagem.NomeAutorPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                       Write(postagem.NomeCategoriaPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a class=\"btn btn-primary btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1281, "\"", 1332, 2);
            WriteAttributeValue("", 1288, "/admin/postagens/editar/", 1288, 24, true);
#nullable restore
#line 33 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
WriteAttributeValue("", 1312, postagem.IdPostagem, 1312, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fa fa-edit\"></span> Editar</a>\n                            <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1438, "\"", 1490, 2);
            WriteAttributeValue("", 1445, "/admin/postagens/remover/", 1445, 25, true);
#nullable restore
#line 34 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
WriteAttributeValue("", 1470, postagem.IdPostagem, 1470, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fa fa-trash\"></span> Remover</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 37 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminPostagens\Listar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.Admin.AdminPostagensListarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
