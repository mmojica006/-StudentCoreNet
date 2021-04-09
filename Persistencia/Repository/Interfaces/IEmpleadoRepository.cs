using System.Collections.Generic;
using Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Persistencia.Repository.Interfaces
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        IEnumerable<SelectListItem> GetListaEmpleados();
        void Update(Empleado empleado
        );
    }
}