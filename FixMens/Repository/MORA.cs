namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.MORA")]
    public partial class MORA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public DateTime FECHA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PORCENTAJE { get; set; }

        public int? MONEDA { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }
    }
}
