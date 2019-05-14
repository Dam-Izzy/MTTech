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
       // public static List<DataSetCalendario> data = new List<DataSetCalendario>();
        //public void calendario()
        //{
        //    foreach (var item in data)
        //    {
        //        DateTime valor =DateTime.Now;
        //        item.Mensualidad.fechacalendarioColumn.DefaultValue = valor.AddMonths(1);
        //    }
        //}
        private void FormVistaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetCalendario.Mensualidad' 
            CargaMensualidad();
            this.reportViewer1.RefreshReport();
        }
        conexion cnn = new conexion();
        public void CargaMensualidad()
        {
            try
            {
                List<ClaseMensualidad> cortes = new List<ClaseMensualidad>();
                foreach (DataRow item in GetMensualidad().Rows)
                {
                    ClaseMensualidad cl = new ClaseMensualidad();
                    cl.id = Convert.ToInt32(item[4].ToString());
                    cl.NombreCompleto = item[7].ToString();
                    cl.direccion = item[8].ToString();
                    cl.nombre = item[8].ToString();
                    cl.fechaMensualidad = item[3].ToString();
                    cl.monto = Convert.ToDouble(item[0].ToString());
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
        FormPagoMensualidad FormPago = new FormPagoMensualidad();
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
        
    }
}
