namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS_MOVIMIENTOS")]
    public partial class BANCOS_MOVIMIENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCOS_MOVIMIENTOS()
        {
            BANCOS_CHEQUES_EMITIDOS = new HashSet<BANCOS_CHEQUES_EMITIDOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(20)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHA_REAL { get; set; }

        [StringLength(20)]
        public string NUMEROCUENTA { get; set; }

        [StringLength(50)]
        public string DETALLE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPORTE { get; set; }

        [StringLength(20)]
        public string TIPOMOV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_CHEQUES_EMITIDOS> BANCOS_CHEQUES_EMITIDOS { get; set; }

        public virtual BANCOS_CUENTAS BANCOS_CUENTAS { get; set; }
    }
}
