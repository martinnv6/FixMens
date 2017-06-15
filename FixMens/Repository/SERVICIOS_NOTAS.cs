namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.SERVICIOS_NOTAS")]
    public partial class SERVICIOS_NOTAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNOTA { get; set; }

        public int IDSERVICIO { get; set; }

        [StringLength(500)]
        public string NOTA { get; set; }

        public DateTime? FECHA { get; set; }

        public TimeSpan? HORA { get; set; }

        public virtual SERVICE_A_DOMICILIO SERVICE_A_DOMICILIO { get; set; }
    }
}
