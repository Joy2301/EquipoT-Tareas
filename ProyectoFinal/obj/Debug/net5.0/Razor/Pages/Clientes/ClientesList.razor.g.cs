#pragma checksum "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08402139e403c8f90ed283fb7f01c02a6b17b701"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages.Clientes
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data.AdministracionUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Clientes/cread")]
    public partial class ClientesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Clientes</h1>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered");
            __builder.AddMarkupContent(3, @"<thead><tr><th>Cedula</th>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Correo</th>
            <th>Licencia</th>
            <th>Nacionalidad</th>
            <th>Foto de la persona</th>
            <th>Foto de la licencia</th></tr></thead>
    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 20 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
         foreach (Clientes cl in GetClientes())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 23 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 27 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Licencia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 28 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                     cl.Nacionalidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "src", 
#nullable restore
#line 29 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                              cl.FotoCliente

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "asp-append-version", "true");
            __builder.AddAttribute(28, "width", "100");
            __builder.AddAttribute(29, "heigth", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "src", 
#nullable restore
#line 30 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
                              cl.FotoLicencia

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "asp-append-version", "true");
            __builder.AddAttribute(35, "width", "100");
            __builder.AddAttribute(36, "heigth", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClientesList.razor"
       
    List<Clientes> GetClientes() => new gestion_vehicularContext().Clientes.ToList();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
