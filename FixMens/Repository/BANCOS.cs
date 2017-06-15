namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS")]
    public partial class BANCOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCOS()
        {
            BANCOS_CHEQUES_CARTERA = new HashSet<BANCOS_CHEQUES_CARTERA>();
            BANCOS_CUENTAS = new HashSet<BANCOS_CUENTAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string DIRECCION { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(120)]
        public string OBSERVACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_CHEQUES_CARTERA> BANCOS_CHEQUES_CARTERA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_CUENTAS> BANCOS_CUENTAS { get; set; }
    }
}
