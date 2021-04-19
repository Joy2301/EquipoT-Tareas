using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int RolId { get; set; }
        public string UsuarioActivo { get; set; }

        public virtual RolUsuarios Rol { get; set; }
    }
}
