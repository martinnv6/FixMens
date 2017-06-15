namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.RECIBOS")]
    public partial class RECIBOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int NRO_RECIBO { get; set; }

        [StringLength(3)]
        public string SERIE_RECIBO { get; set; }

        public int CAJA { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        public int? VENTA { get; set; }

        public int AREAVENTA { get; set; }

        public DateTime? FECHA { get; set; }

        public int? NROCUOTA { get; set; }

        public int MEDIOPAGO { get; set; }

        public int MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IMPORTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MORA { get; set; }

        public int? CLIENTE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(100)]
        public string OBSERVACIONES { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }
    }
}
