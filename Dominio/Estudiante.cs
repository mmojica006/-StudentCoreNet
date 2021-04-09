using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Base.Contacto;
using Dominio.Base.Entities;

namespace Dominio
{
    public class Estudiante:ContactoBase
    {

        #region METODOS PUBLICOS

        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string Direccion { get; set; }
        public ICollection<Matricula> Matricula { get; set; }

        #endregion METODOS PUBLICOS
    }
}
