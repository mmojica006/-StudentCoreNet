using Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilidades;

namespace Persistencia.Repository.Interfaces
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        Task<IEnumerable<SelectListItem>> GetListaEmpleadosAsyncTask();

        Task UpdateAsyncTask(Empleado empleado
        );

        List<ConvertEnum> ObtenerGenero();
    }
}