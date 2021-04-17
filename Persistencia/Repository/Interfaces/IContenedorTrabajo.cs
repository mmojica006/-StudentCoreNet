using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repository.Interfaces
{
    public interface IContenedorTrabajo:IDisposable
    {
        IEmpleadoRepository Empleado { get; }
        Task<int> SaveAsynTask();
    }
}
