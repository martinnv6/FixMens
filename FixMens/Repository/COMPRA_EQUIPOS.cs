namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.COMPRA_EQUIPOS")]
    public partial class COMPRA_EQUIPOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int? PROVEEDOR { get; set; }

        public DateTime? FECHA_COMPRA { get; set; }

        [StringLength(30)]
        public string FACTURA_PROVEEDOR { get; set; }

        public int? DIAS_GARANTIA { get; set; }

        public DateTime? FIN_GARANTIA { get; set; }

        [StringLength(4)]
        public string TIPO_APARATO { get; set; }

        [StringLength(40)]
        public string MARCA { get; set; }

        [StringLength(40)]
        public string MODELO { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        public string OBSERVACIONES { get; set; }

        [StringLength(200)]
        public string FOTO_ARCH { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(13)]
        public string ARTICULO { get; set; }

        public virtual PROVEEDORES PROVEEDORES { get; set; }

        public virtual TIPO_APARATO TIPO_APARATO1 { get; set; }
    }
}
