namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FICHAPROVEEDORES")]
    public partial class FICHAPROVEEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FICHAPROVEEDORES()
        {
            FICHAMOVIMENTS = new HashSet<FICHAMOVIMENTS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int MONEDA { get; set; }

        public int? PROVEEDOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SALDO { get; set; }

        public int? NUMEROAPUNTE { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHAMOVIMENTS> FICHAMOVIMENTS { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual PROVEEDORES PROVEEDORES { get; set; }
    }
}
