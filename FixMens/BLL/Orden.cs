using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using FirebirdSql.Data.FirebirdClient;
using FixMens.Models;

namespace FixMens.BLL
{
    public class Orden
    {
        public OrdenModel ConsultarOrden(string nombre, int orden, string admin)
        {

            var result = getOrden(nombre, orden, admin);
            return result;
        }

        private OrdenModel getOrden(string nombre, int orden, string admin)
        {
            OrdenModel result = new OrdenModel(); //Para validar cuando no se encontro orden
            //Validación nombre mas de 5 caracteres.
            if (nombre.Length < 5)
            {
                result.ErrorMessage = "Campo Nombre debe tener mínimo 5 caracteres";
                return result;
            }
            FbConnection conn = new FbConnection();
            FbCommand cmd = new FbCommand();
            FbDataAdapter da = new FbDataAdapter();
            DataTable dt = new DataTable();
            string firebirdServer = ConfigurationManager.AppSettings["firebird.server"];
            //conn.ConnectionString = "User=SYSDBA;Password=masterkey;Database=localhost:C:\\service.fdb;DataSource=localhost;" +
            //"Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;" +
            //"MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            conn.ConnectionString = "User=SYSDBA;Password=masterkey;Database=" + firebirdServer +
           ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;" +
           "MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            cmd.Connection = conn;
            int? cod = (orden);
            //FbParameter pMatricula = new FbParameter();
            cmd.Parameters.Add("pCodigo", cod);
            cmd.Parameters.Add("pNombre", nombre);
            cmd.CommandText = "SELECT R.CODIGO, C.NOMBRES || ' ' || C.telefono || ' ' || C.celular as NOMBRES,R.FALLA,R.INFORMETALLER,P.DETALLE, P.PRESUPUESTO, I.NOMBRES AS TECNICO, R.FECHAINGRESO,R.PROMETIDO,R.FECHATERMINADO, ESTADO.NOMBRE ESTADO " +
                "FROM REPARACIONES R JOIN CLIENTES C ON R.CLIENTE = C.CODIGO " +
                "JOIN PRESUPUESTOS P ON R.CODIGO = P.IDREPARACION " +
                "JOIN INTEGRANTES I ON R.TECNICO = I.CODIGO " +
                "inner join ESTADO on estado.CODIGO = R.ESTADO "+
                "WHERE R.CODIGO = @pCodigo" + (admin != "1123581321" ? " AND C.NOMBRES CONTAINING @pNombre" : " ");
            cmd.CommandType = CommandType.Text;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                DateTime ingreso;
                DateTime prometido;
                DateTime entregado;
                result = new OrdenModel()
                {
                    NombreCliente = dt.Rows[0]["NOMBRES"].ToString(),
                    InfoCliente = dt.Rows[0]["FALLA"].ToString(),
                    InfoTecnico = dt.Rows[0]["INFORMETALLER"].ToString(),
                    Tecnico = dt.Rows[0]["TECNICO"].ToString(),
                    Presupuesto = dt.Rows[0]["DETALLE"].ToString(),
                    Precio = "$" + $"{dt.Rows[0]["PRESUPUESTO"]:0,0.00}",
                    FechaIngreso = DateTime.TryParse(dt.Rows[0]["FECHAINGRESO"].ToString(), out ingreso) ? ingreso : (DateTime?)null,
                    FechaPrometido = DateTime.TryParse(dt.Rows[0]["PROMETIDO"].ToString(), out prometido) ? prometido : (DateTime?)null,
                    FechaEntregado = DateTime.TryParse(dt.Rows[0]["FECHATERMINADO"].ToString(), out entregado) ? entregado : (DateTime?)null,
                    Estado = dt.Rows[0]["ESTADO"].ToString(),

                };
                //txtOrden.Text = dt.Rows[0]["CODIGO"].ToString();
                //txtNombreCliente.Text = dt.Rows[0]["NOMBRES"].ToString();
                //txtTecnico.Text = dt.Rows[0]["TECNICO"].ToString();
                //txtFalla.Text = dt.Rows[0]["FALLA"].ToString();
                //txtInformeTecnico.Text = dt.Rows[0]["INFORMETALLER"].ToString();
                //txtPresupuesto.Text = dt.Rows[0]["DETALLE"].ToString();
                //txtCosto.Text = dt.Rows[0]["PRESUPUESTO"].ToString() != null ? "$" + (String.Format("{0:0,0.00}", dt.Rows[0]["PRESUPUESTO"].ToString())) : string.Empty;

            }
            else
            {
                result.ErrorMessage = "Orden no encontrada";
            }
            return result;
        }
    }
}