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
#line 1 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data.AdministracionUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reportes/VehiculosEnMapa")]
    public partial class VehiculosEnMapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Reportes\VehiculosEnMapa.razor"
      
    private Map _map = null;
    //Clase para modelar los datos del Join
    public class VistaVehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public short Año { get; set; }
        public string Color { get; set; }
        public DateTime? FechaInicio { get; set; }
        public float? Latitud { get; set; }
        public float? Longitud { get; set; }
        public string Foto { get; set; }
    }

    List<VistaVehiculos> GetReservaciones()
        {
            var context = new gestion_vehicularContext();

            return context.Reservaciones
                    .Join(
                        context.Vehiculos,
                        r => r.VehiculoId,
                        v => v.Id,
                        (r, v) => new {Reservaciones = r, Vehiculos = v}
                    )
                    .Select(
                        r => new VistaVehiculos{
                            Marca = r.Vehiculos.Marca,
                            Modelo = r.Vehiculos.Modelo,
                            Año = r.Vehiculos.Año,
                            Color = r.Vehiculos.Color,
                            Latitud = r.Vehiculos.Latitud,
                            Longitud = r.Vehiculos.Longitud,
                            Matricula = r.Vehiculos.Matricula,
                            FechaInicio = r.Reservaciones.FechaInicio,
                            Foto = r.Vehiculos.Foto
                        }
                    ).ToList();
        }
        List<Vehiculos> GetVehiculos() => new gestion_vehicularContext().Vehiculos.ToList();


    protected override void OnInitialized() 
        {
            gestion_vehicularContext bd = new gestion_vehicularContext();

            _map = new Map(jsr){
                    Center = new LatLng(18.9f, -70f),
                    Zoom = 7.47f
                };

                _map.OnInitialized += () => {
                    _map.AddLayer(new TileLayer {                
                        UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png",
                        Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors",
                    });
                    foreach(var v in GetVehiculos()){
                    
                        var marker = new Marker(v.Latitud, v.Longitud) {
                            Title = v.Modelo,
                            RiseOnHover = true,
                            Popup = new Popup(){
                                Content = $"{v.Marca} "+
                                            $"{v.Modelo} </br> "+
                                            $"Matricula {v.Matricula} </br> "+
                                            $"Color {v.Color} </br> "+
                                            $"{v.Año} </br></br> "+
                                            $"<img src={v.Foto} asp-append-version='true' width='70' heigth='70'/>"
                                }
                        };

                        marker.OnClick += (InteractiveLayer sender, MouseEvent e) => {
                            
                            //var marker = (Marker) sender;

                            //var Coche = bd.Vehiculos.First(x => x.Id == Convert.ToInt32(marker.Title));
                            

                            //StateHasChanged();
                        };

                        _map.AddLayer(marker);
                    }
                };
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591
