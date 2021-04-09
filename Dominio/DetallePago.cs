using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Base.Entities;

namespace Dominio
{
    public class DetallePago
    {
        public int PagoId { get; set; }
        public Pago Pago { get; set; }
        public int ConceptoId { get; set; }
        public Concepto Concepto { get; set; }
    }
}
