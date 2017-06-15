namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.COSTOS_SERVICIOS")]
    public partial class COSTOS_SERVICIOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSERVICIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SUBTOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPUESTOS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        public int? IMPUESTO { get; set; }

        [StringLength(20)]
        public string CONTACTO { get; set; }

        public string DETALLE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
