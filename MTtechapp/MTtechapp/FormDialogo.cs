using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
namespace MTtechapp
{
    public partial class FormDialogo : MaterialForm
    {
        int valor;
        private readonly MaterialSkinManager materialSkinManager;
        public FormDialogo(int valor)
        {
            this.valor = valor;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        private void btncalendario_Click(object sender, EventArgs e)
        {
            FormCalendarioClientes clientes = new FormCalendarioClientes(valor);
            clientes.ShowDialog();
        }
        private void btnreporte_Click(object sender, EventArgs e)
        {
            //FormReporteMensualidad formReporte = new FormReporteMensualidad(valor);
            //formReporte.ShowDialog();
        }
    }
}
