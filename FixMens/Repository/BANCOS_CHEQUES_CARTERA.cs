namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS_CHEQUES_CARTERA")]
    public partial class BANCOS_CHEQUES_CARTERA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHA_REAL { get; set; }

        [StringLength(20)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        public int? BANCO { get; set; }

        [StringLength(40)]
        public string DETALLE { get; set; }

        public int? MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE { get; set; }

        [Required]
        [StringLength(1)]
        public string COBRADO { get; set; }

        [Required]
        [StringLength(1)]
        public string NEGOCIADO { get; set; }

        [StringLength(40)]
        public string NEGOCIADO_DETALLE { get; set; }

        [StringLength(50)]
        public string TITULAR { get; set; }

        [StringLength(50)]
        public string BENEFICIARIO { get; set; }

        public int? CODIGO_MOVIMIENTO { get; set; }

        public virtual BANCOS BANCOS { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }
    }
}
