using System;
using System.Collections.Generic;
using System.Text;
using Persistencia.Repository.Interfaces;

namespace Persistencia.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IEmpleadoRepository Empleado { get; }

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Empleado = new EmpleadoRepository(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

       
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
