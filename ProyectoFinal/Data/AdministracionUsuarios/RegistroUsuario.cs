using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data.AdministracionUsuarios
{
    public class RegistroService : IRegistroService
    {
        private readonly gestion_vehicularContext _context;
        public RegistroService(gestion_vehicularContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertUsuario(Usuarios usuarios)
        {
            _context.Usuarios.Add(usuarios);
            
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveUsuario(Usuarios usuarios)
        {
            if (usuarios.Id > 0)
                return await UpdateUsuario(usuarios);
            else
                return await InsertUsuario(usuarios);
        }

        public async Task<bool> UpdateUsuario(Usuarios usuarios)
        {
            _context.Entry(usuarios).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}