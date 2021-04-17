using Persistencia.Repository.Interfaces;
using System.Threading.Tasks;

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

        public async Task<int> SaveAsynTask()
        {
              return await  _db.SaveChangesAsync();
        }
    }
}