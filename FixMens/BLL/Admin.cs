using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using FirebirdSql.Data.FirebirdClient;

namespace FixMens.BLL
{
    public class Admin
    {
        public void getContarReparaciones()
        {
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
            //int? cod = (orden);
            //FbParameter pMatricula = new FbParameter();
            
            cmd.CommandText = "EXECUTE PROCEDURE CONTAR_REPARACIONES 1";
            cmd.CommandType = CommandType.StoredProcedure;


            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
        }
    }
}