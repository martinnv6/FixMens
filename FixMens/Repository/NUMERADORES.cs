namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.NUMERADORES")]
    public partial class NUMERADORES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VENTAS { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEVOLUCIONES { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RECIBOS { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NOTASDEBITO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string SERIEVENTAS { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string SERIEDEVOL { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string SERIERECIBOS { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string SERIEDEBITO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
