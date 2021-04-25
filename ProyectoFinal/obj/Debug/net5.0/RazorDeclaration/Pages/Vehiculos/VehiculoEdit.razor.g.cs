// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Vehiculos
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehiculos/vedit")]
    public partial class VehiculoEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Vehiculos\VehiculoEdit.razor"
       
    gestion_vehicularContext db = new gestion_vehicularContext();
    Vehiculos vehiculo = new Vehiculos();
    int ProvinciaIdUbicacion = 1;
    public int MunicipioIdUbicacion { get; set; }
    public int TipoId { get; set; }
    string mensaje = "No se ha editado ningun Vehiculo.";
    string mensajetest = "";

    public void SearchVehiculo()
    {
        bool result = db.Vehiculos.Any(v => v.Id == vehiculo.Id);
        if (result == true)
        {
            var results = db.Vehiculos.Single(v => v.Id == vehiculo.Id);

            vehiculo.Marca = results.Marca;
            vehiculo.Modelo = results.Modelo;
            vehiculo.Año = results.Año;
            vehiculo.Color = results.Color;
            vehiculo.Precio = results.Precio;
            vehiculo.TipoId = results.TipoId;
            vehiculo.CapacidadDeCarga = results.CapacidadDeCarga;
            vehiculo.Pasajeros = results.Pasajeros;
            vehiculo.Matricula = results.Matricula;
            vehiculo.NroSeguro = results.NroSeguro;
            vehiculo.Latitud = results.Latitud;
            vehiculo.Longitud = results.Longitud;

            mensajetest = "Existe un Vehiculo con la ID en la Base de Datos.";
        }
        else
        {
            mensajetest = "No se encontro Ningun Vehiculo con esa ID en la Base de Datos";
        }
    }

    public void Limpiar()
    {
        vehiculo.Marca = "";
        vehiculo.Modelo = "";
        vehiculo.Año = 2000;
        vehiculo.Color = "";
        vehiculo.Precio = 0;
        vehiculo.TipoId = 1;
        vehiculo.CapacidadDeCarga = 0;
        vehiculo.Pasajeros = 0;
        vehiculo.Matricula = "";
        vehiculo.NroSeguro = "";
        vehiculo.Latitud = 0;
        vehiculo.Longitud = 0;   
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
            if (vehiculo.TipoId != null)
            {
                result.TipoId = vehiculo.TipoId;
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
            vehiculo.VehiculoDisponible = "Si";

            db.SaveChanges();
            Limpiar();
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
