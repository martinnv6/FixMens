namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.EQUIPOS_CLIENTES")]
    public partial class EQUIPOS_CLIENTES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLIENTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string NS { get; set; }

        public int? CLIENTE_SUCURSAL { get; set; }
    }
}
