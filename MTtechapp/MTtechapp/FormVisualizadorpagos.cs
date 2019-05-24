using System;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormVisualizadorpagos : Form
    {
        int idCliente;
        public FormVisualizadorpagos(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void FormVisualizadorpagos_Load(object sender, EventArgs e)
        {
            // esta línea de código carga datos en la tabla mtDataSet.Cliente
            this.reportViewer1.RefreshReport();
        }

    }
}
