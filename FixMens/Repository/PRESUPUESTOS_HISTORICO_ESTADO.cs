namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.PRESUPUESTOS_HISTORICO_ESTADO")]
    public partial class PRESUPUESTOS_HISTORICO_ESTADO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPRESUPUESTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHA { get; set; }

        [Key]
        [Column(Order = 2)]
        public TimeSpan HORA { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ESTADO { get; set; }

        public virtual PRESUPUESTOS PRESUPUESTOS { get; set; }
    }
}
