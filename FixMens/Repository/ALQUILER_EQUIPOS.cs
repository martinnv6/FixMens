namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.ALQUILER_EQUIPOS")]
    public partial class ALQUILER_EQUIPOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public DateTime? FECHA_ALQUILER { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        public int? CLIENTE { get; set; }

        public DateTime? UTIMA_FECHA_FACTURACION { get; set; }

        public string OBSERVACIONES { get; set; }

        public DateTime? FECHA_DEVOLUCION { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }
    }
}
