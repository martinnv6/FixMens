namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS_CHEQUERAS")]
    public partial class BANCOS_CHEQUERAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCOS_CHEQUERAS()
        {
            BANCOS_CHEQUES_EMITIDOS = new HashSet<BANCOS_CHEQUES_EMITIDOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int? NUMEROINICIAL { get; set; }

        public int? CANTIDAD_CHEQUES { get; set; }

        [StringLength(50)]
        public string NOTAS { get; set; }

        [StringLength(20)]
        public string NUMEROCUENTA { get; set; }

        [StringLength(10)]
        public string SERIE { get; set; }

        public virtual BANCOS_CUENTAS BANCOS_CUENTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_CHEQUES_EMITIDOS> BANCOS_CHEQUES_EMITIDOS { get; set; }
    }
}
