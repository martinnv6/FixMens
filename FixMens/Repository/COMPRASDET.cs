namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.COMPRASDET")]
    public partial class COMPRASDET
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMERO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string SERIE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPODOCUMENTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string ARTICULO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CANTIDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PRECIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? PROVEEDOR { get; set; }

        public virtual PROVEEDORES PROVEEDORES { get; set; }
    }
}
