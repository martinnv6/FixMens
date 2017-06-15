namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.BANCOS_CUENTAS")]
    public partial class BANCOS_CUENTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCOS_CUENTAS()
        {
            BANCOS_CHEQUERAS = new HashSet<BANCOS_CHEQUERAS>();
            BANCOS_MOVIMIENTOS = new HashSet<BANCOS_MOVIMIENTOS>();
        }

        [Key]
        [StringLength(20)]
        public string NUMEROCUENTA { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? BANCO { get; set; }

        public int? MONEDA { get; set; }

        [StringLength(20)]
        public string TIPOCUENTA { get; set; }

        [StringLength(50)]
        public string EMPRESA { get; set; }

        [StringLength(80)]
        public string DIRECCION { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(50)]
        public string CIUDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SALDO { get; set; }

        public virtual BANCOS BANCOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_CHEQUERAS> BANCOS_CHEQUERAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANCOS_MOVIMIENTOS> BANCOS_MOVIMIENTOS { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }
    }
}
