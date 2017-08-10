namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.CLIENTES")]
    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            ALQUILER_EQUIPOS = new HashSet<ALQUILER_EQUIPOS>();
            RECIBOS = new HashSet<RECIBOS>();
            VENTA_EQUIPOS = new HashSet<VENTA_EQUIPOS>();
            CLIENTES_SUCURSALES = new HashSet<CLIENTES_SUCURSALES>();
            PRESUPUESTOS_VARIOS = new HashSet<PRESUPUESTOS_VARIOS>();
            REPARACIONES = new HashSet<REPARACIONES>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(80)]
        public string NOMBRES { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(30)]
        public string TELEFONO { get; set; }

        [StringLength(40)]
        public string CELULAR { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public string OBSERVACIONES { get; set; }

        [StringLength(30)]
        public string RUC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LIMITECREDITO { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(25)]
        public string LOCALIDAD { get; set; }

        [StringLength(25)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(75)]
        public string CONTACTO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(1)]
        public string CLIGARANTIA { get; set; }

        [StringLength(80)]
        public string GIRO { get; set; }

        [StringLength(1)]
        public string ABONADO { get; set; }

        [StringLength(40)]
        public string LOGIN { get; set; }

        [StringLength(40)]
        public string PASSWORD { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQUILER_EQUIPOS> ALQUILER_EQUIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIBOS> RECIBOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA_EQUIPOS> VENTA_EQUIPOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES_SUCURSALES> CLIENTES_SUCURSALES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESUPUESTOS_VARIOS> PRESUPUESTOS_VARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES> REPARACIONES { get; set; }
    }
}
