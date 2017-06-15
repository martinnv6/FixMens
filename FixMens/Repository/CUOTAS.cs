namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.CUOTAS")]
    public partial class CUOTAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int VENTA { get; set; }

        [Required]
        [StringLength(3)]
        public string SERIE { get; set; }

        public DateTime? FECHAVTO { get; set; }

        public int? NROCUOTA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IMPORTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SALDO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
