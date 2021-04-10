using Dominio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Persistencia.Repository.Interfaces;

namespace Aplicacion.Empleados
{
    public class Consulta
    {
        public class ListaEmpleados : IRequest<List<Empleado>>
        {

        }

        public class Manejador : IRequestHandler<ListaEmpleados, List<Empleado>>
        {
            private readonly IContenedorTrabajo _contenedorTrabajo;
            public Manejador(IContenedorTrabajo contenedorTrabajo)
            {
                _contenedorTrabajo = contenedorTrabajo;
            }
            public async Task<List<Empleado>> Handle(ListaEmpleados request, CancellationToken cancellationToken)
            {
                var empleados = await _contenedorTrabajo.Empleado.GetAllAsyTask();
                return empleados.ToList();
            }
        }

    }
}