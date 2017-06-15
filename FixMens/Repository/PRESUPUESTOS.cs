namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PRESUPUESTOS")]
    public partial class PRESUPUESTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESUPUESTOS()
        {
            PRESUPUESTOS_HISTORICO_ESTADO = new HashSet<PRESUPUESTOS_HISTORICO_ESTADO>();
            PRESUPUESTOS_VARIOS = new HashSet<PRESUPUESTOS_VARIOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int? IDREPARACION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRESUPUESTO { get; set; }

        public DateTime? FECHA { get; set; }

        public int ESTADO { get; set; }

        [StringLength(40)]
        public string CONTACTO { get; set; }

        public string DETALLE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPUESTOS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOTAL { get; set; }

        public int? CODIMPUESTO { get; set; }

        public int? CLIENTE { get; set; }

        [StringLength(1)]
        public string FACTURADO { get; set; }

        public int? MONEDA { get; set; }

        [StringLength(300)]
        public string ENLACE { get; set; }

        public int? IDORDENSERVICIO { get; set; }

        public virtual IMPUESTOS IMPUESTOS1 { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESUPUESTOS_HISTORICO_ESTADO> PRESUPUESTOS_HISTORICO_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESUPUESTOS_VARIOS> PRESUPUESTOS_VARIOS { get; set; }
    }
}
