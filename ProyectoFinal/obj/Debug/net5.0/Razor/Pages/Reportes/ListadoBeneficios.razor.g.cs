#pragma checksum "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2822219739fead74ac2b7b7b3d16548d4b3ca4c"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages.Reportes
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data.AdministracionUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reportes/ListadoBeneficios")]
    public partial class ListadoBeneficios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
 if (Usuario.correo != null && Usuario.contraseña != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<h1 class=\"display-6\">Reporte - ListadoBeneficios</h1>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(3, "<p>\r\n            Estos son los beneficios generados por cada vehiculo\r\n        </p>\r\n        <br>\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "submit");
            __builder.AddAttribute(6, "value", "Imprimir");
            __builder.AddAttribute(7, "class", "btn btn-secondary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                                                                                  Imprimir

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        <br><br>\r\n\r\n        ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "<thead><tr><th>Datos</th>\r\n                    <th># de Veces reservado</th>\r\n                    <th>Beneficio Generado</th></tr></thead>\r\n            ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 26 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                 foreach (var r in GetBeneficios())
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                                 r.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 30 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                                 r.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 31 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                                 r.Beneficio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, @"<div class=""container""><h1 class=""display-6"">Debes Iniciar Sesion con un correo valido para Vizualizar el contenido</h1>
        <br>
        <p>
            Ya tienes una cuenta? Inicia Sesion
        </p>
            <a href=""/Cuentas/Login"">Iniciar sesion</a></div>");
#nullable restore
#line 49 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ListadoBeneficios.razor"
      
    Usuario us = new Usuario();
    public string correo { get; set; } = null;
    public string contraseña { get; set; } = null;

    //static List<Usuarios> GetUsuarioActual => new gestion_vehicularContext().Usuarios.Where(u => u.Correo == correo && u.Clave == contraseña).ToList();
    
    public void ConsultarUsuario()
    {
    }
    static List<Usuarios> GetReservaciones()
    {
        var context = new gestion_vehicularContext();

        return context.Usuarios.Where(u => u.Correo == Usuario.correo && u.Clave == Usuario.contraseña).ToList();
    }
    bool ExisteRegistro = GetReservaciones().Any(u => u.Correo == Usuario.correo && u.Clave == Usuario.contraseña);
    public class VistaVehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public short Año { get; set; }
        public string Color { get; set; }
        public decimal Beneficio { get; set; }
        public int Count { get; set; }
    }

        List<VistaVehiculos> GetBeneficios()
            {
                var context = new gestion_vehicularContext();

                return context.Reservaciones
                        .Join(
                            context.Vehiculos,
                            r => r.VehiculoId,
                            v => v.Id,
                            (r, v) => new {Reservaciones = r, Vehiculos = v}
                        )
                        .Where(All => All.Reservaciones.FacturaPagada == "No")
                        .Select(
                            r => new VistaVehiculos{
                                Matricula = r.Vehiculos.Matricula + " - " + r.Vehiculos.Marca+ " " + r.Vehiculos.Modelo + " - " + r.Vehiculos.Año+ " - " + r.Vehiculos.Color,
                                Beneficio = r.Reservaciones.HaPagado
                            }
                        )
                        .GroupBy(g => g.Matricula)
                        .Select(g => new VistaVehiculos {
                            Matricula = g.Key,
                            Count = g.Count(),
                            Beneficio = g.Sum(c => c.Beneficio)
                        })
                        .ToList();
            }

        async Task Imprimir()
        {
            await JsRuntime.InvokeVoidAsync("imprimir");
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
