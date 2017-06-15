namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.INTEGRANTES")]
    public partial class INTEGRANTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INTEGRANTES()
        {
            DEPARTSTOCK = new HashSet<DEPARTSTOCK>();
            SERVICE_HISTORICO_ESTADO = new HashSet<SERVICE_HISTORICO_ESTADO>();
            USUARIOS = new HashSet<USUARIOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(40)]
        public string NOMBRES { get; set; }

        [StringLength(1)]
        public string TECNICO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PORC_COMISION { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(20)]
        public string CELULAR { get; set; }

        [StringLength(100)]
        public string OBSERVACIONES { get; set; }

        public DateTime? FECHA_INGRESO { get; set; }

        [StringLength(1)]
        public string DESCATALOGADO { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(1)]
        public string STOCKPROPIO { get; set; }

        [StringLength(1)]
        public string SOLOORDENESPROPIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTSTOCK> DEPARTSTOCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_HISTORICO_ESTADO> SERVICE_HISTORICO_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
