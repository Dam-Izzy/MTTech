using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                SqlCommand sql = new SqlCommand("Select COUNT(C.idMunicipio) as Total , M.idMunicipio, M.Nombre,SUM(Ms.monto) as monto from Cliente C INNER JOIN municipios M on (C.idMunicipio= M.idMunicipio)inner join Mensualidad Ms on (Ms.idCliente = C.idCliente) GROUP BY M.idMunicipio, M.Nombre", con.conn);
                sql.ExecuteReader();
                chart1.Series[0].XValueMember = "Nombre";
                chart1.Series[0].YValueMembers = "monto";
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
            string query = "Select COUNT(C.idMunicipio) as Total, M.idMunicipio, M.Nombre,SUM(Ms.monto) as monto from Cliente C INNER JOIN municipios M on(C.idMunicipio= M.idMunicipio)inner join Mensualidad Ms on(Ms.idCliente = C.idCliente) where P.fechaPago BETWEEN '" + dateTimePicker1.Value.ToShortDateString() +"'and'"+ dateTimePicker2.Value.ToShortDateString() + "' GROUP BY M.idMunicipio, M.Nombre,P.fechaPago";
            SqlCommand cmd = new SqlCommand(query, con.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.chart1.DataSource = dt;
            chart1.Series.Clear();
            Series s1 = chart1.Series.Add("Municipios");            
            s1.XValueMember = "Nombre";
            s1.YValueMembers = "monto";
            this.listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow filas = dt.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["Total"].ToString());
                elementos.SubItems.Add(filas["Nombre"].ToString());
                elementos.SubItems.Add(filas["monto"].ToString());
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
