using MaterialSkin;
using MaterialSkin.Controls;
using System;
namespace MTtechapp
{
    public partial class FormDialogo : MaterialForm
    {
        int valor;// valor de comprobante
        DateTime fecha; //valor de fecha
        private readonly MaterialSkinManager materialSkinManager; //administrador de msm
        //aqui se inicializan valores y las instancias
        public FormDialogo(DateTime fecha, int valor)
        {
            this.valor = valor;
            this.fecha = fecha;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        //boton de calendario que pasa valores para comporbante
        private void btncalendario_Click(object sender, EventArgs e)
        {
            FormCalendarioClientes clientes = new FormCalendarioClientes(fecha, valor);
            clientes.ShowDialog();
        }
        //funcion prevista para vista de hoja carta de comprobante
        private void btnreporte_Click(object sender, EventArgs e)
        {
            //FormReporteMensualidad formReporte = new FormReporteMensualidad(valor);
            //formReporte.ShowDialog();
        }
        //cerrar 
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
