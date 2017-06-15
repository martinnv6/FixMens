namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.USUARIOS")]
    public partial class USUARIOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(40)]
        public string NOMBRE { get; set; }

        [StringLength(40)]
        public string PASSWD { get; set; }

        [Required]
        [StringLength(1)]
        public string TALLER { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public int? IDINTEGRANTE { get; set; }

        public virtual INTEGRANTES INTEGRANTES { get; set; }
    }
}
