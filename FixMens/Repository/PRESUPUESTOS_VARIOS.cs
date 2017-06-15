namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PRESUPUESTOS_VARIOS")]
    public partial class PRESUPUESTOS_VARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESUPUESTOS_VARIOS()
        {
            PRESUPUESTOS = new HashSet<PRESUPUESTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int? CLIENTE { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(40)]
        public string CONTACTO { get; set; }

        public int? SUCURSALCLI { get; set; }

        public string OBSERVACIONES { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual CLIENTES_SUCURSALES CLIENTES_SUCURSALES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESUPUESTOS> PRESUPUESTOS { get; set; }
    }
}
