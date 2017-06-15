namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FACTURAS")]
    public partial class FACTURAS
    {
        public DateTime FECHA { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODCOMP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SERIECOMP { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NROCOMP { get; set; }

        public string SERIENRO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IMPORTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SALDO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODCLI { get; set; }

        public int CODMON { get; set; }

        public int CODVEND { get; set; }

        [StringLength(500)]
        public string OBSERVACIONES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COFIS { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
