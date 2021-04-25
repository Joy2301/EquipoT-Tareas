// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Clientes
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
#line 2 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Clientes/cedit")]
    public partial class ClienteEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteEdit.razor"
       
    gestion_vehicularContext db = new gestion_vehicularContext();
    Clientes cliente = new Clientes();
    string mensaje = "No se ha editado ningun cliente.";
    string mensajetest = "";

    public void SearchCliente()
    {
        bool result = db.Clientes.Any(v => v.Id == cliente.Id);
        if (result == true)
        {
            var results = db.Clientes.Single(v => v.Id == cliente.Id);

            cliente.Cedula = results.Cedula;
            cliente.Nombre = results.Nombre;
            cliente.Apellido = results.Apellido;
            cliente.Correo = results.Correo;
            cliente.Nacionalidad = results.Cedula;
            cliente.Licencia = results.Licencia;
            cliente.TipoSangreId = results.TipoSangreId;

            mensajetest = "Existe un cliente con la ID en la Base de Datos.";
        }
        else
        {
            mensajetest = "No se encontro Ningun cliente con esa ID en la Base de Datos";
        }
    }

    public void Limpiar()
    {
        cliente.Cedula = "";
        cliente.Nombre = "";
        cliente.Apellido = "";
        cliente.Correo = "";
        cliente.Nacionalidad = "";
    }

    public void UpdateCliente()
    {
        var result = db.Clientes.Single(v => v.Id == cliente.Id);
        if (result != null)
        {
            if (cliente.Cedula != null)
            {
                result.Cedula = cliente.Cedula;
            }
            if (cliente.Nombre != null)
            {
                result.Nombre = cliente.Nombre;
            }
            if (cliente.Apellido != null)
            {
                result.Apellido = cliente.Apellido;
            }
            if (cliente.Correo != null)
            {
                result.Correo = cliente.Correo;
            }
            if (cliente.Licencia != null)
            {
                result.Licencia = cliente.Licencia;
            }
            if (cliente.Nacionalidad != null)
            {
                result.Nacionalidad = cliente.Nacionalidad;
            }
            if (cliente.TipoSangreId != null)
            {
                result.TipoSangreId = cliente.TipoSangreId;
            }
            if (cliente.FotoCliente != null)
            {
                result.FotoCliente = cliente.FotoCliente;
            }
            if (cliente.FotoLicencia != null)
            {
                result.FotoLicencia = cliente.FotoLicencia;
            }
            cliente.ClienteActivo = "Si";

            db.SaveChanges();
            mensaje = "Caso editado exitosamente.";
            Limpiar();
        }
        else
        {
            mensaje = "Error encontrado en la busqueda. Cliente no encontrado.";
        }
    }

    private async Task InputImageCliente(InputFileChangeEventArgs e)
    {
        var format = "image/jpg";

        var resizedImage = await e.GetMultipleFiles()[0].RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedImage.Size];
        await resizedImage.OpenReadStream().ReadAsync(buffer);

        var imageUri = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

        cliente.FotoCliente = imageUri;
    }
    private async Task InputImageLicencia(InputFileChangeEventArgs e)
    {
        var format = "image/jpg";

        var resizedImage = await e.GetMultipleFiles()[0].RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedImage.Size];
        await resizedImage.OpenReadStream().ReadAsync(buffer);

        var imageUri = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

        cliente.FotoLicencia = imageUri;
    }

    public List<Tiposangre> GetTiposSangre()
    {
        gestion_vehicularContext context = new gestion_vehicularContext();

        var tipos = context.Tiposangre.ToList();

        return tipos;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
