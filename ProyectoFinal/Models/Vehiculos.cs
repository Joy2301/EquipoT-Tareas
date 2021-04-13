using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class Vehiculos
    {
        public Vehiculos()
        {
            Reservaciones = new HashSet<Reservaciones>();
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public short Año { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public int TipoId { get; set; }
        public decimal CapacidadDeCarga { get; set; }
        public int Pasajeros { get; set; }
        public string Matricula { get; set; }
        public string NroSeguro { get; set; }
        public string VehiculoDisponible { get; set; }
        public string Foto { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }

        public virtual TipoVehiculo Tipo { get; set; }
        public virtual ICollection<Reservaciones> Reservaciones { get; set; }
    }
}
