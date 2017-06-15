namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.ORDENES_FOTOS_EQUIPOS")]
    public partial class ORDENES_FOTOS_EQUIPOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int ORDEN { get; set; }

        [Required]
        public byte[] FOTO { get; set; }

        [StringLength(100)]
        public string TEXTO_FOTO { get; set; }
    }
}
