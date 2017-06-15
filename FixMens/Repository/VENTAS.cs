namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.VENTAS")]
    public partial class VENTAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int CAJA { get; set; }

        public int AREAVENTA { get; set; }

        public int TIPODOCUMENTO { get; set; }

        public int NUMERO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        public int MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COFIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SUB_TOTAL { get; set; }

        public int MEDIOPAGO { get; set; }

        public int FORMAPAGO { get; set; }

        public int CLIENTE { get; set; }

        public int VENDEDOR { get; set; }

        public DateTime FECHA { get; set; }

        [StringLength(13)]
        public string HORA { get; set; }

        public string OBSERVACIONES { get; set; }

        [Required]
        [StringLength(1)]
        public string CONTADO_PENDIENTE { get; set; }

        public DateTime? FECHA_CONTADO_PENDIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMISION { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(1)]
        public string ANULADO { get; set; }

        public int? DEPOSITO { get; set; }

        [StringLength(10)]
        public string ORDENCOMPRA { get; set; }
    }
}
