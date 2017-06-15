namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.REPARACIONES_NOTAS")]
    public partial class REPARACIONES_NOTAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNOTA { get; set; }

        public int? IDORDEN { get; set; }

        public DateTime? FECHA { get; set; }

        public TimeSpan? HORA { get; set; }

        [StringLength(500)]
        public string NOTA { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
