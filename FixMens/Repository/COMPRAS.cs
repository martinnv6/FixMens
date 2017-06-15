namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.COMPRAS")]
    public partial class COMPRAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        public int TIPO_DOCUMENTO { get; set; }

        public int NUMERO { get; set; }

        [Required]
        [StringLength(3)]
        public string SERIE { get; set; }

        public int MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COFIS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SUBTOTAL { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? CONDICION_PAGO { get; set; }

        public string OBSERVACIONES { get; set; }

        public int? PROVEEDOR { get; set; }

        public virtual FICHAOPERACIONES FICHAOPERACIONES { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual PROVEEDORES PROVEEDORES { get; set; }
    }
}
