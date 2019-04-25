using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MTtechapp
{
    public class conexion
    {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3BFETIO," +
                                                      "1433;DataBase=mt;User ID=sa; Password=32752;");
        public OleDbConnection cn = new OleDbConnection("Data Source=DESKTOP-3BFETIO," +
                                                       "1433;DataBase=mt;User ID=sa; Password=32752; Provider=SQLOLEDB;");
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
