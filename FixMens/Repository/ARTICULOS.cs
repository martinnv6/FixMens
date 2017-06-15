namespace FixMens.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firebird.ARTICULOS")]
    public partial class ARTICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULOS()
        {
            DEPARTSTOCK = new HashSet<DEPARTSTOCK>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE { get; set; }

        [Required]
        [StringLength(13)]
        public string CODIGO { get; set; }

        [StringLength(20)]
        public string CODIGO_BARRAS { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? MARCA { get; set; }

        public int? MODELO { get; set; }

        public int MONEDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIOCONTADO_P { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIOLISTA_P { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COSTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PORC_GANANCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string CONTROLSTOCK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXISTENCIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MINIMO { get; set; }

        public int CATEGORIA { get; set; }

        public int IMPUESTO { get; set; }

        [Required]
        [StringLength(1)]
        public string DESCATALOGADO { get; set; }

        public byte[] FOTO { get; set; }

        public string OBSERVACIONES { get; set; }

        public int PROVEEDOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIOCONTADO_D { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PRECIOLISTA_D { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PORC_CONTADO { get; set; }

        public DateTime? FECHA_AUD { get; set; }

        public TimeSpan? HORA_AUD { get; set; }

        public string TEXTO_FACTURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXISTENCIA_ROTA { get; set; }

        public int? UBICACION { get; set; }

        public int? SUBUBICACION { get; set; }

        public virtual CATEGORIAS CATEGORIAS { get; set; }

        public virtual SUBUBICACIONES SUBUBICACIONES { get; set; }

        public virtual UBICACIONES UBICACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTSTOCK> DEPARTSTOCK { get; set; }
    }
}
