using Dominio.Base.Contacto;
using System;
using System.Collections.Generic;
using Aplicacion;

namespace Dominio
{
    public class Empleado : ContactoBase
    {

        #region METODOS PUBLICOS

        public DateTime FechaNacimiento { get; set; }

        public string Cedula { get; set; }
        public ICollection<Nivel> Nivel { get; set; }

        #endregion METODOS PUBLICOS
    }
}