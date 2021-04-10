using Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistencia.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly ApplicationDbContext _db;

        public EmpleadoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetListaEmpleadosAsyncTask()
        {
            return await _db.Empleado.Select(i => new SelectListItem()
            {
                Text = i.PrimerNombre,
                Value = i.Id.ToString()
            }).ToListAsync();
        }

        public async Task UpdateAsyncTask(Empleado empleado)
        {
            var objDesdeDb = _db.Empleado.FirstOrDefault(s => s.Id == empleado.Id);
            objDesdeDb.PrimerNombre = empleado.PrimerNombre;
            objDesdeDb.SegundoNombre = empleado.SegundoNombre;
            await _db.SaveChangesAsync();
        }
    }
}