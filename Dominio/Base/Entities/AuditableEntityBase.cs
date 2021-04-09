using System;

namespace Dominio.Base.Entities
{
    public class AuditableEntityBase : EntityBase
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}