#pragma checksum "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "994a283fdac1b55ca5ac90c486b2282be7fa77b1"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Tarea_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Tarea_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Tarea_7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
using Tarea_7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DropVacuna")]
    public partial class DropVacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Escriba la cedula de quien desea eliminar</h1>\n  ");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
                                       Cedula1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Cedula1 = __value, Cedula1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n      ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-danger");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
                                                DropVacunado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n     \n  ");
            __builder.OpenElement(11, "div");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
        mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\DropVacuna.razor"
      

  string  Cedula1 = "";
  string mensaje = "";
   


  async Task DropVacunado(){
  vacunadosrdContext bd = new vacunadosrdContext();
  var a = Cedula1;
  var drop =  bd.Pacientes.Where(x=> x.cedula == a);

  bd.Pacientes.RemoveRange(drop);
  bd.SaveChanges();
  Cedula1 = "";
  mensaje = "se elimino correctamente";
  }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
