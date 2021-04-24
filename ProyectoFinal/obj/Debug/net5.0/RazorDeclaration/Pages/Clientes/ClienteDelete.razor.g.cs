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
#nullable restore
#line 2 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Clientes/cdel")]
    public partial class ClienteDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "c:\Users\mdela\Desktop\Proyectos\EquipoT-Tareas\ProyectoFinal\Pages\Clientes\ClienteDelete.razor"
       
    gestion_vehicularContext db = new gestion_vehicularContext();
    Clientes cliente = new Clientes();
    string iddes;
    string mensajedes = "No se ha deshabilitado ningun cliente.";
    string iddel;
    string mensajedel = "No se ha deshabilitado ningun cliente.";

    public void DesCliente()
    {
        var result = db.Clientes.Single(v => v.Cedula == iddes);
        if (result != null)
        {
            result.ClienteActivo = "No.";
            db.SaveChanges();
            mensajedes = "Cliente deshabilitado exitosamente.";
        }
        else
        {
            mensajedes = "Error encontrado en la busqueda. Cliente no deshabilitado.";
        }
    }

    public void DelCliente()
    {
        var result = db.Clientes.Single(v => v.Cedula == iddel);
        if (result != null)
        {
            db.Clientes.RemoveRange(result);
            db.SaveChanges();
            mensajedel = "Cliente eliminado exitosamente.";
        }
        else
        {
            mensajedes = "Error encontrado en la busqueda. cliente no Eliminado.";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591