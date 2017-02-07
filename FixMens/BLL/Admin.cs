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
        public void GetContarReparaciones()
        {
            FbConnection conn = new FbConnection();
            FbCommand cmd = new FbCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["firebirdConnection"].ToString();
            cmd.Connection = conn;
            cmd.CommandText = "EXECUTE PROCEDURE CONTAR_REPARACIONES 1";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
        }
    }
}