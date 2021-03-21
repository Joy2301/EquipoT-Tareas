using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_8.Models
{
    public partial class Municipios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }

        public virtual Provincias Provincia { get; set; }
    }
}
