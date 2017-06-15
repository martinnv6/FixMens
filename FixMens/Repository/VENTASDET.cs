namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.VENTASDET")]
    public partial class VENTASDET
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMERO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string SERIE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPODOCUMENTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string ARTICULO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal CANTIDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DESCUENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PRECIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UTILIDAD { get; set; }

        [StringLength(200)]
        public string DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIO_NETO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public int? ORDEN { get; set; }
    }
}
