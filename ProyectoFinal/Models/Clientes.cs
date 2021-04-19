using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Reservaciones = new HashSet<Reservaciones>();
        }

        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }
        public string Nacionalidad { get; set; }
        public int TipoSangreId { get; set; }
        public string ClienteActivo { get; set; }
        public string FotoCliente { get; set; }
        public string FotoLicencia { get; set; }

        public virtual Tiposangre TipoSangre { get; set; }
        public virtual ICollection<Reservaciones> Reservaciones { get; set; }
    }
}
