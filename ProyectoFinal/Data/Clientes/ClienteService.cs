using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data
{
    public class ClienteService : IClienteService
    {
        private readonly gestion_vehicularContext _context;
        public ClienteService(gestion_vehicularContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertCliente(Clientes clientes)
        {
            _context.Clientes.Add(clientes);

            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> InsertPaciente(Clientes clientes)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveCliente(Clientes clientes)
        {
            if (clientes.Id > 0)
                return await UpdateCliente(clientes);
            else
                return await InsertCliente(clientes);
        }

        public Task<bool> SavePaciente(Clientes clientes)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCliente(Clientes clientes)
        {
            _context.Entry(clientes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdatePaciente(Clientes clientes)
        {
            throw new NotImplementedException();
        }
    }
}