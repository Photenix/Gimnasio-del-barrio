#pragma checksum "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35b7f0238ad8e9484494d7f81d0f5d5e04cfb0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes.Pages_UsuarioRecurrentes_Details), @"mvc.1.0.razor-page", @"/Pages/UsuarioRecurrentes/Details.cshtml")]
namespace GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes
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
#line 1 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\_ViewImports.cshtml"
using GimMiBarrio.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c35b7f0238ad8e9484494d7f81d0f5d5e04cfb0d", @"/Pages/UsuarioRecurrentes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e551ac2887d554a063fb8bc0cf7f3d5b0a4c3bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UsuarioRecurrentes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Datos Detallados de Usuario Recurrente ");
#nullable restore
#line 6 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
                                      Write(Model.usuarioRecurrente.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
                                                                              Write(Model.usuarioRecurrente.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    ID: ");
#nullable restore
#line 8 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
   Write(Model.usuarioRecurrente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    IDENTIFICACIÓN: ");
#nullable restore
#line 11 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
               Write(Model.usuarioRecurrente.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    NOMBRES: ");
#nullable restore
#line 14 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
        Write(Model.usuarioRecurrente.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    APELLIDOS: ");
#nullable restore
#line 17 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
          Write(Model.usuarioRecurrente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ESTADO: ");
#nullable restore
#line 20 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
       Write(Model.usuarioRecurrente.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    FECHA DE INGRESO: ");
#nullable restore
#line 23 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
                 Write(Model.usuarioRecurrente.FechaIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    PESO INICIAL: ");
#nullable restore
#line 26 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
             Write(Model.usuarioRecurrente.PesoInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    PESO ACTUAL: ");
#nullable restore
#line 29 "C:\Gimnasio\GimMiBarrio.App\GimMiBarrio.App.Presentacion\Pages\UsuarioRecurrentes\Details.cshtml"
            Write(Model.usuarioRecurrente.PesoActual);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c35b7f0238ad8e9484494d7f81d0f5d5e04cfb0d6802", async() => {
                WriteLiteral("Volver a la Lista de Usuarios Recurrente.. ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes.DetailsModel>)PageContext?.ViewData;
        public GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591