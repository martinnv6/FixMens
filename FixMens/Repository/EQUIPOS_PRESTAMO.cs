namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.EQUIPOS_PRESTAMO")]
    public partial class EQUIPOS_PRESTAMO
    {
        [StringLength(40)]
        public string NS { get; set; }

        public DateTime? FECHA_PRESTAMO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLIENTE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
