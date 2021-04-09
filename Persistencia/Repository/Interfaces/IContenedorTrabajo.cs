using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Repository.Interfaces
{
    public interface IContenedorTrabajo:IDisposable
    {
        IEmpleadoRepository Empleado { get; }
        void Save();
    }
}
