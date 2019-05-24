using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MTtechapp
{
    public partial class FormGraphicClientes : Form
    {
        public FormGraphicClientes()
        {
            InitializeComponent();
            Llenargrafica();
            Llenarpagos();

        }
        conexion con = new conexion();
       
         public void Llenargrafica()
        {
            try
            {

                Series s1 = chart1.Series.Add("Municipios");
                con.Conectar();
                SqlCommand sql = new SqlCommand("SELECT dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto," +
                    " dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio,"+
                    " dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente,"+
                    " dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto,"+
                    " dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago,DATEADD(m, 1, dbo.Mensualidad.fechaPago) as corte"+
                    ", SUM(dbo.Cliente.ClavePago) as total FROM dbo.Cliente INNER JOIN dbo.Segmentacion " +
                    "ON dbo.Segmentacion.IdCliente = dbo.Cliente.idCliente INNER JOIN dbo.municipios" +
                    " ON dbo.municipios.idMunicipio = dbo.Cliente.idMunicipio INNER JOIN dbo.Mensualidades" +
                    " ON dbo.Mensualidades.idCliente = dbo.Cliente.idCliente INNER JOIN dbo.Mensualidad" +
                    " ON dbo.Mensualidades.idMensualidad = dbo.Mensualidad.idMensualidad where fechapago" +
                    "= CONVERT (date, SYSDATETIME()) group by dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto," +
                    " dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio," +
                    " dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente," +
                    " dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto," +
                    " dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago", con.conn);
                sql.ExecuteReader();
                chart1.Series[0].XValueMember = "Nombre";
                chart1.Series[0].YValueMembers = "total";
                chart1.DataBind();
                this.chart1.DataSource = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
            finally
            {
                con.Desconectar();
            }
            //while (dr.Read())
            //{
            //    s1.XValueMember = dr[0].ToString();
            //    s1.YValueMembers = dr[3].ToString();
            //    s1.Label = dr.GetString(2).ToString();
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in chart1.Series)
            {
                item.Points.Clear();
            }
            SqlCommand sql = new SqlCommand("SELECT dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto,"+
                     "dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio," +
                    "dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente,"+
                     "dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto,"+
                    "dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago, DATEADD(m, 1, dbo.Mensualidad.fechaPago) as corte"+
                    ",SUM(dbo.Cliente.ClavePago) as total FROM dbo.Cliente INNER JOIN dbo.Segmentacion"+
                    "ON dbo.Segmentacion.IdCliente = dbo.Cliente.idCliente INNER JOIN dbo.municipios"+
                     "ON dbo.municipios.idMunicipio = dbo.Cliente.idMunicipio INNER JOIN dbo.Mensualidades"+
                     "ON dbo.Mensualidades.idCliente = dbo.Cliente.idCliente INNER JOIN dbo.Mensualidad"+
                     "ON dbo.Mensualidades.idMensualidad = dbo.Mensualidad.idMensualidad"+
                    "where dbo.Mensualidad.fechaPago BETWEEN '" + dateTimePicker1.Value +"' and '"+ dateTimePicker2.Value +"'"+
                     "GROUP BY dbo.municipios.idMunicipio, dbo.Mensualidad.fechaPago,"+
                    "dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto,"+
                    "dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio,"+
                    "dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente,"+
                    "dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto,"+
                    "dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago", con.conn);
           
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.chart1.DataSource = dt;
            chart1.Series.Clear();
            Series s1 = chart1.Series.Add("Municipios");            
            s1.XValueMember = "Nombre";
            s1.YValueMembers = "total";
            this.listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow filas = dt.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["total"].ToString());
                elementos.SubItems.Add(filas["Nombre"].ToString());
                elementos.SubItems.Add(filas["total"].ToString());
                listView1.Items.Add(elementos);
            }
        }
        public void Llenarpagos()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select COUNT(C.idMunicipio) as Total , M.idMunicipio, M.Nombre,SUM(Ms.monto) as monto from Cliente C INNER JOIN municipios M on (C.idMunicipio= M.idMunicipio)inner join Mensualidad Ms on (Ms.idCliente = C.idCliente) GROUP BY M.idMunicipio, M.Nombre", con.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.listView1.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["Total"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["monto"].ToString());
                    listView1.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal " + ex);
            }
            finally
            {
                con.Desconectar();
            }
        }
    }
}
