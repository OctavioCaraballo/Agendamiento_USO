#pragma checksum "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3573ee2dec2706cd72b67e80d872efae9dcdfa71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgendamientoIPS.App.Frontend.Pages.Encuestas.Pages_Encuestas_Index), @"mvc.1.0.razor-page", @"/Pages/Encuestas/Index.cshtml")]
namespace AgendamientoIPS.App.Frontend.Pages.Encuestas
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
#line 1 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/_ViewImports.cshtml"
using AgendamientoIPS.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
using AgendamientoIPS.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3573ee2dec2706cd72b67e80d872efae9dcdfa71", @"/Pages/Encuestas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685192e0f80cf74fb7f7a798cd8cbff867f390d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Encuestas_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
  
    ViewData["Title"] = "Encuestas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<table style=\"width: 100%;\">\r\n    <tr style=\"width: 100%;\">\r\n        <td style=\"width: 80%;\"><h1>Listado de Encuestas</h1></td>\r\n        <td style=\"width: 20%;\" text-align=\"right\";>\r\n");
#nullable restore
#line 12 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3573ee2dec2706cd72b67e80d872efae9dcdfa715997", async() => {
                WriteLiteral("Nueva Encuesta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </td>
    </tr>
</table>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Antecedentes Médicos</th>
            <th style=""width: 20%;"" scope=""col"">Motivo de Consulta</th>
            <th scope=""col"">Observaciones</th>
            <th style=""width: 20%;"" scope=""col"">Acciones</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
         foreach (var encuesta in Model.encuestas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
               Write(encuesta.AntecedentesMedicos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width: 20%;\">");
#nullable restore
#line 34 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
                                   Write(encuesta.MotivoConsulta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
               Write(encuesta.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width: 20%;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3573ee2dec2706cd72b67e80d872efae9dcdfa719227", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
                                                                             WriteLiteral(encuesta.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3573ee2dec2706cd72b67e80d872efae9dcdfa7111853", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
                                                                              WriteLiteral(encuesta.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
                    }                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "/home/p4t0/Documents/MisiónTIC2022/AgendamientoIPS/Agendamiento_NOPOR/AgendamientoIPS.App.Frontend/Pages/Encuestas/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendamientoIPS.App.Frontend.Pages.Encuestas.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Encuestas.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendamientoIPS.App.Frontend.Pages.Encuestas.IndexModel>)PageContext?.ViewData;
        public AgendamientoIPS.App.Frontend.Pages.Encuestas.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
