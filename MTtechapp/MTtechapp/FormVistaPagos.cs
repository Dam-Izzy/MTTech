using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormVistaPagos : Form
    {
        int valor;
        conexion cnn = new conexion();

        public FormVistaPagos( int valor)
        {
            InitializeComponent();
            this.valor = valor;
        }
        private void FormVistaPagos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.DataBindings.Clear();
            CargaPagos();
            this.reportViewer1.RefreshReport();
        }

        private DataTable GetPagos()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT Cliente.idCliente, Cliente.NombreCompleto, Cliente.telefono, Cliente.direccion, Cliente.comentario, Cliente.activo, Cliente.idMunicipio, Cliente.FechaInstalacion, Cliente.ClavePago, municipios.Nombre, Mensualidad.Enero, Mensualidad.Febrero, Mensualidad.Marzo, Mensualidad.Abril, Mensualidad.Mayo, Mensualidad.Junio, Mensualidad.Julio, Mensualidad.Agosto, Mensualidad.Septiembre, Mensualidad.Octubre, Mensualidad.Noviembre,Mensualidad.Diciembre, Cliente.equipo, Mensualidad.anio FROM Cliente INNER JOIN municipios ON Cliente.idMunicipio = municipios.idMunicipio INNER JOIN Mensualidad ON Cliente.idCliente = Mensualidad.idCliente WHERE(Cliente.idMunicipio = "+ valor +") AND (YEAR(Mensualidad.anio) = YEAR(GETDATE()))", cnn.conn);
                //cmd.Parameters.AddWithValue("@fecha",SqlDbType.DateTime).SqlValue = dtpfecha.Value.ToShortDateString();
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }
        public void CargaPagos()
        {
            try
            {
                List<Municipio> pagos = new List<Municipio>();
                foreach (DataRow item in GetPagos().Rows)
                {
                    Municipio cl = new Municipio();
                    cl.idCliente = Convert.ToInt32(item[0].ToString());
                    cl.NombreCompleto = item[1].ToString();
                    cl.telefono = item[2].ToString();
                    cl.direccion = item[3].ToString();
                    cl.Nombre = item[9].ToString();
                    cl.clave = Convert.ToInt32(item[8].ToString());
                    cl.activo = Convert.ToBoolean(item[5].ToString());
                    cl.fechainstalacion = Convert.ToDateTime(item[7].ToString());
                    cl.Enero = item[10].ToString();
                    cl.Febrero = item[11].ToString();
                    cl.Marzo = item[12].ToString();
                    cl.Abril = item[13].ToString();
                    cl.Mayo = item[14].ToString();
                    cl.Junio = item[15].ToString();
                    cl.Julio = item[16].ToString();
                    cl.Agosto = item[17].ToString();
                    cl.Septiembre = item[18].ToString();
                    cl.Octubre = item[19].ToString();
                    cl.Noviembre = item[20].ToString();
                    cl.Diciembre = item[21].ToString();
                    cl.equipo = Convert.ToBoolean(item[22]);
                    pagos.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("pagos", pagos));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message);
            }

        }
    }
}
