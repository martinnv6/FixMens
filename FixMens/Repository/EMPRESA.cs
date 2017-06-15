namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.EMPRESA")]
    public partial class EMPRESA
    {
        [StringLength(13)]
        public string RUC { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(25)]
        public string LOCALIDAD { get; set; }

        [StringLength(25)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string CORREOE { get; set; }

        [StringLength(50)]
        public string PAGINAWEB { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHA { get; set; }

        public byte[] LOGO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }
    }
}
