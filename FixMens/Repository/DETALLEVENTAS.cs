namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.DETALLEVENTAS")]
    public partial class DETALLEVENTAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODCOMP { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NROCOMP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string SERIECOMP { get; set; }

        [StringLength(50)]
        public string DETALLE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PREUNI { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CANTIDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PORCDTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IMPORTE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
