// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaConfiguracionVacunas")]
    public partial class ListaConfiguracionVacunas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\ListaConfiguracionVacunas.razor"
 
    List<Vacunas> GetVacunas() => new vacunadosrdv2Context().Vacunas.ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
