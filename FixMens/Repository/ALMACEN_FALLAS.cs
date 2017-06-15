namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.ALMACEN_FALLAS")]
    public partial class ALMACEN_FALLAS
    {
        [StringLength(4)]
        public string TIPO_APARATO { get; set; }

        [StringLength(40)]
        public string MARCA { get; set; }

        [StringLength(40)]
        public string MODELO { get; set; }

        [Key]
        [StringLength(40)]
        public string NS { get; set; }

        public string OBSERVACIONES { get; set; }

        public int? ACTIVO { get; set; }

        public virtual TIPO_APARATO TIPO_APARATO1 { get; set; }
    }
}
