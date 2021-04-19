using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Vehiculos = new HashSet<Vehiculos>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
