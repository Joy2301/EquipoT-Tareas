// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 11 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\_Imports.razor"
using Tarea_7.Models;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Zodiacal")]
    public partial class Zodiacal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_7\Pages\Zodiacal.razor"
      
    private List<IGrouping<int?, Pacientes>> signos = null;

    
    
      



        protected override void OnInitialized(){
            vacunadosrdContext nc = new vacunadosrdContext();
            signos = nc.Pacientes.AsEnumerable().GroupBy(x => x.SignoId).ToList();
           
        }

        List<Signozodiacal> GetSignos(int? id){
    
    vacunadosrdContext context = new vacunadosrdContext();

    var signos1 = context.Signozodiacal.Where(x => x.Id == id).ToList();

    return signos1;
    

}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
