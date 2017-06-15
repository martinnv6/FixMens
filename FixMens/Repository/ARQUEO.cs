namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.ARQUEO")]
    public partial class ARQUEO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int CAJA { get; set; }

        public DateTime? FECHA { get; set; }

        public TimeSpan? HORA { get; set; }

        public int MONEDA { get; set; }

        public int VENDEDOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTEINICIAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DIFERENCIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CALCULADO { get; set; }

        [Required]
        [StringLength(1)]
        public string CERRADA { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
