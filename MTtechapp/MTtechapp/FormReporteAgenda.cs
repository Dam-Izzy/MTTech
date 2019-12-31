using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace MTtechapp
{
    public partial class FormReporteAgenda : Form
    {
         internal List<ClaseInformeAgenda> DatosAgenda = new List<ClaseInformeAgenda>();
        public FormReporteAgenda()
        {
            InitializeComponent();
        }
        conexion cnn = new conexion();
        private void FormReporteAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.Refresh();
                //El reporte se llena con una lista statica que esta en el formulario principal
                //para llenar las demás tablas se debe de generar pero se debe de filtrar por tipo              

            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal ;_; " + ex.Message);
            }
            finally
            {
                reportViewer1.LocalReport.Refresh();

            }
            this.reportViewer1.RefreshReport();
        }

        //public List<ClaseInformeAgenda> CargarSeleccionadosSocios(ListView lvAgenda)
        //{
        //    foreach (var item in lvAgenda.SelectedItems.Cast<ListViewItem>())
        //    {
        //        ClaseInformeAgenda informeAgenda = new ClaseInformeAgenda();
        //        String Consulta = "SELECT dbo.agenda.idagenda, dbo.agenda.idCliente,dbo.agenda.idlugar, dbo.agenda.diagnostico, dbo.agenda.equipo, dbo.agenda.fecha, dbo.agenda.descripcion, dbo.agenda.estado, dbo.agenda.indicaciones, dbo.agenda.prioridad, dbo.agenda.tipo FROM dbo.agenda WHERE dbo.agenda.idagenda = " + item.SubItems[8].Text.ToString() + " and dbo.agenda.tipo= 'Socio'";
        //        SqlCommand sql = new SqlCommand(Consulta, cnn.conn);
        //        cnn.Conectar();
        //        SqlDataReader dr = sql.ExecuteReader();
        //        informeAgenda.cliente = item.SubItems[0].Text.ToString();
        //        informeAgenda.lugar = item.SubItems[2].Text.ToString();
        //        informeAgenda.diagnostico = item.SubItems[3].Text.ToString();
        //        informeAgenda.descripcion = item.SubItems[3].Text.ToString();
        //        informeAgenda.Equipo = item.SubItems[4].Text.ToString();
        //        informeAgenda.fecha = item.SubItems[5].Text.ToString();
        //        if (item.SubItems[0].Text.Contains("N/A"))
        //        {
        //            //
        //        }
        //        else
        //        {
        //            while (dr.Read())
        //            {
        //                informeAgenda.domicilio = dr.GetString(1);
        //                informeAgenda.Tel = dr.GetString(2);
        //            }
        //        }

        //        dr.Close();

        //        Instalaciones.Add(informeAgenda);
        //    }
        //    return listaSocios;
        //}
    }
}
