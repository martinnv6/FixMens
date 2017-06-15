namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.EQUIPOS_EMPRESA")]
    public partial class EQUIPOS_EMPRESA
    {
        [StringLength(40)]
        public string NS { get; set; }

        [Key]
        [StringLength(4)]
        public string TIPOAPARATO { get; set; }

        [StringLength(40)]
        public string MARCA { get; set; }

        [StringLength(40)]
        public string MODELO { get; set; }

        public string OBSERVACIONES { get; set; }

        [StringLength(1)]
        public string PRESTADO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
