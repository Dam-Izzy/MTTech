using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.OleDb;
using MaterialSkin;
namespace MTtechapp
{
    public partial class FormAgregar : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormAgregar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);           
        }
        
        private void limpiar()
        {
            txtrouter.Clear();
            txtIp.Clear();
            txtCometarioip.Clear();
            txtrouter.Focus();
        }
        public List<Cliente> lista_Cliente = new List<Cliente>();
        conexion cx = new conexion();
        private List<Cliente> CargaCombo()
        {

            try
            {
                cx.Conectar();
                SqlCommand cmd = new SqlCommand("select * from Cliente", cx.conn);
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
            finally { cx.Desconectar(); }
            return lista_Cliente;
        }

        private void carga()
        {
            lista_Cliente.Clear();
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "idCliente";
            cbCliente.DataSource = CargaCombo();
        }
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            
            FormCliente fc = new FormCliente();
            fc.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbCliente.SelectedItem.ToString());
        }
        FormMunicipio fu = new FormMunicipio();
        private void lvAgregar_Click(object sender, EventArgs e)
        {
            fu.ShowDialog();
        }
        ClassMetodos @class = new ClassMetodos();

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtrouter.Text) || String.IsNullOrEmpty(txtIp.Text) || String.IsNullOrEmpty(txtCometarioip.Text) || cbCliente.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Segmentacion values('" + txtrouter.Text + "','" + txtIp.Text + "','" + txtCometarioip.Text + "','" + cbCliente.SelectedValue + "')", cx.conn);
                    cx.Conectar();
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Datos guardados correctamente" + i, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        private void txtrouter_Leave(object sender, EventArgs e)
        {
            if (txtrouter.Text.EndsWith("1"))
            {
                txtIp.Text = txtrouter.Text.TrimEnd('1');
            }
            if (txtrouter.Text.EndsWith("2"))
            {
                txtIp.Text = txtrouter.Text.TrimEnd('2');
            }
            if (txtrouter.Text.EndsWith("3"))
            {
                txtIp.Text = txtrouter.Text.TrimEnd('3');
            }
            if (txtrouter.Text.EndsWith("4"))
            {
                txtIp.Text = txtrouter.Text.TrimEnd('4');
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtrouter.Text) || String.IsNullOrEmpty(txtIp.Text) || String.IsNullOrEmpty(txtCometarioip.Text) || cbCliente.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update Segmentacion set router='" + txtrouter.Text + "',ip='" + txtIp.Text + "',comentario='" + txtCometarioip.Text + "',idCliente='" + cbCliente.SelectedValue + "' where idSegmentacion="+ Convert.ToInt32(idsegmentacion.Text) +"", cx.conn);
                    cx.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd1 = new SqlCommand("update Segmentacion set router= '" + txtrouter.Text + "',ip='" + txtIp.Text + "', comentario='" + txtCometarioip.Text + "' where idCliente="+ Convert.ToInt32(lbid.Text)+ "", conn.conn);
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
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            carga();            
            @class.autocompletarcombo(cbCliente);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            FormCliente usuarios = new FormCliente();
            try
            {
                cx.Conectar();
                string sql = "SELECT C.idCliente, C.NombreCompleto, C.telefono, C.direccion, C.comentario, C.activo, C.idMunicipio, C.FechaInstalacion, C.ClavePago, C.equipo, M.idMunicipio, M.Nombre FROM dbo.Cliente C INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio where idCliente= '" + cbCliente.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(sql, cx.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    usuarios.lbcliente.Text = lector.GetInt32(0).ToString();
                    usuarios.txtnombre.Text = lector[1].ToString();
                    usuarios.txtTelefono.Text = lector[2].ToString();
                    usuarios.txtdireccion.Text = lector[3].ToString();
                    usuarios.txtcomentario.Text = lector[4].ToString();
                    usuarios.cbActivo.Checked = Convert.ToBoolean(lector[5].ToString());
                    usuarios.dtpInstalacion.Value = DateTime.Parse(lector[7].ToString());
                    usuarios.txtcodigo.Text = lector[8].ToString();
                    usuarios.cbEquipo.Checked = lector.GetBoolean(9);
                    usuarios.materialRaisedButton1.Visible = false;
                    usuarios.materialFlatButton1.Visible = true;
                    lector.Close();
                    DataSet dataset = new DataSet();
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cx.conn))
                    {
                        da.Fill(dataset);
                    }

                    if (dataset.Tables[0].Rows.Count > 0)
                    {
                        usuarios.comboBox1.DataSource = dataset.Tables[0];
                        usuarios.comboBox1.DisplayMember = "Nombre";
                        usuarios.comboBox1.ValueMember = "idMunicipio";
                    }
                }
                usuarios.ShowDialog();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "MTtech---", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                cx.Desconectar();
            }
        }
        private void lbborrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea borrar a " + cbCliente.Text,"MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cx.Conectar();
                    int i;
                    SqlCommand cmd1 = new SqlCommand("delete from Cliente where idCliente='" + cbCliente.SelectedValue + "'", cx.conn);
                    i = cmd1.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("cliente eliminado correctamente!", "MTtech");
                        cbCliente.DataSource = null;
                        @class.autocompletarcombo(cbCliente);
                        carga();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no fue eliminado por alguna razón misteriosa. ;_;");
                    }
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; -" + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cx.Desconectar();
            }
        }
        private void cbCliente_Click_1(object sender, EventArgs e)
        {
            cbCliente.DataSource = null;
            @class.autocompletarcombo(cbCliente);
            carga();
        }
    }
}
