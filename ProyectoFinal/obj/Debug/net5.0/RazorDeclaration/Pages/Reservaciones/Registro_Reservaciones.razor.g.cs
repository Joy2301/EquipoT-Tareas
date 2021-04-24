// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Reservaciones
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
#line 2 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Reservaciones\Registro_Reservaciones.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reservaciones/Registro_Reservaciones")]
    public partial class Registro_Reservaciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Reservaciones\Registro_Reservaciones.razor"
      
    Reservaciones reservacion = new Reservaciones();
    string result = "";

    protected override void OnInitialized() 
    {
      reservacion.FechaInicio = DateTime.Now.Date;
      reservacion.FechaFin = DateTime.Now.Date;
    }

    List<Vehiculos> GetVehiculos()
      {
        gestion_vehicularContext bd = new gestion_vehicularContext();
        return bd.Vehiculos.Where(x=> x.VehiculoDisponible == "Si").ToList();
      }

    List<Clientes> GetClientes()
      {
        gestion_vehicularContext bd = new gestion_vehicularContext();
        return bd.Clientes.ToList();
      }

    async Task Registrar()
    {
      gestion_vehicularContext db = new gestion_vehicularContext();
      var reservaciones1 = db.Reservaciones.Where(x => x.VehiculoId == reservacion.VehiculoId).ToList();

      foreach(var item in reservaciones1){
          if(reservacion.FechaInicio == item.FechaInicio || 
          reservacion.FechaFin == item.FechaFin || 
          reservacion.FechaInicio >= item.FechaInicio && reservacion.FechaInicio <= item.FechaFin ||
          reservacion.FechaFin >= item.FechaInicio && reservacion.FechaFin <= item.FechaFin
          ){
              result = "Vehiculo ocupado en esta fecha";
              return;
          }
      }

      var compare_f = DateTime.Compare(reservacion.FechaInicio, DateTime.Now.Date);
      var compare_f2 = DateTime.Compare(reservacion.FechaInicio, reservacion.FechaFin);
      if(compare_f < 0 || compare_f2 > 0)
      {
          result = "Error en la fecha";
          return;
      }

      var auto = db.Vehiculos.Where(x => x.Id == reservacion.VehiculoId).First();
      var costo = auto.Precio;
      var dias = reservacion.FechaFin.Subtract(reservacion.FechaInicio).TotalDays;
      var resultado = costo * Convert.ToDecimal(dias);

      reservacion.MontoTotal = resultado;
      reservacion.Debe = resultado;
      reservacion.HaPagado = 0.0m;
      reservacion.FacturaPagada = "No";
      reservacion.VehiculoDevuelto = "Si";

      db.Reservaciones.Add(reservacion);
      db.SaveChanges();
      NavigationManager.NavigateTo("/Cobros/Modulo_Cobros");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
