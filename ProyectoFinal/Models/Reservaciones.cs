using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class Reservaciones
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Debe { get; set; }
        public decimal HaPagado { get; set; }
        public string FacturaPagada { get; set; }
        public string VehiculoDevuelto { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Vehiculos Vehiculo { get; set; }
    }
}
