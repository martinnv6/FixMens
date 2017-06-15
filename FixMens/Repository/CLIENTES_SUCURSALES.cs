namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.CLIENTES_SUCURSALES")]
    public partial class CLIENTES_SUCURSALES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES_SUCURSALES()
        {
            PRESUPUESTOS_VARIOS = new HashSet<PRESUPUESTOS_VARIOS>();
            SERVICE_A_DOMICILIO = new HashSet<SERVICE_A_DOMICILIO>();
            REPARACIONES = new HashSet<REPARACIONES>();
            VENTA_EQUIPOS = new HashSet<VENTA_EQUIPOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int CLIENTE { get; set; }

        [StringLength(60)]
        public string DESCRIPCION { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(30)]
        public string TELEFONO { get; set; }

        [StringLength(40)]
        public string CONTACTO { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(1)]
        public string ABONADO { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESUPUESTOS_VARIOS> PRESUPUESTOS_VARIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_A_DOMICILIO> SERVICE_A_DOMICILIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES> REPARACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA_EQUIPOS> VENTA_EQUIPOS { get; set; }
    }
}
