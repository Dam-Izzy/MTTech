using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MTtechapp
{
    public partial class Formticked : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        ListView valor;
        public Formticked(ListView valor)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            this.valor = valor;
        }
        public static List<Clasedatosinformepago> reportes1 = new List<Clasedatosinformepago>();
        public static string token;
        FormMenuPrincipal fl = new FormMenuPrincipal();
        public List<Clasedatosinformepago> CargarPagos()
        {
            try
            {
                Guid miGuid = Guid.NewGuid();
                token = Convert.ToBase64String(miGuid.ToByteArray());
                token = token.Replace("=", "").Replace("+", "");
                foreach (var item in valor.SelectedItems.Cast<ListViewItem>())
                {
                    Clasedatosinformepago informeAgenda = new Clasedatosinformepago();
                    FormReporte reporte = new FormReporte();
                    informeAgenda.NombreCompleto = item.SubItems[0].Text.ToString();
                    informeAgenda.nombreArticulo = item.SubItems[1].Text.ToString();
                    informeAgenda.domicilio = item.SubItems[2].Text.ToString();
                    informeAgenda.telefono = item.SubItems[3].Text.ToString();
                    informeAgenda.cantidad = Convert.ToInt32(item.SubItems[4].Text.ToString());
                    informeAgenda.precio = Convert.ToDouble(item.SubItems[5].Text.ToString());
                    informeAgenda.total = Convert.ToDouble(item.SubItems[5].Text.ToString());
                    informeAgenda.Sfolio = item.SubItems[7].Text.ToString();
                    reportes1.Add(informeAgenda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            return reportes1;
        }


        private void btnreporte_Click(object sender, EventArgs e)
        {
            reportes1.Clear();
            FormMenuPrincipal formMenu = new FormMenuPrincipal();
            CargarPagos();
            FormReporte reporte = new FormReporte();
            reporte.ShowDialog();
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            reportes1.Clear();
            CargarPagos();
            Formticket reporte = new Formticket();
            reporte.ShowDialog();

        }
        }

    }

