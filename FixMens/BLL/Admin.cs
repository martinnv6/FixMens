using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Web;
using FirebirdSql.Data.FirebirdClient;
using FixMens.Models;

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
            string stardate = DateTime.Now.AddYears(-2).AddDays(-7).ToString("yyyy-MM-dd");

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
                "GROUP by ventas.fecha,ventas.FECHA "+
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
                    Description = DateTime.Parse(row[0].ToString()).DayOfWeek.ToString(),
                    Cant = (int) Convert.ToInt64(Convert.ToDouble(row[1].ToString()))
                });
            }
            return ventas;

        }
    }
}