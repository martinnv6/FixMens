namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.TIPO_APARATO")]
    public partial class TIPO_APARATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_APARATO()
        {
            ALMACEN_FALLAS = new HashSet<ALMACEN_FALLAS>();
            CAMBIOS_EQUIPOS = new HashSet<CAMBIOS_EQUIPOS>();
            COMPRA_EQUIPOS = new HashSet<COMPRA_EQUIPOS>();
            VENTA_EQUIPOS = new HashSet<VENTA_EQUIPOS>();
        }

        [Key]
        [StringLength(4)]
        public string CODIGO { get; set; }

        [StringLength(40)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACEN_FALLAS> ALMACEN_FALLAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMBIOS_EQUIPOS> CAMBIOS_EQUIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_EQUIPOS> COMPRA_EQUIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA_EQUIPOS> VENTA_EQUIPOS { get; set; }
    }
}
