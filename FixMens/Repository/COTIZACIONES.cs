namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.COTIZACIONES")]
    public partial class COTIZACIONES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MONEDA { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMPRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VENTA { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
