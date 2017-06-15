namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS_CHEQUES_EMITIDOS")]
    public partial class BANCOS_CHEQUES_EMITIDOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(20)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHA_REAL { get; set; }

        [StringLength(40)]
        public string DETALLE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE { get; set; }

        public int? CODIGO_MOVIMIENTO { get; set; }

        public int? CODIGO_FICHA_MOVIMENTS { get; set; }

        public int? CODIGO_CHEQUERA { get; set; }

        [StringLength(50)]
        public string DESTINATARIO { get; set; }

        public virtual BANCOS_CHEQUERAS BANCOS_CHEQUERAS { get; set; }

        public virtual BANCOS_MOVIMIENTOS BANCOS_MOVIMIENTOS { get; set; }
    }
}
