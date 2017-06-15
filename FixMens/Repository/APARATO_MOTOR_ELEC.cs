namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.APARATO_MOTOR_ELEC")]
    public partial class APARATO_MOTOR_ELEC
    {
        [Key]
        [StringLength(40)]
        public string NS { get; set; }

        [StringLength(30)]
        public string CATALOG_NUMBER { get; set; }

        [StringLength(25)]
        public string HP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HERTZ { get; set; }

        [StringLength(30)]
        public string VOLTAGE { get; set; }

        public int? TIPO_RED { get; set; }

        [StringLength(30)]
        public string FULL_LOAD_AMPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? USABLE { get; set; }

        [StringLength(25)]
        public string RPM { get; set; }

        [StringLength(10)]
        public string FRAME_SIZE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SERVICE_FACTOR { get; set; }

        [StringLength(10)]
        public string RATING { get; set; }

        [StringLength(5)]
        public string LOCKED_ROTOR_CODE { get; set; }

        [StringLength(5)]
        public string NEMA_DESIGN_CODE { get; set; }

        [StringLength(5)]
        public string INSULATION_CLASS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FULL_LOAD_EF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? POWER_FACTOR { get; set; }

        [StringLength(10)]
        public string ENCLOSURE { get; set; }

        [StringLength(10)]
        public string BALDOR_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DE_BEARING { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ODE_BEARING { get; set; }

        [StringLength(15)]
        public string ELECTRICAL_SP { get; set; }

        [StringLength(10)]
        public string MECH_SP_NUMBER { get; set; }

        [StringLength(10)]
        public string BASE { get; set; }

        [StringLength(10)]
        public string MOUNTING { get; set; }

        public int? POTENCIA_MEDIDA { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public virtual MEDIDAS_POTENCIA MEDIDAS_POTENCIA { get; set; }

        public virtual TIPO_RED TIPO_RED1 { get; set; }
    }
}
