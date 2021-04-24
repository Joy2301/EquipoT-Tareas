// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Cuentas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cuentas/GestionUsuarios")]
    public partial class GestionUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "c:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\ProyectoFinal\Pages\Cuentas\GestionUsuarios.razor"
      
    public string Correo { get; set; }
    public string EstadoUsuario { get; set; } = "";
    public void CrearAdministrador()
    {
        if (Correo.Length > 0)
        {
            var context = new gestion_vehicularContext();
            bool ExisteRegistro = context.Usuarios.Any(u => u.Correo == Correo);
            if (ExisteRegistro == true)
            {
                var CorreUsuario = context.Usuarios.Where(u => u.Correo == Correo).FirstOrDefault(); //consulto por Correo en la tabla Usuarios

                CorreUsuario.RolId = 1; //Actualizo el Rol del usuario
                context.SaveChanges(); //Guardo los cambios
                Correo = "";
                EstadoUsuario = $"El usuario {Correo} ahora es un administrador";
            }
            else
            {
                EstadoUsuario = "El Correo ingresado no fue encontrado";
            }
        }
        else
        {
            EstadoUsuario = "No puede dejar el campo en blanco";
        }
        
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
