#pragma checksum "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b04f792aa05e30446c982e84e836195903a5c63c"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Registro_Reservaciones")]
    public partial class Registro_Reservaciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Registrar</h4>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                  reservacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "mb-3");
                __builder2.AddMarkupContent(6, "<label for=\"vehi\" class=\"form-label\">Seleccionar el vehiculo</label>\r\n");
                __builder2.OpenElement(7, "select");
                __builder2.AddAttribute(8, "class", "form-select");
                __builder2.AddAttribute(9, "aria-label", "Default select example");
                __builder2.AddAttribute(10, "id", "vehi");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                                                                                    reservacion.VehiculoId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reservacion.VehiculoId = __value, reservacion.VehiculoId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(13, "option");
                __builder2.AddAttribute(14, "selected");
                __builder2.AddContent(15, "Open this select menu");
                __builder2.CloseElement();
#nullable restore
#line 12 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
   foreach (var item in GetVehiculos())
  {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(16, "option");
                __builder2.AddAttribute(17, "value", 
#nullable restore
#line 14 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                    item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(18, 
#nullable restore
#line 14 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                              item.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 15 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
  }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n  ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "mb-3");
                __builder2.AddMarkupContent(22, "<label for=\"Client\" class=\"form-label\">Seleccionar el cliente</label>\r\n");
                __builder2.OpenElement(23, "select");
                __builder2.AddAttribute(24, "class", "form-select");
                __builder2.AddAttribute(25, "aria-label", "Default select example");
                __builder2.AddAttribute(26, "id", "Client");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                                                                                      reservacion.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reservacion.ClienteId = __value, reservacion.ClienteId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "selected");
                __builder2.AddContent(31, "Open this select menu");
                __builder2.CloseElement();
#nullable restore
#line 25 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
     foreach (var item in GetClientes())
  {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "option");
                __builder2.AddAttribute(33, "value", 
#nullable restore
#line 27 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                    item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(34, 
#nullable restore
#line 27 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                              item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 28 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
  }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n\r\n  ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "mb-3");
                __builder2.AddMarkupContent(38, "<label for=\"F_inicial\" class=\"form-label\">Dia inicial de la reservacion</label>\r\n");
                __Blazor.ProyectoFinal.Pages.Registro_Reservaciones.TypeInference.CreateInputDate_0(__builder2, 39, 40, "F_inicial", 41, 
#nullable restore
#line 36 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                                             reservacion.FechaInicio

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reservacion.FechaInicio = __value, reservacion.FechaInicio)), 43, () => reservacion.FechaInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n  ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "mb-3");
                __builder2.AddMarkupContent(47, "<label for=\"F_final\" class=\"form-label\">Dia final de la reservacion</label>\r\n");
                __Blazor.ProyectoFinal.Pages.Registro_Reservaciones.TypeInference.CreateInputDate_1(__builder2, 48, 49, "F_final", 50, 
#nullable restore
#line 40 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                                           reservacion.FechaFin

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reservacion.FechaFin = __value, reservacion.FechaFin)), 52, () => reservacion.FechaFin);
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "h6");
            __builder.AddContent(55, 
#nullable restore
#line 50 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
     result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-primary");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
                                              Registrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Registrar");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\raphiel burdier\Desktop\ProyectoFinal\Pages\Registro_Reservaciones.razor"
      
    Reservaciones reservacion = new Reservaciones();
    string result = "";

  

     protected override void OnInitialized() 
 {
     reservacion.FechaInicio = DateTime.Now.Date;
     reservacion.FechaFin = DateTime.Now.Date;

 }


    


    List<Vehiculos> GetVehiculos(){
        gestion_vehicularContext bd = new gestion_vehicularContext();
        return bd.Vehiculos.Where(x=> x.VehiculoDisponible == "Si").ToList();
        
        }

List<Clientes> GetClientes(){
        gestion_vehicularContext bd = new gestion_vehicularContext();
        return bd.Clientes.ToList();
        
        }

        async Task Registrar(){


gestion_vehicularContext db = new gestion_vehicularContext();
var reservaciones1 = db.Reservaciones.Where(x => x.VehiculoId == reservacion.VehiculoId).ToList();

foreach(var item in reservaciones1){
    if(reservacion.FechaInicio == item.FechaInicio || 
    reservacion.FechaFin == item.FechaFin || 
    reservacion.FechaInicio >= item.FechaInicio && reservacion.FechaInicio <= item.FechaFin ||
    reservacion.FechaFin >= item.FechaInicio && reservacion.FechaFin <= item.FechaFin
    ){
        result = "Vehiculo ocupado en esta fecha";
        return;
    }
}



var compare_f = DateTime.Compare(reservacion.FechaInicio, DateTime.Now.Date);
var compare_f2 = DateTime.Compare(reservacion.FechaInicio, reservacion.FechaFin);
if(compare_f < 0 || compare_f2 > 0)
{
    result = "Error en la fecha";
    return;
}

var auto = db.Vehiculos.Where(x => x.Id == reservacion.VehiculoId).First();
var costo = auto.Precio;
var dias = reservacion.FechaFin.Subtract(reservacion.FechaInicio).TotalDays;
var resultado = costo * Convert.ToDecimal(dias);

reservacion.MontoTotal = resultado;
reservacion.Debe = resultado;
reservacion.HaPagado = 0.0m;
reservacion.FacturaPagada = "No";
reservacion.VehiculoDevuelto = "Si";




db.Reservaciones.Add(reservacion);
 db.SaveChanges();
NavigationManager.NavigateTo("/Modulo_Cobros");
   
}

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.ProyectoFinal.Pages.Registro_Reservaciones
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591