using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using tik4net;

namespace MTtechapp
{
    public partial class FormHerramienta : MaterialForm
    {
        public FormHerramienta()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            TextBox myText = new TextBox();
            myText.Location = new Point(50, 60);
            this.Controls.Add(myText);
        }

        private void FormHerramienta_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            using (ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            {
                
                connection.Open("100.0.0.2", "admin", "macromt");
                ITikCommand cmd = connection.CreateCommand("/ip/neighbor");
                MessageBox.Show(cmd.ExecuteScalar());
            }
        }
    }
}
