#pragma checksum "C:\Users\Julio Castro\RiderProjects\PWABlog\PWABlog\Views\Admin\Painel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f09d9c50133ba8a8477ff173a1b03d3ce2896e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Painel), @"mvc.1.0.view", @"/Views/Admin/Painel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f09d9c50133ba8a8477ff173a1b03d3ce2896e", @"/Views/Admin/Painel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c906f599f5ea20069f61f157194e01c171f90b99", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Painel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PWABlog.ViewModels.Admin.AdminPainelViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Painel Administrativo</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                <i class=""fas fa-minus""></i></button>
        </div>
    </div>
    <div class=""card-body"">
        Conteúdo qualquer do painel
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PWABlog.ViewModels.Admin.AdminPainelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
