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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\mdela\Desktop\ITLA\Cuatrimestre 5\Trabajos\EquipoT-Tareas\Tarea_8\Pages\Registro.razor"
       
    public Pacientes pacientes = new Pacientes();
    public string EstadoVacunas { get; set; } = "";
    public string EstadoFechaSegundaVacuna { get; set; } = "";
    int ProvinciaIdUbicacion = 1;
    public int MunicipioIdUbicacion { get; set; }

    protected async Task SavePaciente()
    {
        var context = new vacunadosrdv2Context();
        var VacunaInventario = context.Vacunas.Where(v => v.Id == pacientes.VacunaId).FirstOrDefault(); //consulto por ID en la tabla 'vacunas'
        
        //Si no hay vacunas de una marca no permite el registro
        if (VacunaInventario.Cantidad == 0)
        {
            EstadoVacunas = "No hay mas vacunas de esta marca";
            Console.WriteLine("No hay mas vacunas de esta marca");
        }
        else
        {
            EstadoVacunas = "";
            EstadoFechaSegundaVacuna = "";

            /*  Si encuentra el registro y encuentra que la segunda fecha de la vacuna 
            esta nula al momento de registrar, actualiza el campo con la fecha actual
            */
            bool ExisteRegistro = context.Pacientes.Any(p => p.cedula == pacientes.cedula);

            if (ExisteRegistro == true)
            {
                var FechaSegundaVacuna = context.Pacientes.Where(p => p.cedula == pacientes.cedula).FirstOrDefault();
        
                if (FechaSegundaVacuna.FechaSegundaVacuna == null)
                {
                    FechaSegundaVacuna.FechaSegundaVacuna = DateTime.Now.Date;  //actualizas las propiedades de 'Cantidad'
                    context.SaveChanges();  //guardas cambios

                    Limpiar();
                    DescontarVacuna();
                    EstadoFechaSegundaVacuna = "Se registro la segunda vacuna de este paciente";
                }
                else
                {
                    EstadoFechaSegundaVacuna = "Este paciente ya ha recibido su segunda vacuna";
                }
            }
            else
            {
                //Se registra el paciente
                await PacienteService.SavePaciente(pacientes);

                EstadoVacunas = "";
                EstadoFechaSegundaVacuna = "";

                Limpiar();
                DescontarVacuna();

                pacientes.VacunaId = 0;
            }
        }
    }

    /*-------------------Traemos los datos de la API a partir de la cedula-------------------*/
        string Nombre{ get; set; }
        string Apellidos{ get; set; }
        string FechaNacimiento{ get; set; }
        int DiaNacimiento{ get; set; }
        int MesNacimiento{ get; set; }

    public void DatosApi()
    {
        dynamic respuesta;

        //El objeto de la clase donde estan los metodos para la Api
        DBApi dBApi = new DBApi();
        respuesta = dBApi.Get("https://api.adamix.net/apec/cedula/" + pacientes.cedula);

        Nombre = respuesta.Nombres.ToString();
        pacientes.Nombre = Nombre;

        string Apellido1 = respuesta.Apellido1.ToString();
        string Apellido2 = respuesta.Apellido2.ToString();
        Apellidos = Apellido1 + " " + Apellido2; 
        pacientes.Apellido = Apellidos;

        FechaNacimiento = respuesta.FechaNacimiento.ToString();
        var parsedDate = DateTime.Parse(FechaNacimiento);
        pacientes.FechaNacimiento = parsedDate;

        //Ahora obtendremos el signo zodiacal
        MesNacimiento = Int16.Parse(FechaNacimiento.Substring(5,2));

        DiaNacimiento = Int16.Parse(FechaNacimiento.Substring(8,2));

        switch(MesNacimiento)
        {
            case 1: //Enero-Diciembre, con sus números respectivos del 1 al 12
                if (DiaNacimiento < 21)
                    pacientes.SignoId = 12; //Capricornio
                else
                    pacientes.SignoId = 1; //Acuario
                break;
            case 2: 
                if (DiaNacimiento < 19)
                    pacientes.SignoId = 1; //Acuario
                else
                    pacientes.SignoId = 2; //Piscis
                break;
            case 3:
                if (DiaNacimiento < 21)
                    pacientes.SignoId = 2; //Piscis
                else
                    pacientes.SignoId = 3; //Aries
                break;
            case 4:
                if (DiaNacimiento < 21)
                    pacientes.SignoId = 3; //Aries
                else
                    pacientes.SignoId = 4; //Tauro
                break;
            case 5:
                if (DiaNacimiento < 22)
                    pacientes.SignoId = 4; //Tauro
                else
                    pacientes.SignoId = 5; //Geminis
                break;
            case 6:
                if (DiaNacimiento < 22)
                    pacientes.SignoId = 5; //Geminis
                else
                    pacientes.SignoId = 6; //Cancer
                break;
            case 7:
                if (DiaNacimiento < 23)
                    pacientes.SignoId = 6; //Cancer
                else
                    pacientes.SignoId = 7; //Leo
                break;
            case 8:
                if (DiaNacimiento < 24)
                    pacientes.SignoId = 7; //Leo
                else
                    pacientes.SignoId = 8; //Virgo
                break;
            case 9:
                if (DiaNacimiento < 24)
                    pacientes.SignoId = 8; //Virgo
                else
                    pacientes.SignoId = 8; //Libra
                break;
            case 10:
                if (DiaNacimiento < 24)
                    pacientes.SignoId = 9; //Libra
                else
                    pacientes.SignoId = 10; //Escorpion
                break;
            case 11:
                if (DiaNacimiento < 23)
                    pacientes.SignoId = 10; //Escorpion
                else
                    pacientes.SignoId = 11; //Sagitario
                break;
            case 12:
                if (DiaNacimiento < 22)
                    pacientes.SignoId = 11; //Sagitario
                else
                    pacientes.SignoId = 12; //Capricornio
                break;
                
        }
    }

    //Con esta clase accedo a la url de la api y devuelvo sus datos
    public class DBApi
    {
        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }
    }

    public void Limpiar()
    {
        //Limpiamos los campos
            pacientes.Nombre = "";
            pacientes.Apellido = "";
            pacientes.Telefono = "";
            pacientes.FechaNacimiento = DateTime.Now.Date;
            pacientes.ProvinciaId = 0;
            pacientes.SignoId = 0;
            pacientes.FechaPrimeraVacuna = DateTime.Now.Date;
            pacientes.FechaSegundaVacuna = DateTime.Now.Date;
    }

    public void DescontarVacuna()
    {
        var context = new vacunadosrdv2Context();
        var VacunaInventario = context.Vacunas.Where(v => v.Id == pacientes.VacunaId).FirstOrDefault(); //consulto por ID en la tabla 'vacunas'

        //Vamos descontando la cantidad de vacunas que tenemos en la DB
        VacunaInventario.Cantidad -= 1;  //actualizas las propiedades de 'Cantidad'
        context.SaveChanges();  //guardas cambios
    }

    /*-------------------Variables y lista para el combobox de las Vacunas-------------------*/

    public List<Vacunas> GetVacunas()
    {
        vacunadosrdv2Context context = new vacunadosrdv2Context();

        var vacunas = context.Vacunas.ToList();

        return vacunas;
    }

    /*-------------------Variables y lista para el combobox de las provincias y municipios-------------------*/

    public List<Provincias> GetProvincias()
    {
        vacunadosrdv2Context context = new vacunadosrdv2Context();

        var provincias = context.Provincias.ToList();

        return provincias;
    }

    public class VistaMunicipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }

    /*
    Hago Join de la tabla municipio a provincias
    pero solo traigo los que son especificos de su provincia
    al seleccionarse en el combobox de provincias
    */
    List<VistaMunicipios> GetMunicipios()
    {
        var context = new vacunadosrdv2Context();

        return context.Municipios
            .Join(
                context.Provincias,
                m => m.ProvinciaId,
                p => p.Id,
                (m, p) => new { Municipios = m, Provincias = p }
            )
            .Where(All => All.Municipios.ProvinciaId == ProvinciaIdUbicacion)
            .Select(
                m => new VistaMunicipios{
                    Id = m.Municipios.Id,
                    Nombre = m.Municipios.Nombre,
                    Latitud = m.Municipios.Latitud,
                    Longitud = m.Municipios.Longitud
                    
                }
            ).ToList();
    }

    /*-------------------Variables y lista para el combobox de las Vacunas-------------------*/

    public List<Signozodiacal> GetSignozodiacal()
    {
        vacunadosrdv2Context context = new vacunadosrdv2Context();

        var signo = context.Signozodiacal.ToList();

        return signo;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPacienteService PacienteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
