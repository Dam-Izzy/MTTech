using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
namespace MTtechapp
{
    public partial class FormDialogo : MaterialForm
    {
        int valor;
        DateTime fecha;
        private readonly MaterialSkinManager materialSkinManager;
        public FormDialogo(DateTime fecha, int valor)
        {
            this.valor = valor;
            this.fecha = fecha;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        private void btncalendario_Click(object sender, EventArgs e)
        {
            FormCalendarioClientes clientes = new FormCalendarioClientes(fecha, valor);
            clientes.ShowDialog();
        }
        private void btnreporte_Click(object sender, EventArgs e)
        {
            //FormReporteMensualidad formReporte = new FormReporteMensualidad(valor);
            //formReporte.ShowDialog();
        }
    }
}
