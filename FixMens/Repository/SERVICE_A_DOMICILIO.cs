namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.SERVICE_A_DOMICILIO")]
    public partial class SERVICE_A_DOMICILIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICE_A_DOMICILIO()
        {
            SERVICE_HISTORICO_ESTADO = new HashSet<SERVICE_HISTORICO_ESTADO>();
            SERVICIOS_LOG = new HashSet<SERVICIOS_LOG>();
            SERVICIOS_NOTAS = new HashSet<SERVICIOS_NOTAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        public int CLIENTE { get; set; }

        public string PROBLEMA { get; set; }

        public string OBSERVACIONES { get; set; }

        public DateTime? FECHASOLICITUD { get; set; }

        [StringLength(13)]
        public string HORASOLICITUD { get; set; }

        public int RECEPCIONADO { get; set; }

        public int TECNICO { get; set; }

        public string SOLUCION { get; set; }

        public DateTime? FECHAFINALIZADO { get; set; }

        [StringLength(13)]
        public string HORAFINALIZADO { get; set; }

        public int ESTADO { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(13)]
        public string HORA { get; set; }

        [StringLength(40)]
        public string NS { get; set; }

        [StringLength(13)]
        public string HORARESPUESTA { get; set; }

        public DateTime? FECHARESPUESTA { get; set; }

        [StringLength(15)]
        public string TIEMPORESPUESTA { get; set; }

        [StringLength(15)]
        public string TIEMPOEMPLEADO { get; set; }

        [StringLength(1)]
        public string INGRESADO_TEL { get; set; }

        [StringLength(1)]
        public string RESUELTO_TEL { get; set; }

        [StringLength(1)]
        public string MANTENIMIENTO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        [StringLength(40)]
        public string CAMPOLIBRE1 { get; set; }

        [StringLength(40)]
        public string CAMPOLIBRE2 { get; set; }

        [StringLength(20)]
        public string ORDEN_CLI { get; set; }

        public int? SUCURSAL_CLI { get; set; }

        [StringLength(1)]
        public string PREVENTIVO { get; set; }

        public int? GRADO { get; set; }

        [StringLength(1)]
        public string MAIL_ENVIADO { get; set; }

        public virtual CLIENTES_SUCURSALES CLIENTES_SUCURSALES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_HISTORICO_ESTADO> SERVICE_HISTORICO_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS_LOG> SERVICIOS_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS_NOTAS> SERVICIOS_NOTAS { get; set; }
    }
}
