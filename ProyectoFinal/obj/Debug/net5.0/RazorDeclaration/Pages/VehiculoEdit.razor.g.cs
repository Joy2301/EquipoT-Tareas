// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 2 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vedit")]
    public partial class VehiculoEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\VehiculoEdit.razor"
       
    gestion_vehicularContext db = new gestion_vehicularContext();
    Vehiculos vehiculo = new Vehiculos();
    int ProvinciaIdUbicacion = 1;
    public int MunicipioIdUbicacion { get; set; }
    public int TipoId { get; set; }
    string mensaje = "No se ha editado ningun Vehiculo.";
    string mensajetest = "";

    public void SearchVehiculo()
    {
        var result = db.Vehiculos.Single(v => v.Id == vehiculo.Id);
        if (result != null)
        {
            mensajetest = "Existe un Vehiculo con la ID en la Base de Datos.";
        }
        else
        {
            mensajetest = "No se encontro Ningun Vehiculo con esa ID en la Base de Datos";
        }
    }

    public void UpdateVehiculo()
    {
        var result = db.Vehiculos.Single(v => v.Id == vehiculo.Id);
        if (result != null)
        {
            if (vehiculo.Marca != null)
            {
                result.Marca = vehiculo.Marca;
            }
            if (vehiculo.Modelo != null)
            {
                result.Modelo = vehiculo.Modelo;
            }
            if (vehiculo.Año != null)
            {
                result.Año = vehiculo.Año;
            }
            if (vehiculo.Color != null)
            {
                result.Color = vehiculo.Color;
            }
            if (vehiculo.Precio != null)
            {
                result.Precio = vehiculo.Precio;
            }
            if (vehiculo.Tipo != null)
            {
                result.Tipo = vehiculo.Tipo;
            }
            if (vehiculo.CapacidadDeCarga != null)
            {
                result.CapacidadDeCarga = vehiculo.CapacidadDeCarga;
            }
            if (vehiculo.Pasajeros != null)
            {
                result.Pasajeros = vehiculo.Pasajeros;
            }
            if (vehiculo.NroSeguro != null)
            {
                result.NroSeguro = vehiculo.NroSeguro;
            }
            if (vehiculo.Foto != null)
            {
                result.Foto = vehiculo.Foto;
            }
            if (vehiculo.Latitud != null)
            {
                result.Latitud = vehiculo.Latitud;
            }
            if (vehiculo.Longitud != null)
            {
                result.Longitud = vehiculo.Longitud;
            }
            if (vehiculo.VehiculoDisponible != null)
            {
                result.VehiculoDisponible = vehiculo.VehiculoDisponible;
            }
            db.SaveChanges();
            mensaje = "Caso Robo editado exitosamente.";
        }
        else
        {
            mensaje = "Error encontrado en la busqueda. Vehiculo no encontrado.";
        }
    }

    private async Task InputImage(InputFileChangeEventArgs e)
    {
        var format = "image/jpg";

        var resizedImage = await e.GetMultipleFiles()[0].RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedImage.Size];
        await resizedImage.OpenReadStream().ReadAsync(buffer);

        var imageUri = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

        vehiculo.Foto = imageUri;
    }

    public class VistaMunicipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }
    public List<Provincias> GetProvincias()
    {
        gestion_vehicularContext context = new gestion_vehicularContext();

        var provincias = context.Provincias.ToList();

        return provincias;
    }
    public List<TipoVehiculo> GetTipos()
    {
        gestion_vehicularContext context = new gestion_vehicularContext();

        var tipos = context.TipoVehiculo.ToList();

        return tipos;
    }

    List<VistaMunicipios> GetMunicipios()
    {
        gestion_vehicularContext context = new gestion_vehicularContext();

        return context.Municipios
        .Join(
            context.Provincias,
            m => m.ProvinciaId,
            p => p.Id,
            (m, p) => new { Municipios = m, Provincias = p }
        )
        .Where(All => All.Municipios.ProvinciaId == ProvinciaIdUbicacion)
        .Select(
            m => new VistaMunicipios
            {
                Id = m.Municipios.Id,
                Nombre = m.Municipios.Nombre,
                Latitud = m.Municipios.Latitud,
                Longitud = m.Municipios.Longitud
            }
        ).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
