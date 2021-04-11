using MediatR;
using Persistencia.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilidades;

namespace Aplicacion.Empleados
{
    public class ObtenerGenero
    {

        public class Consulta : IRequest<List<ConvertEnum>> { }
        public class Manejador : IRequestHandler<Consulta, List<ConvertEnum>>
        {
            private readonly IContenedorTrabajo _contenedorTrabajo;
            public Manejador(IContenedorTrabajo contenedorTrabajo)
            {
                _contenedorTrabajo = contenedorTrabajo;
            }
            public  Task<List<ConvertEnum>> Handle(Consulta request, CancellationToken cancellationToken)
            {
                var response =  _contenedorTrabajo.Empleado.ObtenerGenero();
                return Task.FromResult(response);


            }
        }
    }
}
