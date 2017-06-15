namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PAGOS")]
    public partial class PAGOS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NROCOMPRECIBO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SERIECOMPRECIBO { get; set; }

        public int CODCOMP { get; set; }

        public int NROCOMP { get; set; }

        [Required]
        [StringLength(1)]
        public string SERIECOMP { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FECHA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IMPORTE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
