namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.SERVICIOS_LOG")]
    public partial class SERVICIOS_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLOG { get; set; }

        public int? IDSERVICIO { get; set; }

        [StringLength(500)]
        public string LOG { get; set; }

        public virtual SERVICE_A_DOMICILIO SERVICE_A_DOMICILIO { get; set; }
    }
}
