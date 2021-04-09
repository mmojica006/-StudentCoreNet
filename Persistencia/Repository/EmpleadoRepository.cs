using Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistencia.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly ApplicationDbContext _db;
        public EmpleadoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaEmpleados()
        {
            return  _db.Empleado.Select(i=>new SelectListItem()
            {
                Text = i.PrimerNombre,
                Value = i.Id.ToString()

            });
        }

        public void Update(Empleado empleado)
        {
            var objDesdeDb = _db.Empleado.FirstOrDefault(s => s.Id == empleado.Id);
            objDesdeDb.PrimerNombre = empleado.PrimerNombre;
            objDesdeDb.SegundoNombre = empleado.SegundoNombre;
            _db.SaveChanges();

        }
    }
}