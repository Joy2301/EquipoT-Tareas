#pragma checksum "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8792d050385ffa97ed822de02d3270ea23a2aec9"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\_Imports.razor"
using Tarea_7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/VMarcas")]
    public partial class VMarcas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
 if(vacunas != null){
 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<thead><tr><th scope=\"col\">#</th>\r\n      <th scope=\"col\">Vacuna</th>\r\n      <th scope=\"col\">Cantidad</th></tr></thead>\r\n   ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 16 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
     foreach (var item in vacunas)
    {
         
      

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
#nullable restore
#line 23 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
         foreach(var item2 in GetVacunas(item.Key)){
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "th");
            __builder.AddAttribute(6, "scope", "row");
            __builder.AddContent(7, 
#nullable restore
#line 25 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
                             item2.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 26 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
                 item2.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, ">");
            __builder.AddContent(13, 
#nullable restore
#line 29 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
              item.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"

        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"

  
  
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<div class=\"chart-container\"><canvas id=\"myChart\"></canvas></div>\r\n  \r\n \r\n      ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
                            async ()=> await js.InvokeVoidAsync("Getgrafico",  valorcount,valorkey )

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Mostrar Grafico");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\raphiel burdier\Desktop\EquipoT-Tareas-main\Tarea_7\Pages\VMarcas.razor"
      
    private List<IGrouping<int?, Pacientes>> vacunas = null;

    static List<Vacunas> ListaVacunas => new vacunadosrdContext().Vacunas.ToList();

int? [] valorkey = new int?[ListaVacunas.Count()];
            int [] valorcount= new int[ListaVacunas.Count()];
            
    Vacunas vacuna1 = new Vacunas();
    
         
 

        protected override void OnInitialized(){
            vacunadosrdContext nc = new vacunadosrdContext();
            vacunas = nc.Pacientes.AsEnumerable().GroupBy(x => x.VacunaId).ToList();
            
          
            var x = 0;

           foreach(var it in vacunas){
             valorkey[x] = it.Key;
             valorcount[x] = it.Count();
              x=x+1;
           }
        }

        List<Vacunas> GetVacunas(int? id){
    
    vacunadosrdContext context = new vacunadosrdContext();

    var vacunas = context.Vacunas.Where(x => x.Id == id).ToList();

    return vacunas;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
