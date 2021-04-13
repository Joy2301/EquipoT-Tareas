using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class Tiposangre
    {
        public Tiposangre()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
