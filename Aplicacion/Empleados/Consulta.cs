using Dominio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Empleados
{
    public class Consulta
    {
        public class ListaEmpleados : IRequest<List<Empleado>>
        {
            public class Manejador : IRequestHandler<ListaEmpleados, List<Empleado>>
            {
                public Task<List<Empleado>> Handle(ListaEmpleados request, CancellationToken cancellationToken)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}