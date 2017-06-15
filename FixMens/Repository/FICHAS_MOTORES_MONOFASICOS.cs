namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FICHAS_MOTORES_MONOFASICOS")]
    public partial class FICHAS_MOTORES_MONOFASICOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDREPARACION { get; set; }

        [StringLength(20)]
        public string FRECUENCIA { get; set; }

        [StringLength(20)]
        public string FRAME { get; set; }

        [StringLength(20)]
        public string RODAMFRONT { get; set; }

        [StringLength(20)]
        public string RODAMPOST { get; set; }

        [StringLength(20)]
        public string CAPARRANQUE { get; set; }

        [StringLength(20)]
        public string CAPPERMANENTE { get; set; }

        [StringLength(20)]
        public string DATOSORIGINALES { get; set; }

        public string OBSERVACIONES { get; set; }

        [StringLength(20)]
        public string RANURAS { get; set; }

        [StringLength(20)]
        public string DIAMETRO { get; set; }

        [StringLength(20)]
        public string ALTURA { get; set; }

        [StringLength(20)]
        public string TIPOPAPEL { get; set; }

        public string M_PASOS { get; set; }

        [StringLength(20)]
        public string M_GRUPOS { get; set; }

        [StringLength(20)]
        public string M_BOBINASGRUPO { get; set; }

        [StringLength(20)]
        public string M_CALIBRE { get; set; }

        [StringLength(20)]
        public string M_CANTIDAD { get; set; }

        [StringLength(20)]
        public string M_CABLESALIDA { get; set; }

        public string M_DIAGRAMAS { get; set; }

        public string A_PASOS { get; set; }

        [StringLength(20)]
        public string A_GRUPOS { get; set; }

        [StringLength(20)]
        public string A_BOBINASGRUPO { get; set; }

        [StringLength(20)]
        public string A_CALIBRE { get; set; }

        [StringLength(20)]
        public string A_CANTIDAD { get; set; }

        [StringLength(20)]
        public string A_CABLESALIDA { get; set; }

        public string A_DIAGRAMAS { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
