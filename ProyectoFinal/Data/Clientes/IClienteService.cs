using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data
{
    interface IClienteService
    {
        Task<bool> InsertCliente(Clientes clientes);
        Task<bool> UpdateCliente(Clientes clientes);
        Task<bool> SaveCliente(Clientes clientes);
    }
}