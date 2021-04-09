using Dominio.Base.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Pago : EntityBase
    {
        #region METODOS PUBLICOS

        public DateTime FechaRegistro { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Total { get; set; }
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
        public ICollection<DetallePago> DetallePago { get; set; }

        #endregion METODOS PUBLICOS
    }
}