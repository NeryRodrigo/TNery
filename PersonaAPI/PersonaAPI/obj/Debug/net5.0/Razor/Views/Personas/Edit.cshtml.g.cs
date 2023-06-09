#pragma checksum "C:\Users\Rody\source\repos\PersonaAPI\PersonaAPI\Views\Personas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8492ad8bc2c009ee96cad3c63658e25fcbbe376f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Edit), @"mvc.1.0.view", @"/Views/Personas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8492ad8bc2c009ee96cad3c63658e25fcbbe376f", @"/Views/Personas/Edit.cshtml")]
    public class Views_Personas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonaAPI.Models.Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rody\source\repos\PersonaAPI\PersonaAPI\Views\Personas\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Persona</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""nombre_completo"" class=""control-label""></label>
                <input asp-for=""nombre_completo"" class=""form-control"" />
                <span asp-validation-for=""nombre_completo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""nro_documento"" class=""control-label""></label>
                <input asp-for=""nro_documento"" class=""form-control"" />
                <span asp-validation-for=""nro_documento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""correo_electronico"" class=""control-label""></label>
                <input asp-for=""correo_electronico");
            WriteLiteral(@""" class=""form-control"" />
                <span asp-validation-for=""correo_electronico"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""telefono"" class=""control-label""></label>
                <input asp-for=""telefono"" class=""form-control"" />
                <span asp-validation-for=""telefono"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""fecha_nacimiento"" class=""control-label""></label>
                <input asp-for=""fecha_nacimiento"" class=""form-control"" />
                <span asp-validation-for=""fecha_nacimiento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Rody\source\repos\PersonaAPI\PersonaAPI\Views\Personas\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonaAPI.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
