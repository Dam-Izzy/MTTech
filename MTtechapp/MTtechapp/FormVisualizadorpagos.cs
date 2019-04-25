using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
