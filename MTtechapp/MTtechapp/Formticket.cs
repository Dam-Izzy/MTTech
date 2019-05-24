using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class Formticket : Form
    {
        public Formticket()
        {
            InitializeComponent();
        }

        private void Formticket_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            try
            {
                this.reportViewer1.RefreshReport();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Formticked.reportes1));
                reportViewer1.RefreshReport();
                reportViewer1.LocalReport.DisplayName = Formticked.token.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo salio mal ;_; " + ex.Message);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
