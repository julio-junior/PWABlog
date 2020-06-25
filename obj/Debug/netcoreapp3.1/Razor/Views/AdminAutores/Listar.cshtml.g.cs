#pragma checksum "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b8159292d01c6c9433cd8ce11530f2d452e999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminAutores_Listar), @"mvc.1.0.view", @"/Views/AdminAutores/Listar.cshtml")]
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
#line 1 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
using PWABlog.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b8159292d01c6c9433cd8ce11530f2d452e999", @"/Views/AdminAutores/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminAutores_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.Admin.AdminAutoresListarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Listagem de Autores</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i></button>
        </div>
    </div>
    <div class=""card-body"">
        <a class=""btn btn-primary mb-3"" href=""/admin/autores/criar"">Criar nova Autor</a>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
             foreach (AutorAdminAutores autor in @Model.Autores)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 27 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
                   Write(autor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
                   Write(autor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-primary btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1102, 2);
            WriteAttributeValue("", 1071, "/admin/autores/editar/", 1071, 22, true);
#nullable restore
#line 30 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
WriteAttributeValue("", 1093, autor.Id, 1093, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i> Editar</a>\n                        <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1198, "\"", 1237, 2);
            WriteAttributeValue("", 1205, "/admin/autores/remover/", 1205, 23, true);
#nullable restore
#line 31 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
WriteAttributeValue("", 1228, autor.Id, 1228, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i> Remover</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 34 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\AdminAutores\Listar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.Admin.AdminAutoresListarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
