using Dominio;
using Dominio.Enum;
using MediatR;
using Persistencia.Repository.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Empleados
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string PrimerNombre { get; set; }
            public string SegundoNombre { get; set; }
            public int Genero { get; set; }
            public string Telefono { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Cedula { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly IContenedorTrabajo _contenedorTrabajo;
            public Manejador(IContenedorTrabajo contenedorTrabajo)
            {
                _contenedorTrabajo = contenedorTrabajo;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var genero = Enum.Parse<Genero>(request.Genero.ToString());
                var empleado = new Empleado
                {
                    PrimerNombre = request.PrimerNombre,
                    SegundoNombre = request.SegundoNombre,
                    Genero = genero,
                    FechaCreacion = DateTime.UtcNow,
                    Telefono = request.Telefono,
                    FechaNacimiento = request.FechaNacimiento,
                    Cedula = request.Cedula
                };
                await _contenedorTrabajo.Empleado.AddAsyncTask(empleado);
                  _contenedorTrabajo.SaveAsycTask();
                

                throw new Exception("No se puese insertar el empleado");


            }
        }
    }
}