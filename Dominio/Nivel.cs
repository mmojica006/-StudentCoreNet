using Dominio;
using System;
using System.Collections.Generic;
using Dominio.Base.Entities;

namespace Aplicacion
{
    public class Nivel:EntityBase
    {
        #region METODOS PUBLICOS

        public string Grado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public ICollection<Matricula> Matricula { get; set; }

        #endregion METODOS PUBLICOS
    }
}