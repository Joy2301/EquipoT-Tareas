//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea9
{
    using System;
    using System.Collections.Generic;
    
    public partial class municipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<double> Longitud { get; set; }
    
        public virtual provincias provincias { get; set; }
    }
}
