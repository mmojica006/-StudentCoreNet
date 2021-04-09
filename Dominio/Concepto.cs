using Dominio.Base.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Concepto : EntityBase
    {
        #region METODOS PUBLICOS

        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }
        public bool Estado { get; set; }
        public ICollection<DetallePago> DetallePago { get; set; }

        #endregion METODOS PUBLICOS
    }
}