﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using AutoMapper;
using FirebirdSql.Data.FirebirdClient;
using FixMens.Models;
using FixMens.Models.ViewModels;
using Simple.Data.Extensions;

namespace FixMens.BLL
{
    public class Admin
    {
        public List<AdminInfoModel> GetTotalesEquiposEnTaller()
        {
            List<AdminInfoModel> list = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbCommand cmd = new FbCommand();
            FbDataAdapter da = new FbDataAdapter();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            cmd.CommandText = "select Codigo, Nombre from estado";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);

            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                list.Add(new AdminInfoModel
                {
                    Description = row[1].ToString(),
                    Cant = GetContarReparaciones(int.Parse(row[0].ToString()))
                });
            }

            return list;
        }

        public int GetContarReparaciones(int estadoId)
        {
            FbConnection conn = new FbConnection();
            FbCommand cmd = new FbCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            cmd.Parameters.Add("pEstadoId", estadoId);
            cmd.CommandText = "EXECUTE PROCEDURE CONTAR_REPARACIONES @pEstadoId";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        /// <summary>
        /// Metodo para consultar las ventas del dia actual y 3 dias antes
        /// </summary>
        /// <returns>Ventas del día, en enteros</returns>
        public List<AdminInfoModel> GetVentasDia()
        {
            string stardate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

            var ventas = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select ventas.fecha,sum(ventas.total) as ventas from  VENTAS " +
                "where ventas.fecha > '" + stardate + "' " +
                "and ventas.contado_pendiente=\'N\' " +
                "and ventas.fecha_contado_pendiente is NULL " +
                "and ventas.tipodocumento=1 " +
                "GROUP by ventas.fecha " +
                "ORDER BY ventas.fecha DESC";
            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = (int)Convert.ToInt64(Convert.ToDouble(row[1].ToString()))
                });
            }
            return ventas;

        }

        public List<AdminInfoModel> GetEgresos()
        {
            string stardate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

            var ventas = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select gastos.fecha, sum(GASTOS.importe) as gastos " +
                "from gastos " +
                "where gastos.fecha > '" + stardate + "' " +
                "GROUP by gastos.fecha " +
                "ORDER BY gastos.fecha DESC";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);



            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = (int)Convert.ToInt64(Convert.ToDouble(row[1].ToString()))
                });
            }
            return ventas;
        }

        public List<AdminInfoModelUnion> GetReparacionesPorTecnico()
        {

            var toDay = DateTime.Now;

            var ventas = new List<AdminInfoModelUnion>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select INTEGRANTES.NOMBRES, count(*) as Cantidad from REPARACIONES " +
                "inner join INTEGRANTES on INTEGRANTES.CODIGO = reparaciones.TECNICO " +
                "where REPARACIONES.FECHATERMINADO = '" + toDay.ToString("yyyy-MM-dd") + "' " +
                "Group by INTEGRANTES.NOMBRES";


            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();
            var diagnosticados = CountMovementStatus(toDay);
            foreach (DataRow row in dt.Rows)
            {
                var revisados = diagnosticados.FirstOrDefault(x => x.Description == row[0].ToString());
                if (row[0].ToString() == "0" && revisados == null) continue;
                

                
                    ventas.Add(new AdminInfoModelUnion
                    {
                        Description = row[0].ToString(),
                        Cant = int.Parse(row[1].ToString()),
                        Cant2 = revisados?.Cant ?? 0,
                        Cant3 = 0//int.Parse(row[3].ToString())
                    });
            }
            return ventas;
            
        }

        public List<ReparacionesModel> GetReparacionesPorTecnico_Detalle(string nombre)
        {
            var toDay = DateTime.Now;

            var reparaciones = new List<ReparacionesModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select REPARACIONES.codigo,                                                    " +
                "aparato.MARCA,                                                                 " +
                "aparato.MODELO,                                                                " +
                "REPARACIONES.falla,                                                            " +
                "REPARACIONES.informetaller,                                                    " +
                "presupuestos.DETALLE,                                                          " +
                "REPARACIONES.horaterminado,                                                    " +
                "REPARACIONES.entregado,                                                        " +
                "presupuestos.FACTURADO,                                                        " +
                "reparaciones.FECHA_ENTREGADO,                                                  " +
                "presupuestos.TOTAL                                                             " +
                "from REPARACIONES                                                              " +
                "inner join INTEGRANTES on INTEGRANTES.CODIGO = reparaciones.TECNICO            " +
                "inner join aparato on aparato.ns = reparaciones.ns                             " +
                "inner join presupuestos on presupuestos.IDREPARACION = reparaciones.codigo     " +
                "where integrantes.NOMBRES = '" + nombre + "'                                         " +
                "and reparaciones.FECHATERMINADO = '" + toDay.ToString("yyyy-MM-dd") + "'       ";


            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                reparaciones.Add(new ReparacionesModel
                {
                    HoraTerminado = row[6].ToString(),
                    Codigo = int.Parse(row[0].ToString()),
                    Marca = row[1].ToString(),
                    Modelo = row[2].ToString(),
                    Falla = row[3].ToString(),
                    InformeTeller = row[4].ToString(),
                    DetallePresupuesto = row[5].ToString(),
                    Entregado = Convert.ToChar(row[7]),
                    Facturado = Convert.ToChar(row[8]),
                    FechaEntrega = row[9].ToString() != "" ? DateTime.Parse(row[9].ToString()).ToShortDateString() : "",
                    Total = Convert.ToSingle(row[10])

                });
            }
            return reparaciones;
        }

        public List<AdminInfoModelUnion> GetReparacionesPorTecnicoSemanal()
        {

            var toDay = DateTime.Now;

            var ventas = new List<AdminInfoModelUnion>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            int dayOfWeek = (int)toDay.DayOfWeek;
            DateTime startOfWeek = toDay.AddDays(-dayOfWeek);
            cmd.CommandText =
             "with t1 as (select INTEGRANTES.NOMBRES , count(*) as Cantidad from REPARACIONES " +
             "inner join INTEGRANTES on INTEGRANTES.CODIGO = reparaciones.TECNICO            " +
             "where REPARACIONES.FECHATERMINADO BETWEEN '" + startOfWeek.AddDays(-7).ToString("yyyy-MM-dd") + "' AND  '" + startOfWeek.AddDays(-1).ToString("yyyy-MM-dd") + "' " +
             "Group by INTEGRANTES.NOMBRES)                                                  " +
             ", t2 as (                                                                      " +
             "select INTEGRANTES.NOMBRES, count(*) as Cantidad from REPARACIONES             " +
             "inner join INTEGRANTES on INTEGRANTES.CODIGO = reparaciones.TECNICO            " +
             "where REPARACIONES.FECHATERMINADO BETWEEN '" + startOfWeek.ToString("yyyy-MM-dd") + "' AND  '" + toDay.ToString("yyyy-MM-dd") + "' " +
             "Group by INTEGRANTES.NOMBRES)                                                  " +
             "select* from t1                                                                " +
             "full outer join t2 on t1.Nombres = t2.nombres                                  ";



            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModelUnion
                {
                    Description = row[0] != DBNull.Value ? row[0].ToString() : row[2].ToString(),
                    Cant = int.Parse(row[1] != DBNull.Value ? row[1].ToString() : "0"),

                    Cant2 = int.Parse(row[3] != DBNull.Value ? row[3].ToString() : "0")
                });
            }
            return ventas;
        }

        public List<AdminInfoModel> GetEquiposIngresados()
        {
            var equiposIngresados = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "SELECT FIRST 7 FECHAINGRESO AS FECHA, COUNT(*) AS CANTIDAD FROM REPARACIONES " +
                "WHERE FECHAINGRESO IS NOT NULL " +
                "GROUP BY FECHAINGRESO " +
                "ORDER BY FECHAINGRESO DESC ";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);

            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                equiposIngresados.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = int.Parse(row[1].ToString())
                });
            }
            return equiposIngresados;

        }
        public List<AdminInfoModel> GetEquiposEntregados()
        {
            var equiposIngresados = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "SELECT FIRST 7 FECHA_ENTREGADO AS FECHA, COUNT(*) AS CANTIDAD FROM REPARACIONES " +
                "WHERE FECHA_ENTREGADO IS NOT NULL                                              " +
                "GROUP BY FECHA_ENTREGADO                                                       " +
                "ORDER BY FECHA_ENTREGADO DESC                                                  ";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);

            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                equiposIngresados.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = int.Parse(row[1].ToString())
                });
            }
            return equiposIngresados;

        }

        public List<DetalleEgresos> GetDetalleEgresos(DateTime fecha)
        {
            List<DetalleEgresos> detalle = new List<DetalleEgresos>();




            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =

                "select fecha, hora, importe, descripcion from gastos " +
                "where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' " +
                "order by fecha desc                                 ";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                detalle.Add(new DetalleEgresos
                {
                    Fecha = DateTime.Parse(row[0].ToString()),
                    Hora = DateTime.Parse(row[1].ToString()),
                    Cantidad = float.Parse(row[2].ToString()),
                    Descripcion = row[3].ToString()

                });
            }
            return detalle;


        }

        public List<DetalleEgresos> GetDetalleVentas(DateTime fecha)
        {
            List<DetalleEgresos> detalle = new List<DetalleEgresos>();




            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select ventas.fecha, ventas.hora, ventas.total, ventas.observaciones, ventasdet.descripcion from ventas " +
                "join ventasdet                                                                                          " +
                "on ventas.SERIE = ventasdet.SERIE                                                                       " +
                "and VENTAS.NUMERO = ventasdet.NUMERO                                                                    " +
                "where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' " +
                "order by fecha, hora asc                                                                                    ";


            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                detalle.Add(new DetalleEgresos
                {
                    Fecha = DateTime.Parse(row[0].ToString()),
                    Hora = DateTime.Parse(row[1].ToString()),
                    Cantidad = float.Parse(row[2].ToString()),
                    Descripcion = row[3] + " " + row[4]

                });
            }
            return detalle;


        }


        public List<ReparacionesModel> GetEntregados_Detalle(DateTime fecha, string tipoConsulta)
        {


            var reparaciones = new List<ReparacionesModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            string condition = "";
            switch (tipoConsulta)
            {
                case "Entregados":
                    condition = "and reparaciones.fecha_entregado = '" + fecha.ToString("yyyy-MM-dd") + "'       ";
                    break;
                case "Ingresados":
                    condition = "and reparaciones.fechaIngreso = '" + fecha.ToString("yyyy-MM-dd") + "'       ";
                    break;
                case "Entregados no facturados":
                    condition = "and reparaciones.ENTREGADO = 'S'                                            " +
                    "and PRESUPUESTOS.FACTURADO = 'N'                                              " +
                    "and reparaciones.FECHA_ENTREGADO >= '2017-02-17'                                              " +
                    "and presupuestos.TOTAL > 0 order by reparaciones.FECHA_ENTREGADO desc ";
                    break;
                case "NoFacturados"://By Date
                    condition = "and reparaciones.ENTREGADO = 'S'                                            " +
                    "and PRESUPUESTOS.FACTURADO = 'N'                                              " +
                    "and presupuestos.TOTAL > 0" +
                    "and Reparaciones.FECHA_ENTREGADO = '"+ fecha.ToString("yyyy-MM-dd") + "' "+
                    " order by reparaciones.FECHA_ENTREGADO desc ";
                    break;


            }


            cmd.CommandText =
                "select REPARACIONES.codigo,                                                    " +
               //ToDo: Verificar si se debe agregar nombre o no por privacidad //"select clientes.nombre,                                                    " +
                "aparato.MARCA,                                                                 " +
                "aparato.MODELO,                                                                " +
                "REPARACIONES.falla,                                                            " +
                "REPARACIONES.informetaller,                                                    " +
                "presupuestos.DETALLE,                                                          " +
                "REPARACIONES.horaterminado,                                                    " +
                "REPARACIONES.entregado,                                                        " +
                "presupuestos.FACTURADO,                                                        " +
                "reparaciones.FECHA_ENTREGADO,                                                  " +
                "presupuestos.TOTAL                                                             " +
                "from REPARACIONES                                                              " +
                "inner join clientes on clientes.CODIGO = reparaciones.CLIENTE "+
                "inner join INTEGRANTES on INTEGRANTES.CODIGO = reparaciones.TECNICO            " +
                "inner join aparato on aparato.ns = reparaciones.ns                             " +
                "inner join presupuestos on presupuestos.IDREPARACION = reparaciones.codigo     " + condition;


            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                reparaciones.Add(new ReparacionesModel
                {
                    HoraTerminado = row[6].ToString(),
                    Codigo = int.Parse(row[0].ToString()),
                    Marca = row[1].ToString(),
                    Modelo = row[2].ToString(),
                    Falla = row[3].ToString(),
                    InformeTeller = row[4].ToString(),
                    DetallePresupuesto = row[5].ToString(),
                    Entregado = Convert.ToChar(row[7]),
                    Facturado = Convert.ToChar(row[8]),
                    FechaEntrega = row[9].ToString() != "" ? DateTime.Parse(row[9].ToString()).ToShortDateString() : "",
                    Total = row[10].ToString() != "" ? Convert.ToSingle(row[10]) : 0

                });
            }
            return reparaciones;

        }

        public float GetEquiposEntregadosNoFacturados()
        {
            FbConnection conn = new FbConnection();
            FbCommand cmd = new FbCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;

            cmd.CommandText = " SELECT SUM(Presupuestos.TOTAL)from REPARACIONES " +
                    "inner join presupuestos on presupuestos.IDREPARACION = reparaciones.codigo    " +
                    "where reparaciones.ENTREGADO = 'S'                                            " +
                    "and PRESUPUESTOS.FACTURADO = 'N'                                              " +
                    "and reparaciones.FECHA_ENTREGADO >= '2017-02-17'                                              " +
                    "and presupuestos.TOTAL > 0                                                  ";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            float id = float.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return id;

        }

        public List<ArqueoViewModel> GetArqueo(DateTime startDate, DateTime endDate, string tipoConsulta)
        {
            var reparaciones = new List<ArqueoViewModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            string condition = "";
            switch (tipoConsulta)
            {
                case "MesActual":
                case "MesAnterior":
                    condition = "and ARQUEO.FECHA BETWEEN '" + startDate.ToString("yyyy-MM-dd") + "' AND '" + endDate.ToString("yyyy-MM-dd") + "' " +
                                "AND ARQUEO.CERRADA = 'S' ";
                    break;



            }


            cmd.CommandText =
                "SELECT ARQUEO.FECHA, ARQUEO.IMPORTEINICIAL,ARQUEO.TOTAL, ARQUEO.CALCULADO, ARQUEO.DIFERENCIA FROM ARQUEO " +
                "WHERE ARQUEO.CAJA = 1                                                                                   " +
                condition +
                "ORDER BY ARQUEO.FECHA DESC ";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                reparaciones.Add(new ArqueoViewModel
                {
                    Fecha = Convert.ToDateTime(row[0].ToString()),
                    InicioCaja = Convert.ToDecimal(row[1].ToString()),
                    Declarado = Convert.ToDecimal(row[2].ToString()),
                    Calculado = Convert.ToDecimal(row[3].ToString()),
                    Diferencia = Convert.ToDecimal(row[4].ToString())




                });
            }
            return reparaciones;
        }

        public List<ConciliacionViewModel> GetConciliacion()
        {
            var reparaciones = new List<ConciliacionViewModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            string condition = "";



            cmd.CommandText =
                "with t1 as(" +
                    "select reparaciones.FECHA_ENTREGADO, sum(PRESUPUESTOS.TOTAL) as Total from reparaciones " +
                    "inner join presupuestos on presupuestos.IDREPARACION = reparaciones.CODIGO             " +
                    "where reparaciones.ENTREGADO = 'S'                                                     " +
                    "and presupuestos.FACTURADO = 'N'                                                       " +
                    "and Total > 0                                                                          " +
                    "group by reparaciones.FECHA_ENTREGADO                                                  " +
                    ")                                                                                      " +
                    "SELECT ARQUEO.FECHA, ARQUEO.IMPORTEINICIAL,                                            " +
                    "ARQUEO.TOTAL, ARQUEO.CALCULADO, ARQUEO.DIFERENCIA,                                     " +
                    "t1.TOTAL NoFacturados                                                                  " +
                    "FROM ARQUEO                                                                            " +
                    "inner join t1 on t1.fecha_entregado = arqueo.FECHA                                     " +
                    "WHERE ARQUEO.CAJA = 1                                                                  " +
                    "AND ARQUEO.CERRADA = 'S'                                                               " +
                    "AND t1.FECHA_ENTREGADO >= '2017-02-17'                                        " +
                    "ORDER BY ARQUEO.FECHA DESC";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                reparaciones.Add(new ConciliacionViewModel
                {
                    Fecha = Convert.ToDateTime(row[0].ToString()),
                    InicioCaja = Convert.ToDecimal(row[1].ToString()),
                    Declarado = Convert.ToDecimal(row[2].ToString()),
                    Calculado = Convert.ToDecimal(row[3].ToString()),
                    Diferencia = Convert.ToDecimal(row[4].ToString()),
                    NoFacturados = Convert.ToDecimal(row[5].ToString()),
                    Conciliacion = Convert.ToDecimal(row[5].ToString()) - Convert.ToDecimal(row[4].ToString()),
                });

            }
            return reparaciones;
        }

        public List<DetalleEgresos> GetAnticiposEgresos(DateTime? fecha, bool soloAnticipos)
        {
            string condition = "";
            if (!fecha.HasValue) { fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); }
            List<DetalleEgresos> detalle = new List<DetalleEgresos>();




            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;

            if (soloAnticipos)
            {
                condition = "And(                                                " +
                            "gastos.DESCRIPCION like '%ANTICIPO%'                " +
                            "or GASTOS.DESCRIPCION LIKE '%anticipo%'             " +
                            "or GASTOS.DESCRIPCION LIKE '%Pago%'             " +
                            "or GASTOS.DESCRIPCION LIKE '%pago%'             " +
                            "or GASTOS.DESCRIPCION LIKE '%PAGO%'             " +
                            "or gastos.Descripcion like '%Anticipo%')            ";

            }

            cmd.CommandText =

                "select fecha, hora, importe, descripcion from gastos " +
                "where fecha > '01-01-2017'                          " +
                condition +
                "order by fecha desc                                 " ;

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                detalle.Add(new DetalleEgresos
                {
                    Fecha = DateTime.Parse(row[0].ToString()),
                    Hora = DateTime.Parse(row[1].ToString()),
                    Cantidad = float.Parse(row[2].ToString()),
                    Descripcion = row[3].ToString()

                });
            }
            return detalle;
            
        }

        public List<AdminInfoModel> GetCompras()
        {
            string stardate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

            var ventas = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select COMPRAS.FECHA, SUM(COMPRAS.TOTAL) AS Total "+
                "from COMPRAS                                      "+
                "WHERE COMPRAS.FECHA > '"+stardate+"'                "+
                "GROUP by COMPRAS.FECHA                            "+
                "ORDER BY COMPRAS.fecha DESC ";                      
            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = (int)Convert.ToInt64(Convert.ToDouble(row[1].ToString()))
                });
            }
            return ventas;
        }

        public List<DetalleCompras> GetDetalleCompras(DateTime fecha)
        {
            List<DetalleCompras> detalle = new List<DetalleCompras>();




            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                " select  " +
                "compras.FECHA, " +
                "comprasdet.SERIE, comprasdet.NUMERO, PROVEEDORES.NOMBRE , " +
                "comprasdet.CANTIDAD, comprasdet.DESCRIPCION, comprasdet.PRECIO, " +
                "comprasdet.TOTAL, articulos.PRECIOCONTADO_P, articulos.EXISTENCIA " +
                "from comprasdet                                                  " +
                "inner join compras on compras.SERIE = comprasdet.serie           " +
                "and compras.numero = comprasdet.numero                           " +
                "and compras.proveedor = comprasdet.proveedor                     " +
                "inner join PROVEEDORES on proveedores.codigo = COMPRASDET.PROVEEDOR " +
                "inner join ARTICULOS on articulos.CODIGO = comprasdet.ARTICULO     " +
                "where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' ";
               

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                detalle.Add(new DetalleCompras()
                {
                    Fecha = DateTime.Parse(row[0].ToString()),   
                    SerieYNumero                 = row[1] + "-" + row[2],
                    Proveedor = row[3].ToString(),
                    Cantidad = int.Parse(row[4].ToString()),
                    Descripcion = row[5].ToString(),
                    CostoU = float.Parse(row[6].ToString()),
                    Total = float.Parse(row[7].ToString()),
                    Precio = float.Parse(row[8].ToString()),
                    Stock = int.Parse(row[9].ToString())
                    
                });
            }
            return detalle;

        }

        public static void sendEmailToCreateInvoice(FacturaModel model)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("martin.nv6@gmail.com", "Said2011");

            var body = "Nombre Fiscal: " + model.nombreFiscal + "\n" +
                       "Calle y número: " + model.calleynumero + "\n" +
                       "Colonia: " + model.colonia + "\n" +
                       "Municipio: " + model.municipio + "\n" +
                       "Estado: " + model.estado + "\n" +
                       "CP: " + model.cp + "\n" +
                       "RFC: " + model.rfc + "\n" +
                       "Teléfono: " + model.telefono + "\n" +
                       "Correo: " + model.email + "\n" +
                       "Ticket/Orden: " + model.ticket + "\n" +
                       "Comentario: " + model.comentario + "\n" ;




            MailMessage mm = new MailMessage("donotreply@domain.com", "martin_nv6@hotmail.com", "FixMens - Comprobante Fiscal en Proceso", "La factura con los datos: \n\n" + body + "\n\nSe encuentra en proceso con nuestro personal de contabilidad, cualquier duda haremos contacto con usted \n\n\n http://www.fixmens.com.mx (01) 828-284-0220");
            mm.To.Add(new MailAddress(model.email, model.nombreFiscal));
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        public List<AdminInfoModel> CountMovementStatus(DateTime? fecha)
        {

            DateTime fecha2;

            if (fecha == null)
            {
                fecha2 = DateTime.Now;
            }
            else
            {
                fecha2 = (DateTime)fecha;
            }
            var result = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select integrantes.NOMBRES, count(*) from REPARACIONES_HISTORICO_ESTADO        " +
                "inner join ESTADO on ESTADO.CODIGO = REPARACIONES_HISTORICO_ESTADO.ESTADO                      " +
                "inner join reparaciones on reparaciones.CODIGO = REPARACIONES_HISTORICO_ESTADO.IDREPARACION    " +
                "inner join integrantes on integrantes.CODIGO = reparaciones.TECNICO                            " +
                "where reparaciones_historico_estado.fecha = '" + fecha2.ToString("yyyy-MM-dd") + "' " +
                "and estado.NOMBRE not in ('Sin Revisar' , 'Reparación Terminada')                              "+
                "group by integrantes.NOMBRES ";

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                result.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = int.Parse(row[1].ToString())
                    
                   

                });
            }
            return result;
            
        }


        public List<MovementStatusViewModel> GetMovementStatus(DateTime? fecha)
        {
            DateTime fecha2;

            if (fecha == null)
            {
                fecha2 = DateTime.Now;
            }
            else
            {
                fecha2 = (DateTime) fecha;
            }
            var result = new List<MovementStatusViewModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;


            cmd.CommandText =
                "select reparaciones_historico_estado.hora,reparaciones.FECHAINGRESO, integrantes.NOMBRES, reparaciones.CODIGO, estado.NOMBRE from REPARACIONES_HISTORICO_ESTADO " +
                "inner join ESTADO on ESTADO.CODIGO = REPARACIONES_HISTORICO_ESTADO.ESTADO " +
                "inner join reparaciones on reparaciones.CODIGO = REPARACIONES_HISTORICO_ESTADO.IDREPARACION " +
                "inner join integrantes on integrantes.CODIGO = reparaciones.TECNICO " +
                "where REPARACIONES_HISTORICO_ESTADO.FECHA = '" + fecha2.ToString("yyyy-MM-dd") + "' " +
                "and estado.NOMBRE <> 'Sin Revisar' "+
                "order by reparaciones_historico_estado.hora asc ";

               


            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;


            da.Fill(dt);


            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                result.Add(new MovementStatusViewModel
                {
                    HoraMovimiento = TimeSpan.Parse(row[0].ToString()),
                    FechaIngreso = DateTime.Parse(row[1].ToString()),
                    Tecnico = row[2].ToString(),
                    Codigo = int.Parse(row[3].ToString()),
                    Status = row[4].ToString()

                });
            }
            return result;
        }

        public List<AdminInfoModel> Ganancias()
        {
            string stardate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");

            var ventas = new List<AdminInfoModel>();
            FbConnection conn = new FbConnection();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand();
            DataTable dt = new DataTable();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;

            //ToDo: Esta es la manera con la que el sistema ingresa en campo la utilidad, pero debe calcularse para el caso de FixMens
            cmd.CommandText =
                "select ventas.fecha, sum(ventasdet.UTILIDAD) from VENTASDET "+
                "inner join ventas on ventasdet.SERIE = ventas.SERIE and ventasdet.NUMERO = ventas.NUMERO "+
                "where ventas.fecha > '" + stardate + "' " +                                                                                       
                "group by ventas.fecha                                                                   "+
                "order by ventas.fecha desc                                                             ";
              

            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);



            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = (int)Convert.ToInt64(Convert.ToDouble(row[1].ToString()))
                });
            }
            return ventas;
        }

        public Totales GetTotales()
        {
            Totales total = new Totales();
            return null;

        }
    }

}