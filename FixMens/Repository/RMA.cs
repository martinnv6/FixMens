namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.RMA")]
    public partial class RMA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int COD_PROVEEDOR { get; set; }

        public DateTime? FECHA_ENVIO { get; set; }

        public DateTime? FECHA_RECIBIDO { get; set; }

        public byte[] DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE_PROVEEDOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE_CLIENTE { get; set; }

        public int IDREPARACION { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public virtual PROVEEDORES PROVEEDORES { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
