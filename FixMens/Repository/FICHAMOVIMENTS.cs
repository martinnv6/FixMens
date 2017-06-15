namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FICHAMOVIMENTS")]
    public partial class FICHAMOVIMENTS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int CODIGOFICHA { get; set; }

        public int? NUMERO { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(3)]
        public string SERIEFAC { get; set; }

        public int? NUMFAC { get; set; }

        public DateTime? CONDICIONPAGO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SALDO { get; set; }

        public int CODOP { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(1)]
        public string SALDADO { get; set; }

        public virtual FICHAPROVEEDORES FICHAPROVEEDORES { get; set; }

        public virtual FICHAOPERACIONES FICHAOPERACIONES { get; set; }
    }
}
