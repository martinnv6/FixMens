namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PRESUPUESTOS_MANO_OBRA")]
    public partial class PRESUPUESTOS_MANO_OBRA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODPRESUP { get; set; }

        [StringLength(150)]
        public string DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIO_UNI { get; set; }

        [StringLength(1)]
        public string ACEPTADO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
