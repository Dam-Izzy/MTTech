using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MTtechapp
{
    public class conexion
    {
        public SqlConnection conn = new SqlConnection("Data Source=192.168.0.60," +
                                                      "1433;DataBase=mt;User ID=sa; Password=yami_yonatan;");
        public OleDbConnection cn = new OleDbConnection("Data Source=192.168.0.60," +
                                                       "1433;DataBase=mt;User ID=sa; Password=yami_yonatan; Provider=SQLOLEDB;");
        public void Conectar()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        public void Desconectar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                else
                {
                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
