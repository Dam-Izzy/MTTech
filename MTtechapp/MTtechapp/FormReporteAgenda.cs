using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
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
        private void FormReporteAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.Refresh();
                //El reporte se llena con una lista statica que esta en el formulario principal
                //para llenar las demás tablas se debe de generar pero se debe de filtrar por tipo
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datosagenda", FormMenuPrincipal.lista));
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
    }
}
