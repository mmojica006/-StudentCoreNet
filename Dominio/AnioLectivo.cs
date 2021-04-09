using System.Collections.Generic;
using Dominio.Base.Entities;

namespace Dominio
{
    public class AnioLectivo : EntityBase
    {
        #region METODOS PUBLICOS

        public int AnioInicio { get; set; }
        public int AnioFin { get; set; }
        public int Estado { get; set; }
        public ICollection<Matricula> Matricula { get; set; }
   

        #endregion METODOS PUBLICOS
    }
}