namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.INVENTARIODET")]
    public partial class INVENTARIODET
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGOINVENTARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string ARTICULO { get; set; }

        public int CANTIDAD { get; set; }

        public int? DIFERENCIA { get; set; }
    }
}
