#pragma checksum "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe8e2b4735ab8a4a318427e6f317ffb7200c758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControleDeAcesso_Registrar), @"mvc.1.0.view", @"/Views/ControleDeAcesso/Registrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe8e2b4735ab8a4a318427e6f317ffb7200c758", @"/Views/ControleDeAcesso/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_ControleDeAcesso_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.ControleDeAcesso.ControleDeAcessoRegistrarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-body login-card-body\">\n        <p class=\"login-box-msg\">Registrar usuário</p>\n\n");
#nullable restore
#line 7 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
         if (@Model.ErrosRegistro != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible\">\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                <h5><i class=\"icon fas fa-ban\"></i> Erro!</h5>\n");
#nullable restore
#line 11 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
                 foreach (var erro in @Model.ErrosRegistro) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
               Write(erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n");
#nullable restore
#line 13 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 15 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 17 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
         if (@Model.Erro != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible\">\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                <h5><i class=\"icon fas fa-ban\"></i> Erro!</h5>\n                ");
#nullable restore
#line 21 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
           Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 23 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fe8e2b4735ab8a4a318427e6f317ffb7200c7586191", async() => {
                WriteLiteral(@"
            <div class=""form-group mb-3"">
                <label for=""apelido"">Apelido</label>
                <input id=""apelido"" name=""apelido"" type=""text"" class=""form-control"">
            </div>


            <div class=""form-group mb-3"">
                <label for=""email"">E-mail</label>
                <input id=""email"" name=""email"" type=""email"" class=""form-control"">
            </div>

            <div class=""form-group mb-3"">
                <label for=""senha"">Senha</label>
                <input id=""senha"" name=""senha"" type=""password"" class=""form-control"">
            </div>

            <div class=""form-group mb-3"">
                <label for=""token"">Token</label>
                <input id=""token"" name=""token"" type=""text"" class=""form-control"">
            </div>

            <div class=""form-group mb-3"">
                <button type=""submit"" class=""btn btn-primary btn-block"">Registrar</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
AddHtmlAttributeValue("", 957, Url.RouteUrl("controleDeAcesso", new {action = "Registrar"}), 957, 61, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        \n        <p class=\"mb-0\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 2034, "\"", 2098, 1);
#nullable restore
#line 53 "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\ControleDeAcesso\Registrar.cshtml"
WriteAttributeValue("", 2041, Url.RouteUrl("controleDeAcesso", new {Action = "Login"}), 2041, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">Voltar ao login</a>\n        </p>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.ControleDeAcesso.ControleDeAcessoRegistrarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
