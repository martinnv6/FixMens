namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.GASTOS")]
    public partial class GASTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int CAJA { get; set; }

        public DateTime? FECHA { get; set; }

        public TimeSpan? HORA { get; set; }

        public int MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public int? RUBRO { get; set; }

        public virtual RUBROS RUBROS { get; set; }
    }
}
