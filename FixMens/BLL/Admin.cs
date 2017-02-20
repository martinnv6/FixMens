using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Web;
using AutoMapper;
using FirebirdSql.Data.FirebirdClient;
using FixMens.Models;
using FixMens.Models.ViewModels;

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

        public List<AdminInfoModel> GetReparacionesPorTecnico()
        {

            var toDay = DateTime.Now;

            var ventas = new List<AdminInfoModel>();
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

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0") continue;
                ventas.Add(new AdminInfoModel
                {
                    Description = row[0].ToString(),
                    Cant = int.Parse(row[1].ToString())
                });
            }
            return ventas;
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
                    Description = DateTime.Parse(row[0].ToString()).ToString("yy-MMM-dd ddd"),
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
                "select ventas.fecha, ventas.hora, ventas.total, ventas.observaciones, ventasdet.descripcion from ventas "+
                "join ventasdet                                                                                          "+
                "on ventas.SERIE = ventasdet.SERIE                                                                       "+
                "and VENTAS.NUMERO = ventasdet.NUMERO                                                                    "+
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
    }

}