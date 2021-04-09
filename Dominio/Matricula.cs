using System;
using System.Collections.Generic;
using System.Text;
using Aplicacion;
using Dominio.Base.Entities;

namespace Dominio
{
    public class Matricula:EntityBase
    {

        #region METODOS PUBLICOS

        public string Seccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int NivelId { get; set; }
        public Nivel Nivel { get; set; }
        public int AnioLectivoId { get; set; }
        public AnioLectivo AnioLectivo { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public ICollection<Pago> Pago { get; set; }

        #endregion METODOS PUBLICOS
    }
}
