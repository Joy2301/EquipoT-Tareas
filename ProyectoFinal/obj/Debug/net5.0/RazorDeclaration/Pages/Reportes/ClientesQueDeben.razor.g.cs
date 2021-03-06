// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Reportes
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data.AdministracionUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reportes/ClientesQueDeben")]
    public partial class ClientesQueDeben : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\ClientesQueDeben.razor"
      

    
    public class VistaClientes
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Monto { get; set; }
    }

    List<VistaClientes> GetReservaciones()
        {
            var context = new gestion_vehicularContext();

            return context.Reservaciones
                    .Join(
                        context.Clientes,
                        r => r.ClienteId,
                        c => c.Id,
                        (r, c) => new {Reservaciones = r, Clientes = c}
                    )
                    .Where(All => All.Reservaciones.FacturaPagada == "No")
                    .Select(
                        r => new VistaClientes{
                            Cedula = r.Clientes.Cedula + " - " + r.Clientes.Nombre + " " + r.Clientes.Apellido,
                            Monto = r.Reservaciones.Debe
                        }
                    )
                    .GroupBy(g => g.Cedula)
                    .Select(g => new VistaClientes {
                        Cedula = g.Key,
                        Monto = g.Sum(c => c.Monto)
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
