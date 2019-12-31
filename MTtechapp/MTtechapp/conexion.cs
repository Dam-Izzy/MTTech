using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MTtechapp
{
    public class conexion
    {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-312T6MQ," +
                                                      "1433;DataBase=mt;User ID=sa; Password=MizatO01;");
        public OleDbConnection cn = new OleDbConnection("Data Source=DESKTOP-312T6MQ," +
                                                       "1433;DataBase=mt;User ID=sa; Password=MizatO01; Provider=SQLOLEDB;");
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
            catch (SqlException ex)
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
