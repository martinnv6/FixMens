namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.CAMBIOS_EQUIPOS")]
    public partial class CAMBIOS_EQUIPOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int? ORDEN { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(40)]
        public string NS_FALLA { get; set; }

        [StringLength(4)]
        public string TIPO_APARATO { get; set; }

        [StringLength(40)]
        public string MARCA { get; set; }

        [StringLength(40)]
        public string MODELO { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        public string OBSERVACIONES { get; set; }

        public virtual TIPO_APARATO TIPO_APARATO1 { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
