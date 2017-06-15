namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.DEPARTSTOCK")]
    public partial class DEPARTSTOCK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TECNICO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ARTICULO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXISTENCIA_SANA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXISTENCIA_ROTA { get; set; }

        public virtual ARTICULOS ARTICULOS { get; set; }

        public virtual INTEGRANTES INTEGRANTES { get; set; }
    }
}
