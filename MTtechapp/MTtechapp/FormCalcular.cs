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
    public partial class FormCalcular : MaterialForm
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            double uno = 0;
            double dos = 0;
            double tres = 0;
            double cua = 0;
            double cinco = 0;
            double seis = 0;
            double siete = 0;
            double ocho = 0;
            double nueve = 0;
            double dies = 0;
            double once = 0;
            double total = 0;
            if (String.IsNullOrEmpty(txtmil.Text))
            {
                double var=Convert.ToDouble(txtuno.Text);
                var = 0;
            }
            else if (String.IsNullOrEmpty(txtquini.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtdoscien.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtdoscien.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtcien.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtcincu.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtvein.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtdies.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtcinco.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtdos.Text))
            {

            }
            else if (String.IsNullOrEmpty(txtuno.Text))
            {

            }
            else if(String.IsNullOrEmpty(txtcentavo.Text))
            {

            }
            uno =Convert.ToDouble(txtmil.Text) * 1000;
            dos = Convert.ToDouble(txtquini.Text) * 500;
            tres = Convert.ToDouble(txtdoscien.Text) * 200;
            cua = Convert.ToDouble(txtcien.Text) * 100;
            cinco = Convert.ToDouble(txtcincu.Text) * 50;
            seis = Convert.ToDouble(txtvein.Text) * 20;
            siete = Convert.ToDouble(txtdies.Text) * 10;
            ocho = Convert.ToDouble(txtcinco.Text) * 5;
            nueve = Convert.ToDouble(txtdos.Text) * 2;
            dies = Convert.ToDouble(txtuno.Text) * 1;
            once = Convert.ToDouble(txtcentavo.Text) * 0.5;
            total = uno + dos + tres + cua + cinco + seis + siete + ocho + nueve + dies + once;
            double corte;
            double total1 = FormMenuPrincipal.A;
            corte =total1 - total;
            if (total1>total)
            {
                MessageBox.Show("Te falto dinero: " + corte.ToString());
                lbtotal.Text = "";
            }
            else
            {
                lbtotal.Text = corte.ToString();
            }
            
        }
    }
}
