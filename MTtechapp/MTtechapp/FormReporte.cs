using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormReporte : Form
    {
        
        public FormReporte()
        {
            InitializeComponent();
        }
        
        private void FormReporte_Load(object sender, EventArgs e)
        {
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            double iva;
            if (String.IsNullOrEmpty(txtiva.Text))
            {
                MessageBox.Show("Completa el campo");
            }
            else
            {
                iva = Convert.ToDouble(txtiva.Text);
                foreach (var item in Formticked.reportes1)
                {
                   item.valor= (item.total * iva/ 100)*item.cantidad;
                }
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
