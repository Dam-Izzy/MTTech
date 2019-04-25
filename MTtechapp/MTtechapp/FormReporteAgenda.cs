using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
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
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datos", FormMenuPrincipal.lista));
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
