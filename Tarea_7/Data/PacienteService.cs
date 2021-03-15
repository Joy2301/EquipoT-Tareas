using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_7.Models;

namespace Tarea_7.Data
{
    public class PacienteService : IPacienteService
    {
        private readonly vacunadosrdContext _context;
        public PacienteService(vacunadosrdContext context)
        {
            _context = context;
        }

        public async Task<Provincias> GetDetallesProvincia(int id)
        {
            return await _context.Provincias.FindAsync(id); 
        }

        public async Task<bool> InsertPaciente(Pacientes pacientes)
        {
            _context.Pacientes.Add(pacientes);
            
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SavePaciente(Pacientes pacientes)
        {
            if (pacientes.Id > 0)
                return await UpdatePaciente(pacientes);
            else
                return await InsertPaciente(pacientes);
        }

        public async Task<bool> UpdatePaciente(Pacientes pacientes)
        {
            _context.Entry(pacientes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateProvincia(Provincias provincias)
        {
            _context.Entry(provincias).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateVacuna(Vacunas vacunas)
        {
            _context.Entry(vacunas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Vacunas> GetDetallesVacunas(int id)
        {
            return await _context.Vacunas.FindAsync(id);
        }

        public async Task<bool> InsertProvincia(Provincias provincias)
        {
            _context.Provincias.Add(provincias);
            
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> InsertVacunas(Vacunas vacunas)
        {
            _context.Vacunas.Add(vacunas);
            
            return await _context.SaveChangesAsync() > 0;
        }
    }
}