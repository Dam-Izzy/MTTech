using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormCalendarioClientes : Form
    {
        int valor;
        DateTime fecha;
        public FormCalendarioClientes(DateTime fecha, int valor)
        {
            this.valor = valor;
            this.fecha = fecha;
            InitializeComponent();
        }
        List<ClaseMensualidad> cortes = new List<ClaseMensualidad>();
        ClaseMensualidad cl = new ClaseMensualidad();
        private void FormVistaClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            // TODO: esta línea de código carga datos del reporte de comprobantes.            
            CargaMensualidad();
        }
        conexion cnn = new conexion();
        public void CargaMensualidad()
        {            
            try
            {
                foreach (DataRow item in GetMensualidad().Rows)
                {
                    cl.id = Convert.ToInt32(item[4].ToString());
                    cl.NombreCompleto = item[7].ToString();
                    cl.direccion = item[8].ToString();
                    cl.nombre = item[10].ToString();
                    cl.fechaMensualidad = Convert.ToDateTime(item[3].ToString());
                    cl.monto = Convert.ToDouble(item[0].ToString());
                    cl.mesprox = Convert.ToDateTime(item[3].ToString()).AddMonths(1);
                    cl.Comentario = item[12].ToString();
                    lbcomment.Text = item[12].ToString();
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("mensualidad", cortes));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message);
            }
        }
        private DataTable GetMensualidad()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getMensualidad('"+ fecha.ToShortDateString() +"', "+ valor +")", cnn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Retornar.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
            return Retornar;
        }

        private void btnprox_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow item in GetMensualidad().Rows)
                {
                    cl.id = Convert.ToInt32(item[4].ToString());
                    cl.NombreCompleto = item[7].ToString();
                    cl.direccion = item[8].ToString();
                    cl.nombre = item[10].ToString();
                    cl.fechaMensualidad = Convert.ToDateTime(item[3].ToString());
                    cl.monto = Convert.ToDouble(item[0].ToString());
                    cl.mesprox = Dtpfecha.Value;
                    cl.Comentario = item[12].ToString();
                    lbcomment.Text = item[12].ToString();
                    cortes.Add(cl);
                }
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("mensualidad", cortes));
                reportViewer1.RefreshReport();
                reportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message);
            }
        }
    }
}
