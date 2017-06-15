namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.SERVICE_HISTORICO_ESTADO")]
    public partial class SERVICE_HISTORICO_ESTADO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSERVICIO { get; set; }

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

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USUARIO { get; set; }

        public virtual ESTADO_SERVICE_DOMICILIO ESTADO_SERVICE_DOMICILIO { get; set; }

        public virtual INTEGRANTES INTEGRANTES { get; set; }

        public virtual SERVICE_A_DOMICILIO SERVICE_A_DOMICILIO { get; set; }
    }
}
