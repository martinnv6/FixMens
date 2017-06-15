namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PERMISOSPVPADMIN")]
    public partial class PERMISOSPVPADMIN
    {
        public int? USUARIO { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MENU { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OPCIONES { get; set; }

        [Key]
        [Column(Order = 2)]
        public float PERMISO { get; set; }
    }
}
