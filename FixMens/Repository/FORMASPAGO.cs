namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FORMASPAGO")]
    public partial class FORMASPAGO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(1)]
        public string ABRIRCAJON { get; set; }

        public int? CUOTAS { get; set; }

        public int? PRIMERCUOTA { get; set; }

        public int? DIASCUOTAS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? INTERES { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
