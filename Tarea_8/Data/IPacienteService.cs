using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_8.Models;

namespace Tarea_8.Data
{
    interface IPacienteService
    {
        Task<bool> InsertPaciente(Pacientes pacientes);
        Task<bool> InsertProvincia(Provincias provincias);
        Task<bool> InsertVacunas(Vacunas vacunas);
        Task<bool> UpdatePaciente(Pacientes pacientes);
        Task<bool> UpdateProvincia(Provincias provincias);
        Task<Provincias> GetDetallesProvincia(int id);

        Task<bool> UpdateVacuna(Vacunas vacunas);
        Task<Vacunas> GetDetallesVacunas(int id);
        Task<bool> SavePaciente(Pacientes pacientes);
    }
}