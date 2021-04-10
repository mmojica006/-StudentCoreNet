using Dominio.Base.Entities;
using Dominio.Enum;

namespace Dominio.Base.Contacto
{
    public class ContactoBase: AuditableEntityBase
    {
        #region Public Properties

        public virtual string PrimerNombre { get; set; }
        public virtual string SegundoNombre { get; set; }
        public virtual string  Telefono { get; set; }
        public virtual Genero Genero { get; set; }

        #endregion Public Properties
    }
}
