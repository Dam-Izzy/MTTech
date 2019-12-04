using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using tik4net;

namespace MTtechapp
{
    public partial class FormCliente : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormCliente()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            ClassMetodos @class = new ClassMetodos();
            @class.autocompletarmunicipio(comboBox1);
        }

        conexion cx = new conexion();
        public List<Municipio> ListaMun = new List<Municipio>();
        public List<Municipio> Cargamun()
        {
            try
            {
                cx.Conectar();
                SqlCommand cmd = new SqlCommand("select idMunicipio, Nombre from municipios", cx.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Municipio municipios = new Municipio();
                    municipios.idMunicipio = lector.GetInt32(0).ToString();
                    municipios.Nombre = lector[1].ToString();
                    ListaMun.Add(municipios);
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
            finally { cx.Desconectar(); }
            return ListaMun;
        }
        public void cargamun()
        { 
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "idMunicipio";
            comboBox1.DataSource = Cargamun();
        }
        public void limpiar()
        {
            txtnombre.Clear();
            txtTelefono.Clear();
            txtdireccion.Clear();
            txtcomentario.Clear();
            cbActivo.Checked = false;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Refresh();
            cargamun();
        }

        private void lvAgregar_Click(object sender, EventArgs e)
        {
            FormMunicipio municipio = new FormMunicipio();
            cargamun();
            municipio.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox1.ValueMember);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMunicipio mun = new FormMunicipio();
            mun.ShowDialog();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cargamun();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool activo, equipo = false;
  
              if (cbActivo.Checked)
                    activo = true;
                else
                    activo = false;
                if (cbEquipo.Checked)

                    equipo = true;
                else
                    equipo = false;

                if (String.IsNullOrEmpty(txtnombre.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtcomentario.Text) || String.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("Por favor debes llenar los campos...");
                }
                else
                {
                    string sql = "insert into Cliente(NombreCompleto, telefono, direccion, comentario, activo, idMunicipio, FechaInstalacion, ClavePago, equipo) values('" + txtnombre.Text + "','" + txtTelefono.Text + "','" + txtdireccion.Text + "','" + txtcomentario.Text + "','" + activo + "','" + comboBox1.SelectedValue + "','" + dtpInstalacion.Value.ToLongDateString() + "','" + txtcodigo.Text + "','" + equipo + "')";
                   
                    SqlCommand cmd = new SqlCommand(sql, cx.conn);
                    cx.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal ;_;" + ex.Message);
            }
            finally
            {
                cx.Desconectar();
            }

            //using (ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api))
            //{
            //    connection.Open("100.0.0.2", "admin", "macromt");
            //    //ppp secret add name = hildaisidoro password = enlacemt service = pppoe profile = profclientescasa390
            //    ITikCommand cmd = connection.CreateCommand("ppp/secret/add/name=test/passwod=enlacemt/service=pppoe/profile=profclientescasa390");
            //    MessageBox.Show(cmd.ExecuteScalar());
            //}
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (String.IsNullOrEmpty(txtnombre.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtcomentario.Text) || String.IsNullOrEmpty(txtdireccion.Text) || comboBox1.Items.Count==0 || String.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    bool activo = true, equipo = true;
                    if (cbActivo.Checked == false)
                        activo = false;
                    else
                        activo = true;
                    if (cbEquipo.Checked == false)
                        equipo = false;
                    else
                        equipo = true;
                    SqlCommand cmd = new SqlCommand("update Cliente set NombreCompleto='" + txtnombre.Text + "',telefono='" + txtTelefono.Text + "',direccion='" + txtdireccion.Text + "',comentario='" + txtcomentario.Text + "',activo='" + activo + "',idMunicipio='" + comboBox1.SelectedValue + "',FechaInstalacion='" + dtpInstalacion.Value.ToShortDateString() + "', equipo='" + equipo + "' where idCliente=" + Convert.ToInt32(lbcliente.Text) + "", cx.conn);
                    cx.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            ListaMun.Clear();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            cargamun();
            comboBox1.Refresh();
        }
    }
}
