namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PROVEEDORES")]
    public partial class PROVEEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDORES()
        {
            COMPRAS = new HashSet<COMPRAS>();
            COMPRASDET = new HashSet<COMPRASDET>();
            FICHAPROVEEDORES = new HashSet<FICHAPROVEEDORES>();
            COMPRA_EQUIPOS = new HashSet<COMPRA_EQUIPOS>();
            RMA = new HashSet<RMA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(40)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(30)]
        public string TELEFONO { get; set; }

        public string OBSERVACIONES { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(25)]
        public string LOCALIDAD { get; set; }

        [StringLength(25)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(50)]
        public string CONTACTO { get; set; }

        [StringLength(15)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string CORREOE { get; set; }

        [StringLength(30)]
        public string RUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAS> COMPRAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRASDET> COMPRASDET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHAPROVEEDORES> FICHAPROVEEDORES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_EQUIPOS> COMPRA_EQUIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMA> RMA { get; set; }
    }
}
