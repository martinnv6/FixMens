namespace FixMens.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class fixmensModel : DbContext
    {
        public fixmensModel()
            : base("name=fixmensModel")
        {
        }

        public virtual DbSet<ACCESORIOS> ACCESORIOS { get; set; }
        public virtual DbSet<ALMACEN_FALLAS> ALMACEN_FALLAS { get; set; }
        public virtual DbSet<ALQUILER_EQUIPOS> ALQUILER_EQUIPOS { get; set; }
        public virtual DbSet<APARATO_MOTOR_ELEC> APARATO_MOTOR_ELEC { get; set; }
        public virtual DbSet<AREASVENTA> AREASVENTA { get; set; }
        public virtual DbSet<ARQUEO> ARQUEO { get; set; }
        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<BANCOS> BANCOS { get; set; }
        public virtual DbSet<BANCOS_CHEQUERAS> BANCOS_CHEQUERAS { get; set; }
        public virtual DbSet<BANCOS_CHEQUES_CARTERA> BANCOS_CHEQUES_CARTERA { get; set; }
        public virtual DbSet<BANCOS_CHEQUES_EMITIDOS> BANCOS_CHEQUES_EMITIDOS { get; set; }
        public virtual DbSet<BANCOS_CUENTAS> BANCOS_CUENTAS { get; set; }
        public virtual DbSet<BANCOS_MOVIMIENTOS> BANCOS_MOVIMIENTOS { get; set; }
        public virtual DbSet<BANCOS_PARTICULARES> BANCOS_PARTICULARES { get; set; }
        public virtual DbSet<CAJAS> CAJAS { get; set; }
        public virtual DbSet<CAMBIOS_EQUIPOS> CAMBIOS_EQUIPOS { get; set; }
        public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<CLIENTES_SUCURSALES> CLIENTES_SUCURSALES { get; set; }
        public virtual DbSet<COMPRAS> COMPRAS { get; set; }
        public virtual DbSet<COMPRASDET> COMPRASDET { get; set; }
        public virtual DbSet<COSTOS_SERVICIOS> COSTOS_SERVICIOS { get; set; }
        public virtual DbSet<COTIZACIONES> COTIZACIONES { get; set; }
        public virtual DbSet<CUOTAS> CUOTAS { get; set; }
        public virtual DbSet<DEPARTSTOCK> DEPARTSTOCK { get; set; }
        public virtual DbSet<DETALLEVENTAS> DETALLEVENTAS { get; set; }
        public virtual DbSet<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual DbSet<EQUIPOS_CLIENTES> EQUIPOS_CLIENTES { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<ESTADO_SERVICE_DOMICILIO> ESTADO_SERVICE_DOMICILIO { get; set; }
        public virtual DbSet<ESTADOPRESUP> ESTADOPRESUP { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<FICHAMOVIMENTS> FICHAMOVIMENTS { get; set; }
        public virtual DbSet<FICHAOPERACIONES> FICHAOPERACIONES { get; set; }
        public virtual DbSet<FICHAPROVEEDORES> FICHAPROVEEDORES { get; set; }
        public virtual DbSet<FICHAS_MOTORES_MONOFASICOS> FICHAS_MOTORES_MONOFASICOS { get; set; }
        public virtual DbSet<FICHAS_MOTORES_TRIFASICOS> FICHAS_MOTORES_TRIFASICOS { get; set; }
        public virtual DbSet<FORMASPAGO> FORMASPAGO { get; set; }
        public virtual DbSet<GASTOS> GASTOS { get; set; }
        public virtual DbSet<IMPUESTOS> IMPUESTOS { get; set; }
        public virtual DbSet<INTEGRANTES> INTEGRANTES { get; set; }
        public virtual DbSet<INVENTARIO> INVENTARIO { get; set; }
        public virtual DbSet<INVENTARIODET> INVENTARIODET { get; set; }
        public virtual DbSet<MARCA> MARCA { get; set; }
        public virtual DbSet<MEDIDAS_POTENCIA> MEDIDAS_POTENCIA { get; set; }
        public virtual DbSet<MEDIOSPAGO> MEDIOSPAGO { get; set; }
        public virtual DbSet<MESES> MESES { get; set; }
        public virtual DbSet<MODELO> MODELO { get; set; }
        public virtual DbSet<MONEDAS> MONEDAS { get; set; }
        public virtual DbSet<MORA> MORA { get; set; }
        public virtual DbSet<ORDENES_FOTOS_EQUIPOS> ORDENES_FOTOS_EQUIPOS { get; set; }
        public virtual DbSet<PAGOS> PAGOS { get; set; }
        public virtual DbSet<PRESUPUESTOS> PRESUPUESTOS { get; set; }
        public virtual DbSet<PRESUPUESTOS_HISTORICO_ESTADO> PRESUPUESTOS_HISTORICO_ESTADO { get; set; }
        public virtual DbSet<PRESUPUESTOS_VARIOS> PRESUPUESTOS_VARIOS { get; set; }
        public virtual DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public virtual DbSet<RECIBOS> RECIBOS { get; set; }
        public virtual DbSet<RECIBOS_FACTURAS> RECIBOS_FACTURAS { get; set; }
        public virtual DbSet<REPARACIONES> REPARACIONES { get; set; }
        public virtual DbSet<REPARACIONES_HISTORICO_ESTADO> REPARACIONES_HISTORICO_ESTADO { get; set; }
        public virtual DbSet<REPARACIONES_LOG> REPARACIONES_LOG { get; set; }
        public virtual DbSet<REPARACIONES_NOTAS> REPARACIONES_NOTAS { get; set; }
        public virtual DbSet<REPARACIONESREMITOS> REPARACIONESREMITOS { get; set; }
        public virtual DbSet<RMA> RMA { get; set; }
        public virtual DbSet<RUBROS> RUBROS { get; set; }
        public virtual DbSet<SERVICE_A_DOMICILIO> SERVICE_A_DOMICILIO { get; set; }
        public virtual DbSet<SERVICE_HISTORICO_ESTADO> SERVICE_HISTORICO_ESTADO { get; set; }
        public virtual DbSet<SERVICIOS_LOG> SERVICIOS_LOG { get; set; }
        public virtual DbSet<SERVICIOS_NOTAS> SERVICIOS_NOTAS { get; set; }
        public virtual DbSet<SITUACIONES> SITUACIONES { get; set; }
        public virtual DbSet<SUBUBICACIONES> SUBUBICACIONES { get; set; }
        public virtual DbSet<TAREAS> TAREAS { get; set; }
        public virtual DbSet<TIPO_APARATO> TIPO_APARATO { get; set; }
        public virtual DbSet<TIPO_RED> TIPO_RED { get; set; }
        public virtual DbSet<TIPOSCOMPROBANTES> TIPOSCOMPROBANTES { get; set; }
        public virtual DbSet<UBICACIONES> UBICACIONES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VENTA_EQUIPOS> VENTA_EQUIPOS { get; set; }
        public virtual DbSet<VENTAS> VENTAS { get; set; }
        public virtual DbSet<VENTASDET> VENTASDET { get; set; }
        public virtual DbSet<APARATO> APARATO { get; set; }
        public virtual DbSet<COMPRA_EQUIPOS> COMPRA_EQUIPOS { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<EQUIPOS_EMPRESA> EQUIPOS_EMPRESA { get; set; }
        public virtual DbSet<EQUIPOS_PRESTAMO> EQUIPOS_PRESTAMO { get; set; }
        public virtual DbSet<NUMERADORES> NUMERADORES { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<PERMISOSPVPADMIN> PERMISOSPVPADMIN { get; set; }
        public virtual DbSet<PRESUPUESTOS_MANO_OBRA> PRESUPUESTOS_MANO_OBRA { get; set; }
        public virtual DbSet<PRESUPUESTOS_MATERIALES> PRESUPUESTOS_MATERIALES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.HERTZ)
                .HasPrecision(12, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.USABLE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.SERVICE_FACTOR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.FULL_LOAD_EF)
                .HasPrecision(10, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.POWER_FACTOR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.DE_BEARING)
                .HasPrecision(10, 2);

            modelBuilder.Entity<APARATO_MOTOR_ELEC>()
                .Property(e => e.ODE_BEARING)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_FACTURA)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_RECIBO)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_NOTA_CREDITO)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_DEV_CONTADO)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_REMITO)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_FACTURA_B)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_NOTA_CREDITO_B)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_DEV_CONTADO_B)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .Property(e => e.SERIE_RECIBO_B)
                .IsFixedLength();

            modelBuilder.Entity<AREASVENTA>()
                .HasMany(e => e.REPARACIONES)
                .WithOptional(e => e.AREASVENTA)
                .HasForeignKey(e => e.AREAVENTA);

            modelBuilder.Entity<ARQUEO>()
                .Property(e => e.IMPORTEINICIAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARQUEO>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARQUEO>()
                .Property(e => e.DIFERENCIA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARQUEO>()
                .Property(e => e.CALCULADO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARQUEO>()
                .Property(e => e.CERRADA)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.CODIGO)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.CODIGO_BARRAS)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.DESCRIPCION)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIOCONTADO_P)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIOLISTA_P)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.COSTO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PORC_GANANCIA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.CONTROLSTOCK)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.EXISTENCIA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.MINIMO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.DESCATALOGADO)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIOCONTADO_D)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIOLISTA_D)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PORC_CONTADO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.EXISTENCIA_ROTA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<ARTICULOS>()
                .HasMany(e => e.DEPARTSTOCK)
                .WithRequired(e => e.ARTICULOS)
                .HasForeignKey(e => e.ARTICULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANCOS>()
                .HasMany(e => e.BANCOS_CHEQUES_CARTERA)
                .WithOptional(e => e.BANCOS)
                .HasForeignKey(e => e.BANCO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BANCOS>()
                .HasMany(e => e.BANCOS_CUENTAS)
                .WithOptional(e => e.BANCOS)
                .HasForeignKey(e => e.BANCO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BANCOS_CHEQUERAS>()
                .HasMany(e => e.BANCOS_CHEQUES_EMITIDOS)
                .WithOptional(e => e.BANCOS_CHEQUERAS)
                .HasForeignKey(e => e.CODIGO_CHEQUERA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BANCOS_CHEQUES_CARTERA>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<BANCOS_CHEQUES_CARTERA>()
                .Property(e => e.COBRADO)
                .IsFixedLength();

            modelBuilder.Entity<BANCOS_CHEQUES_CARTERA>()
                .Property(e => e.NEGOCIADO)
                .IsFixedLength();

            modelBuilder.Entity<BANCOS_CHEQUES_EMITIDOS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<BANCOS_CUENTAS>()
                .Property(e => e.SALDO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<BANCOS_CUENTAS>()
                .HasMany(e => e.BANCOS_CHEQUERAS)
                .WithOptional(e => e.BANCOS_CUENTAS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BANCOS_CUENTAS>()
                .HasMany(e => e.BANCOS_MOVIMIENTOS)
                .WithOptional(e => e.BANCOS_CUENTAS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BANCOS_MOVIMIENTOS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<BANCOS_MOVIMIENTOS>()
                .HasMany(e => e.BANCOS_CHEQUES_EMITIDOS)
                .WithOptional(e => e.BANCOS_MOVIMIENTOS)
                .HasForeignKey(e => e.CODIGO_MOVIMIENTO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CAJAS>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<CATEGORIAS>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<CATEGORIAS>()
                .Property(e => e.COFIS)
                .IsFixedLength();

            modelBuilder.Entity<CATEGORIAS>()
                .Property(e => e.SERVICIO)
                .IsFixedLength();

            modelBuilder.Entity<CATEGORIAS>()
                .HasMany(e => e.ARTICULOS)
                .WithRequired(e => e.CATEGORIAS)
                .HasForeignKey(e => e.CATEGORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.LIMITECREDITO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CP)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.LOCALIDAD)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.DEPARTAMENTO)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CONTACTO)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CLIGARANTIA)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.ABONADO)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.ALQUILER_EQUIPOS)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.RECIBOS)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.VENTA_EQUIPOS)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.CLIENTES_SUCURSALES)
                .WithRequired(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.REPARACIONES)
                .WithRequired(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.PRESUPUESTOS_VARIOS)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.CLIENTE);

            modelBuilder.Entity<CLIENTES_SUCURSALES>()
                .Property(e => e.ABONADO)
                .IsFixedLength();

            modelBuilder.Entity<CLIENTES_SUCURSALES>()
                .HasMany(e => e.PRESUPUESTOS_VARIOS)
                .WithOptional(e => e.CLIENTES_SUCURSALES)
                .HasForeignKey(e => e.SUCURSALCLI);

            modelBuilder.Entity<CLIENTES_SUCURSALES>()
                .HasMany(e => e.SERVICE_A_DOMICILIO)
                .WithOptional(e => e.CLIENTES_SUCURSALES)
                .HasForeignKey(e => e.SUCURSAL_CLI);

            modelBuilder.Entity<CLIENTES_SUCURSALES>()
                .HasMany(e => e.REPARACIONES)
                .WithOptional(e => e.CLIENTES_SUCURSALES)
                .HasForeignKey(e => e.SUCURSALCLI);

            modelBuilder.Entity<CLIENTES_SUCURSALES>()
                .HasMany(e => e.VENTA_EQUIPOS)
                .WithOptional(e => e.CLIENTES_SUCURSALES)
                .HasForeignKey(e => e.SUCURSALCLI);

            modelBuilder.Entity<COMPRAS>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<COMPRAS>()
                .Property(e => e.COFIS)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRAS>()
                .Property(e => e.IVA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRAS>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRAS>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.ARTICULO)
                .IsFixedLength();

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(15, 3);

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.PRECIO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COMPRASDET>()
                .Property(e => e.DESCRIPCION)
                .IsFixedLength();

            modelBuilder.Entity<COSTOS_SERVICIOS>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COSTOS_SERVICIOS>()
                .Property(e => e.IMPUESTOS)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COSTOS_SERVICIOS>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COTIZACIONES>()
                .Property(e => e.COMPRA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<COTIZACIONES>()
                .Property(e => e.VENTA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<CUOTAS>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<CUOTAS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<CUOTAS>()
                .Property(e => e.SALDO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<DEPARTSTOCK>()
                .Property(e => e.EXISTENCIA_SANA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<DEPARTSTOCK>()
                .Property(e => e.EXISTENCIA_ROTA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<DETALLEVENTAS>()
                .Property(e => e.SERIECOMP)
                .IsFixedLength();

            modelBuilder.Entity<DETALLEVENTAS>()
                .Property(e => e.PREUNI)
                .HasPrecision(12, 6);

            modelBuilder.Entity<DETALLEVENTAS>()
                .Property(e => e.PORCDTO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<DETALLEVENTAS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<DOCUMENTOS>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<ESTADO>()
                .HasMany(e => e.REPARACIONES_HISTORICO_ESTADO)
                .WithRequired(e => e.ESTADO1)
                .HasForeignKey(e => e.ESTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADO_SERVICE_DOMICILIO>()
                .HasMany(e => e.SERVICE_HISTORICO_ESTADO)
                .WithRequired(e => e.ESTADO_SERVICE_DOMICILIO)
                .HasForeignKey(e => e.ESTADO);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.SERIECOMP)
                .IsFixedLength();

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.SALDO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.IVA)
                .HasPrecision(12, 6);

            modelBuilder.Entity<FACTURAS>()
                .Property(e => e.COFIS)
                .HasPrecision(12, 6);

            modelBuilder.Entity<FICHAMOVIMENTS>()
                .Property(e => e.SERIEFAC)
                .IsFixedLength();

            modelBuilder.Entity<FICHAMOVIMENTS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<FICHAMOVIMENTS>()
                .Property(e => e.SALDO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<FICHAMOVIMENTS>()
                .Property(e => e.SALDADO)
                .IsFixedLength();

            modelBuilder.Entity<FICHAOPERACIONES>()
                .Property(e => e.INGRESO)
                .IsFixedLength();

            modelBuilder.Entity<FICHAOPERACIONES>()
                .HasMany(e => e.COMPRAS)
                .WithRequired(e => e.FICHAOPERACIONES)
                .HasForeignKey(e => e.TIPO_DOCUMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FICHAOPERACIONES>()
                .HasMany(e => e.FICHAMOVIMENTS)
                .WithRequired(e => e.FICHAOPERACIONES)
                .HasForeignKey(e => e.CODOP);

            modelBuilder.Entity<FICHAPROVEEDORES>()
                .Property(e => e.SALDO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<FICHAPROVEEDORES>()
                .HasMany(e => e.FICHAMOVIMENTS)
                .WithRequired(e => e.FICHAPROVEEDORES)
                .HasForeignKey(e => e.CODIGOFICHA);

            modelBuilder.Entity<FORMASPAGO>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<FORMASPAGO>()
                .Property(e => e.ABRIRCAJON)
                .IsFixedLength();

            modelBuilder.Entity<FORMASPAGO>()
                .Property(e => e.INTERES)
                .HasPrecision(8, 2);

            modelBuilder.Entity<GASTOS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<GASTOS>()
                .Property(e => e.DESCRIPCION)
                .IsFixedLength();

            modelBuilder.Entity<IMPUESTOS>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<IMPUESTOS>()
                .HasMany(e => e.PRESUPUESTOS)
                .WithOptional(e => e.IMPUESTOS1)
                .HasForeignKey(e => e.CODIMPUESTO);

            modelBuilder.Entity<INTEGRANTES>()
                .Property(e => e.TECNICO)
                .IsFixedLength();

            modelBuilder.Entity<INTEGRANTES>()
                .Property(e => e.PORC_COMISION)
                .HasPrecision(14, 4);

            modelBuilder.Entity<INTEGRANTES>()
                .Property(e => e.DESCATALOGADO)
                .IsFixedLength();

            modelBuilder.Entity<INTEGRANTES>()
                .Property(e => e.STOCKPROPIO)
                .IsFixedLength();

            modelBuilder.Entity<INTEGRANTES>()
                .Property(e => e.SOLOORDENESPROPIAS)
                .IsFixedLength();

            modelBuilder.Entity<INTEGRANTES>()
                .HasMany(e => e.DEPARTSTOCK)
                .WithRequired(e => e.INTEGRANTES)
                .HasForeignKey(e => e.TECNICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INTEGRANTES>()
                .HasMany(e => e.SERVICE_HISTORICO_ESTADO)
                .WithRequired(e => e.INTEGRANTES)
                .HasForeignKey(e => e.USUARIO);

            modelBuilder.Entity<INTEGRANTES>()
                .HasMany(e => e.USUARIOS)
                .WithOptional(e => e.INTEGRANTES)
                .HasForeignKey(e => e.IDINTEGRANTE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<INVENTARIODET>()
                .Property(e => e.ARTICULO)
                .IsFixedLength();

            modelBuilder.Entity<MARCA>()
                .HasMany(e => e.MODELO)
                .WithOptional(e => e.MARCA)
                .HasForeignKey(e => e.CODMARCA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MEDIDAS_POTENCIA>()
                .HasMany(e => e.APARATO_MOTOR_ELEC)
                .WithOptional(e => e.MEDIDAS_POTENCIA)
                .HasForeignKey(e => e.POTENCIA_MEDIDA);

            modelBuilder.Entity<MEDIOSPAGO>()
                .Property(e => e.METALICO)
                .IsFixedLength();

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.BANCOS_CHEQUES_CARTERA)
                .WithOptional(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.BANCOS_CUENTAS)
                .WithOptional(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.COMPRAS)
                .WithRequired(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.FICHAPROVEEDORES)
                .WithRequired(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.MORA)
                .WithOptional(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA);

            modelBuilder.Entity<MONEDAS>()
                .HasMany(e => e.PRESUPUESTOS)
                .WithOptional(e => e.MONEDAS)
                .HasForeignKey(e => e.MONEDA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MORA>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PAGOS>()
                .Property(e => e.SERIECOMPRECIBO)
                .IsFixedLength();

            modelBuilder.Entity<PAGOS>()
                .Property(e => e.SERIECOMP)
                .IsFixedLength();

            modelBuilder.Entity<PAGOS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS>()
                .Property(e => e.PRESUPUESTO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS>()
                .Property(e => e.IMPUESTOS)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRESUPUESTOS>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<PRESUPUESTOS>()
                .Property(e => e.FACTURADO)
                .IsFixedLength();

            modelBuilder.Entity<PRESUPUESTOS>()
                .HasMany(e => e.PRESUPUESTOS_HISTORICO_ESTADO)
                .WithRequired(e => e.PRESUPUESTOS)
                .HasForeignKey(e => e.IDPRESUPUESTO);

            modelBuilder.Entity<PRESUPUESTOS>()
                .HasMany(e => e.PRESUPUESTOS_VARIOS)
                .WithMany(e => e.PRESUPUESTOS)
                .Map(m => m.ToTable("PRESUPUESTOS_VARIOS_DETALLES").MapLeftKey("CODIGO_PRESUP").MapRightKey("CODIGO_PRESUP_V"));

            modelBuilder.Entity<PROVEEDORES>()
                .HasMany(e => e.COMPRAS)
                .WithOptional(e => e.PROVEEDORES)
                .HasForeignKey(e => e.PROVEEDOR)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PROVEEDORES>()
                .HasMany(e => e.COMPRASDET)
                .WithOptional(e => e.PROVEEDORES)
                .HasForeignKey(e => e.PROVEEDOR);

            modelBuilder.Entity<PROVEEDORES>()
                .HasMany(e => e.FICHAPROVEEDORES)
                .WithOptional(e => e.PROVEEDORES)
                .HasForeignKey(e => e.PROVEEDOR)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PROVEEDORES>()
                .HasMany(e => e.COMPRA_EQUIPOS)
                .WithOptional(e => e.PROVEEDORES)
                .HasForeignKey(e => e.PROVEEDOR);

            modelBuilder.Entity<PROVEEDORES>()
                .HasMany(e => e.RMA)
                .WithRequired(e => e.PROVEEDORES)
                .HasForeignKey(e => e.COD_PROVEEDOR);

            modelBuilder.Entity<RECIBOS>()
                .Property(e => e.SERIE_RECIBO)
                .IsFixedLength();

            modelBuilder.Entity<RECIBOS>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<RECIBOS>()
                .Property(e => e.IMPORTE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<RECIBOS>()
                .Property(e => e.MORA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.ENTREGADO)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.AVISADO)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.BATERIA)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.BATERIA_ORIG)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.CARGADOR)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.CARGADOR_ORIG)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.CHIP)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.CLI_EVENTUAL)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.CLIENTE_GARANTIA)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .Property(e => e.ARTICULO)
                .IsFixedLength();

            modelBuilder.Entity<REPARACIONES>()
                .HasMany(e => e.CAMBIOS_EQUIPOS)
                .WithOptional(e => e.REPARACIONES)
                .HasForeignKey(e => e.ORDEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<REPARACIONES>()
                .HasOptional(e => e.FICHAS_MOTORES_MONOFASICOS)
                .WithRequired(e => e.REPARACIONES)
                .WillCascadeOnDelete();

            modelBuilder.Entity<REPARACIONES>()
                .HasOptional(e => e.FICHAS_MOTORES_TRIFASICOS)
                .WithRequired(e => e.REPARACIONES)
                .WillCascadeOnDelete();

            modelBuilder.Entity<REPARACIONES>()
                .HasMany(e => e.REPARACIONES_HISTORICO_ESTADO)
                .WithRequired(e => e.REPARACIONES)
                .HasForeignKey(e => e.IDREPARACION);

            modelBuilder.Entity<REPARACIONES>()
                .HasMany(e => e.REPARACIONES_LOG)
                .WithOptional(e => e.REPARACIONES)
                .HasForeignKey(e => e.IDREPARACION)
                .WillCascadeOnDelete();

            modelBuilder.Entity<REPARACIONES>()
                .HasMany(e => e.REPARACIONES_NOTAS)
                .WithOptional(e => e.REPARACIONES)
                .HasForeignKey(e => e.IDORDEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<REPARACIONES>()
                .HasMany(e => e.RMA)
                .WithRequired(e => e.REPARACIONES)
                .HasForeignKey(e => e.IDREPARACION);

            modelBuilder.Entity<RMA>()
                .Property(e => e.IMPORTE_PROVEEDOR)
                .HasPrecision(12, 6);

            modelBuilder.Entity<RMA>()
                .Property(e => e.IMPORTE_CLIENTE)
                .HasPrecision(12, 6);

            modelBuilder.Entity<RUBROS>()
                .HasMany(e => e.GASTOS)
                .WithOptional(e => e.RUBROS)
                .HasForeignKey(e => e.RUBRO);

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .Property(e => e.INGRESADO_TEL)
                .IsFixedLength();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .Property(e => e.RESUELTO_TEL)
                .IsFixedLength();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .Property(e => e.MANTENIMIENTO)
                .IsFixedLength();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .Property(e => e.PREVENTIVO)
                .IsFixedLength();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .Property(e => e.MAIL_ENVIADO)
                .IsFixedLength();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .HasMany(e => e.SERVICE_HISTORICO_ESTADO)
                .WithRequired(e => e.SERVICE_A_DOMICILIO)
                .HasForeignKey(e => e.IDSERVICIO);

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .HasMany(e => e.SERVICIOS_LOG)
                .WithOptional(e => e.SERVICE_A_DOMICILIO)
                .HasForeignKey(e => e.IDSERVICIO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SERVICE_A_DOMICILIO>()
                .HasMany(e => e.SERVICIOS_NOTAS)
                .WithRequired(e => e.SERVICE_A_DOMICILIO)
                .HasForeignKey(e => e.IDSERVICIO);

            modelBuilder.Entity<SUBUBICACIONES>()
                .HasMany(e => e.ARTICULOS)
                .WithOptional(e => e.SUBUBICACIONES)
                .HasForeignKey(e => e.SUBUBICACION)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TAREAS>()
                .HasMany(e => e.REPARACIONES)
                .WithOptional(e => e.TAREAS)
                .HasForeignKey(e => e.TAREA);

            modelBuilder.Entity<TIPO_APARATO>()
                .HasMany(e => e.ALMACEN_FALLAS)
                .WithOptional(e => e.TIPO_APARATO1)
                .HasForeignKey(e => e.TIPO_APARATO);

            modelBuilder.Entity<TIPO_APARATO>()
                .HasMany(e => e.CAMBIOS_EQUIPOS)
                .WithOptional(e => e.TIPO_APARATO1)
                .HasForeignKey(e => e.TIPO_APARATO);

            modelBuilder.Entity<TIPO_APARATO>()
                .HasMany(e => e.COMPRA_EQUIPOS)
                .WithOptional(e => e.TIPO_APARATO1)
                .HasForeignKey(e => e.TIPO_APARATO);

            modelBuilder.Entity<TIPO_APARATO>()
                .HasMany(e => e.VENTA_EQUIPOS)
                .WithOptional(e => e.TIPO_APARATO1)
                .HasForeignKey(e => e.TIPO_APARATO)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TIPO_RED>()
                .HasMany(e => e.APARATO_MOTOR_ELEC)
                .WithOptional(e => e.TIPO_RED1)
                .HasForeignKey(e => e.TIPO_RED);

            modelBuilder.Entity<UBICACIONES>()
                .HasMany(e => e.ARTICULOS)
                .WithOptional(e => e.UBICACIONES)
                .HasForeignKey(e => e.UBICACION);

            modelBuilder.Entity<UBICACIONES>()
                .HasMany(e => e.REPARACIONES)
                .WithOptional(e => e.UBICACIONES)
                .HasForeignKey(e => e.UBICACION_ENTRADA);

            modelBuilder.Entity<UBICACIONES>()
                .HasMany(e => e.REPARACIONES1)
                .WithOptional(e => e.UBICACIONES1)
                .HasForeignKey(e => e.UBICACION_SALIDA);

            modelBuilder.Entity<UBICACIONES>()
                .HasMany(e => e.SUBUBICACIONES)
                .WithOptional(e => e.UBICACIONES)
                .HasForeignKey(e => e.UBICACION)
                .WillCascadeOnDelete();

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.TALLER)
                .IsFixedLength();

            modelBuilder.Entity<VENTA_EQUIPOS>()
                .Property(e => e.ARTICULO)
                .IsFixedLength();

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.COFIS)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.IVA)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.SUB_TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.CONTADO_PENDIENTE)
                .IsFixedLength();

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.COMISION)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.ANULADO)
                .IsFixedLength();

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.SERIE)
                .IsFixedLength();

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.ARTICULO)
                .IsFixedLength();

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(15, 3);

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.PRECIO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.TOTAL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.UTILIDAD)
                .HasPrecision(14, 4);

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.DESCRIPCION)
                .IsFixedLength();

            modelBuilder.Entity<VENTASDET>()
                .Property(e => e.PRECIO_NETO)
                .HasPrecision(14, 4);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.RUC)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.NOMBRE)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.LOCALIDAD)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.DEPARTAMENTO)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CP)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.TELEFONO)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.FAX)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CORREOE)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.PAGINAWEB)
                .IsFixedLength();

            modelBuilder.Entity<EQUIPOS_EMPRESA>()
                .Property(e => e.PRESTADO)
                .IsFixedLength();

            modelBuilder.Entity<NUMERADORES>()
                .Property(e => e.SERIEVENTAS)
                .IsFixedLength();

            modelBuilder.Entity<NUMERADORES>()
                .Property(e => e.SERIEDEVOL)
                .IsFixedLength();

            modelBuilder.Entity<NUMERADORES>()
                .Property(e => e.SERIERECIBOS)
                .IsFixedLength();

            modelBuilder.Entity<NUMERADORES>()
                .Property(e => e.SERIEDEBITO)
                .IsFixedLength();

            modelBuilder.Entity<PRESUPUESTOS_MANO_OBRA>()
                .Property(e => e.DTO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MANO_OBRA>()
                .Property(e => e.PRECIO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MANO_OBRA>()
                .Property(e => e.PRECIO_UNI)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MANO_OBRA>()
                .Property(e => e.ACEPTADO)
                .IsFixedLength();

            modelBuilder.Entity<PRESUPUESTOS_MATERIALES>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MATERIALES>()
                .Property(e => e.DTO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MATERIALES>()
                .Property(e => e.PRECIO)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MATERIALES>()
                .Property(e => e.PRECIO_UNI)
                .HasPrecision(12, 6);

            modelBuilder.Entity<PRESUPUESTOS_MATERIALES>()
                .Property(e => e.ACEPTADO)
                .IsFixedLength();
        }
    }
}
