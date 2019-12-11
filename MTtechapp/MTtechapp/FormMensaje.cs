using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MTtechapp
{
    public partial class FormMensaje : MaterialForm
    {
        public FormMensaje()
        {
            InitializeComponent();
        }
        conexion cnn = new conexion();// conexión a bd
        //lista de clientes
        public List<Cliente> lista_Cliente = new List<Cliente>();
        //Carga un combobox con los nombres de un cliente
        public void carga()
        {
            lista_Cliente.Clear();
            cbclientem.DataSource = null;
            cbclientem.DisplayMember = "NombreCompleto";
            cbclientem.ValueMember = "idCliente";
            cbclientem.DataSource = CargaCombo();
        }
        //aqui se carga la lista con una consulta la cual debuelve tuplas con datos para la iteración
        public List<Cliente> CargaCombo()
        {
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("select * from Cliente", cnn.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Cliente usuarios = new Cliente();
                    usuarios.idCliente = Convert.ToInt32(lector[0]);
                    usuarios.NombreCompleto = lector[1].ToString();
                    usuarios.telefono = lector[2].ToString();
                    usuarios.direccion = lector[3].ToString();
                    usuarios.comentario = lector[4].ToString();
                    lista_Cliente.Add(usuarios);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { cnn.Desconectar(); }
            return lista_Cliente;
        }
        //api de whatsapp, manda un mensaje de prueba para los clientes que esten registrados 
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            const string accountSid = "AC46161011010dec31c96b0d928901bb93";
            const string authToken = "0852f06d7cbf22c4a9a607e33ff33df1";
            try
            {
                TwilioClient.Init(accountSid, authToken);
                var message = MessageResource.Create(
                body: txtmensaje.Text,
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                to: new Twilio.Types.PhoneNumber("whatsapp:"+txtnumero.Text+"")
            );
                Console.WriteLine(message.Sid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            
        }        
        //carga combo box con clientes
        private void FormMensaje_Load(object sender, EventArgs e)
        {
            carga();
        }
        //muestra en un campo el numero del cliente que se selecciono.
        private void cbclientem_Click(object sender, EventArgs e)
        {
            if (cbclientem.Items != null)
            {
                String query = "Select idCliente,telefono from Cliente where idCliente='" + cbclientem.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtnumero.Enabled = false;
                    txtnumero.Text = dr[1].ToString();
                }
                dr.Close();
            }
        }
    }
}
