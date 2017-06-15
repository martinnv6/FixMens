namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.VENTA_EQUIPOS")]
    public partial class VENTA_EQUIPOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public DateTime? FECHA_VENTA { get; set; }

        [StringLength(40)]
        public string FACTURA_VENTA { get; set; }

        public int? DIAS_GARANTIA { get; set; }

        public DateTime? FECHA_FIN_GARANTIA { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        [StringLength(4)]
        public string TIPO_APARATO { get; set; }

        [StringLength(40)]
        public string MARCA { get; set; }

        [StringLength(40)]
        public string MODELO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public int? SUCURSALCLI { get; set; }

        public int? CLIENTE { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public byte[] OBSERVACIONES { get; set; }

        [StringLength(13)]
        public string ARTICULO { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual CLIENTES_SUCURSALES CLIENTES_SUCURSALES { get; set; }

        public virtual TIPO_APARATO TIPO_APARATO1 { get; set; }
    }
}
