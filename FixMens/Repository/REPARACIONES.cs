namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.REPARACIONES")]
    public partial class REPARACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPARACIONES()
        {
            CAMBIOS_EQUIPOS = new HashSet<CAMBIOS_EQUIPOS>();
            REPARACIONES_HISTORICO_ESTADO = new HashSet<REPARACIONES_HISTORICO_ESTADO>();
            REPARACIONES_LOG = new HashSet<REPARACIONES_LOG>();
            REPARACIONES_NOTAS = new HashSet<REPARACIONES_NOTAS>();
            RMA = new HashSet<RMA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int CLIENTE { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        public string FALLA { get; set; }

        public string OBSERVACIONES { get; set; }

        public DateTime? PROMETIDO { get; set; }

        public DateTime? FECHAINGRESO { get; set; }

        [StringLength(13)]
        public string HORAINGRESO { get; set; }

        public int RECEPCIONADO { get; set; }

        public int TECNICO { get; set; }

        public string INFORMETALLER { get; set; }

        public DateTime? FECHATERMINADO { get; set; }

        [StringLength(13)]
        public string HORATERMINADO { get; set; }

        public int ESTADO { get; set; }

        [StringLength(1)]
        public string ENTREGADO { get; set; }

        [StringLength(1)]
        public string AVISADO { get; set; }

        [Required]
        [StringLength(1)]
        public string BATERIA { get; set; }

        [Required]
        [StringLength(1)]
        public string BATERIA_ORIG { get; set; }

        [Required]
        [StringLength(1)]
        public string CARGADOR { get; set; }

        [Required]
        [StringLength(1)]
        public string CARGADOR_ORIG { get; set; }

        [StringLength(13)]
        public string PROMETIDO_HORA { get; set; }

        [Required]
        [StringLength(1)]
        public string CHIP { get; set; }

        [StringLength(40)]
        public string CHIP_NS { get; set; }

        [StringLength(20)]
        public string ORDEN_CLI { get; set; }

        [StringLength(60)]
        public string CLI_NOMBRE_EVENTUAL { get; set; }

        [StringLength(30)]
        public string TEL_EVENTUAL { get; set; }

        [Required]
        [StringLength(1)]
        public string CLI_EVENTUAL { get; set; }

        public DateTime? FECHA_ENTREGADO { get; set; }

        [StringLength(80)]
        public string CLIENTE_GARANTIA { get; set; }

        public int? SUCURSALCLI { get; set; }

        [StringLength(10)]
        public string PIN { get; set; }

        [StringLength(40)]
        public string CAMPOLIBRE1 { get; set; }

        [StringLength(40)]
        public string CAMPOLIBRE2 { get; set; }

        public DateTime? GARANTIA { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public DateTime? GARANTIA_FECHA { get; set; }

        [StringLength(20)]
        public string GARANTIA_FACTURA { get; set; }

        public int? SITUACION { get; set; }

        public int? TAREA { get; set; }

        public int? UBICACION_ENTRADA { get; set; }

        public int? UBICACION_SALIDA { get; set; }

        [StringLength(20)]
        public string REMITO_ENTREGADO { get; set; }

        [StringLength(20)]
        public string REMITO_INGRESO { get; set; }

        [StringLength(13)]
        public string BARCODE { get; set; }

        [StringLength(13)]
        public string ARTICULO { get; set; }

        public int? AREAVENTA { get; set; }

        public virtual AREASVENTA AREASVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMBIOS_EQUIPOS> CAMBIOS_EQUIPOS { get; set; }

        public virtual CLIENTES_SUCURSALES CLIENTES_SUCURSALES { get; set; }

        public virtual FICHAS_MOTORES_MONOFASICOS FICHAS_MOTORES_MONOFASICOS { get; set; }

        public virtual FICHAS_MOTORES_TRIFASICOS FICHAS_MOTORES_TRIFASICOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES_HISTORICO_ESTADO> REPARACIONES_HISTORICO_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES_LOG> REPARACIONES_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPARACIONES_NOTAS> REPARACIONES_NOTAS { get; set; }

        public virtual TAREAS TAREAS { get; set; }

        public virtual UBICACIONES UBICACIONES { get; set; }

        public virtual UBICACIONES UBICACIONES1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RMA> RMA { get; set; }
    }
}
