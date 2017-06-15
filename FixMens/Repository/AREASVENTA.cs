namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.AREASVENTA")]
    public partial class AREASVENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREASVENTA()
        {
            REPARACIONES = new HashSet<REPARACIONES>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        [StringLength(10)]
        public string NOMBRE { get; set; }

        [StringLength(3)]
        public string SERIE_FACTURA { get; set; }

        [StringLength(3)]
        public string SERIE_RECIBO { get; set; }

        [StringLength(3)]
        public string SERIE_NOTA_CREDITO { get; set; }

        [StringLength(3)]
        public string SERIE_DEV_CONTADO { get; set; }

        [StringLength(3)]
        public string SERIE_REMITO { get; set; }

        public int? NRO_FACTURA { get; set; }

        public int? NRO_RECIBO { get; set; }

        public int? NRO_NOTA_CREDITO { get; set; }

        public int? NRO_DEV_CONTADO { get; set; }

        public int? NRO_REMITO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(3)]
        public string SERIE_FACTURA_B { get; set; }

        [StringLength(3)]
        public string SERIE_NOTA_CREDITO_B { get; set; }

        [StringLength(3)]
        public string SERIE_DEV_CONTADO_B { get; set; }

        [StringLength(3)]
        public string SERIE_RECIBO_B { get; set; }

        public int? NRO_FACTURA_B { get; set; }

        public int? NRO_NOTA_CREDITO_B { get; set; }

        public int? NRO_RECIBO_B { get; set; }

        public int? NRO_DEV_CONTADO_B { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES> REPARACIONES { get; set; }
    }
}
