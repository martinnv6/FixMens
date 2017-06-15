namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.FICHAS_MOTORES_TRIFASICOS")]
    public partial class FICHAS_MOTORES_TRIFASICOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDREPARACION { get; set; }

        [StringLength(20)]
        public string CONEXION { get; set; }

        [StringLength(20)]
        public string FRECUENCIA { get; set; }

        [StringLength(20)]
        public string FRAME { get; set; }

        [StringLength(20)]
        public string RODAMFRONT { get; set; }

        [StringLength(20)]
        public string RODAMPOST { get; set; }

        [StringLength(20)]
        public string DATOSORIGINALES { get; set; }

        [StringLength(20)]
        public string TIPOBOBINADO { get; set; }

        [StringLength(20)]
        public string GRUPOS { get; set; }

        [StringLength(20)]
        public string BOBINASGRUPO { get; set; }

        [StringLength(20)]
        public string RANURAS { get; set; }

        [StringLength(20)]
        public string DIAMETRO { get; set; }

        [StringLength(20)]
        public string ALTURA { get; set; }

        [StringLength(20)]
        public string CANTALAMBRE { get; set; }

        [StringLength(20)]
        public string CALIBRE { get; set; }

        [StringLength(20)]
        public string TIPOPAPEL { get; set; }

        [StringLength(20)]
        public string CABLESALIDA { get; set; }

        public string OBSERVACIONES { get; set; }

        public string PASOSYDIAGRAMAS { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public virtual REPARACIONES REPARACIONES { get; set; }
    }
}
