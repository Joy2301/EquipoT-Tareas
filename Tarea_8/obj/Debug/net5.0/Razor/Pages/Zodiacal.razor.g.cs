#pragma checksum "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29916993e91a4446a469b8eddd3d9eba5acb0a9b"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_8.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Tarea_8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Tarea_8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Tarea_8.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Tarea_8.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Zodiacal")]
    public partial class Zodiacal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Listado de vacunados por signo Zodiacal</h4>");
#nullable restore
#line 6 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
 if(signos != null){
 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th scope=\"col\">#</th>\n      <th scope=\"col\">Signo</th>\n      <th scope=\"col\">Cantidad</th></tr></thead>\n   ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 18 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
     foreach (var item in signos)
    {
         
      

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
#nullable restore
#line 25 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
         foreach(var item2 in GetSignos(item.Key)){
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "scope", "row");
            __builder.AddContent(8, 
#nullable restore
#line 27 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
                             item2.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
                 item2.Signo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, ">");
            __builder.AddContent(14, 
#nullable restore
#line 31 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
              item.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"

        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"

  
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Zodiacal.razor"
      
    private List<IGrouping<int?, Pacientes>> signos = null;

    
    
      



        protected override void OnInitialized(){
            vacunadosrdv2Context nc = new vacunadosrdv2Context();
            signos = nc.Pacientes.AsEnumerable().GroupBy(x => x.SignoId).ToList();
           
        }

        List<Signozodiacal> GetSignos(int? id){
    
    vacunadosrdv2Context context = new vacunadosrdv2Context();

    var signos1 = context.Signozodiacal.Where(x => x.Id == id).ToList();

    return signos1;
    

}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
