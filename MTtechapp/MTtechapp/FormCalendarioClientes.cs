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

        int valor;// identificador de cliente
        DateTime fecha;//fecha reporte
        //inicialización de componentes
        public FormCalendarioClientes(DateTime fecha, int valor)
        {
            this.valor = valor;
            this.fecha = fecha;
            InitializeComponent();
        }
        List<ClaseMensualidad> cortes = new List<ClaseMensualidad>();//lista de cortes
        ClaseMensualidad cl = new ClaseMensualidad();//instancia de objeto de la clase de mensualidad
        private void FormVistaClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            // TODO: esta línea de código carga datos del reporte de comprobantes.            
            CargaMensualidad();
        }
        conexion cnn = new conexion();//abrir conexión de bd
        /*carga de datos de mensualidades con la funcion
         * GetMensualidad, la cual nos devuelve las filas que
         * retorno la base de datos al ejecutar la funcion
         * con ello aqui iteramos y las agregamos a la lista
         * y con ello se guarda, y al ejecutar esta funcion muestra los datos en el reporte
         */
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
                    cl.Comentario = item[11].ToString();
                    lbcomment.Text = item[11].ToString();
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
        /*Ejecuta una funcion en la base de datos que devuelve a la datos a esta funcion 
         * y los devuelve para cargar el lector, para que es ejecute en la funcion CargaMensualidad
        */
        private DataTable GetMensualidad()
        {
            DataTable Retornar = new DataTable();
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("Select * from getMensualidad('" + fecha.ToShortDateString() + "', " + valor + ")", cnn.conn);
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
        /*
         Solo recarga los datos con la fecha que el usuario ingrese y la muestra en el reporte
             */
        
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
