using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data.AdministracionUsuarios
{
    interface IRegistroService
    {
        Task<bool> InsertUsuario(Usuarios usuarios);
        Task<bool> UpdateUsuario(Usuarios usuarios);
        Task<bool> SaveUsuario(Usuarios usuarios);
    }
}