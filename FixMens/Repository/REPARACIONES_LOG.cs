namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.REPARACIONES_LOG")]
    public partial class REPARACIONES_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLOG { get; set; }

        public int? IDREPARACION { get; set; }

        [StringLength(500)]
        public string LOG { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
