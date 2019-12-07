using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MTtechapp
{
    public partial class FormActualizar : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public FormActualizar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);            
        }

        /// <summary>
        /// carga de formulario
        /// </summary>
        /// <param name="sender">objeto de evento</param>
        /// <param name="e">parametro de evento</param>
        private void FormActualizar_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //comboBox1.DataSource = null;
            FormMenuPrincipal.municipios.Clear();
            //cargaMuni();
            ClassMetodos @class = new ClassMetodos();
            @class.autocompletarmunicipio(comboBox1);
        }
        conexion conn = new conexion(); //objeto de base de datos
        /// <summary>
        /// actualización de datos de segmentación y cliente
        /// </summary>
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtrouter.Text) || String.IsNullOrEmpty(txtIp.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    bool activo= true, equipo=true;
                    if (cbActivo.Checked == false)
                        activo = false;
                    else
                        activo = true;
                    if (cbEquipo.Checked == false)
                        equipo = false;
                    else
                        equipo = true;
                    SqlCommand cmd = new SqlCommand("update Segmentacion set router='" + txtrouter.Text + "',ip='" + txtIp.Text + "',comentario='" + txtCometarioip.Text + "',idCliente='" + Convert.ToInt32(lbid.Text) + "' where idSegmentacion=" + Convert.ToInt32(lbSeg.Text) + "", conn.conn);
                    SqlCommand cmd2 = new SqlCommand("update Cliente set NombreCompleto='" + txtnombre.Text + "',telefono='" + txtTelefono.Text + "',direccion='" + txtdireccion.Text + "',comentario='" + txtcomentario.Text + "',activo='"+ activo +"',idMunicipio='"+ comboBox1.SelectedValue +"',FechaInstalacion='"+ dtpInstalacion.Value.ToLongDateString() +"', equipo='" + equipo + "' where idCliente=" + Convert.ToInt32(lbid.Text) + "", conn.conn);
                    conn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();                    
                    MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Agrega la ip en el apartado de segmentación", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    limpiar();
                    cmd.Dispose();
                    cmd2.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                conn.Desconectar();
            }
        }
        /// <summary>
        /// Limpiar
        /// </summary>
        private void limpiar()
        {
            txtnombre.Clear();
            txtcodigo.Clear();
            txtcomentario.Clear();
            txtCometarioip.Clear();
            txtdireccion.Clear();
            txtIp.Clear();
            txtnombre.Clear();
            txtrouter.Clear();
            txtTelefono.Clear();
            

        }
        /// <summary>
        /// carga una lista estatica con una consulta
        /// </summary>
        /// <returns>retorna una lista</returns>
        public List<Municipio> Cargamunicipio()
        {
            try
            {
                conn.Conectar();
                SqlCommand cmd = new SqlCommand("select idMunicipio,Nombre from municipios", conn.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Municipio usuarios = new Municipio();
                    usuarios.idMunicipio = lector.GetInt32(0).ToString();
                    usuarios.Nombre = lector[1].ToString();
                    FormMenuPrincipal.municipios.Add(usuarios);
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
            finally { conn.Desconectar(); }
            return FormMenuPrincipal.municipios;
        }
        /// <summary>
        /// carga un combobox
        /// </summary>
        public void cargaMuni()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "idMunicipio";
            comboBox1.DataSource = Cargamunicipio();
        }
        /// <summary>
        /// elimina un cliente con su segmentacion
        /// </summary>
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea borrar este registro?", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Conectar();
                    int i, ig;
                    SqlCommand cmd = new SqlCommand("delete from Cliente where idCliente='" + Convert.ToInt32(lbid.Text.Trim()) + "'", conn.conn);
                    SqlCommand cmd2 = new SqlCommand("delete from Segmentacion where idSegmentacion='" + Convert.ToInt32(lbSeg.Text.Trim()) + "'", conn.conn);
                    i = cmd.ExecuteNonQuery();
                    ig = cmd2.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    MessageBox.Show(i.ToString());
                    if (i >= 0 && ig>=0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente!", "MTtech");
                        this.Close();
                        limpiar();
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
                MessageBox.Show("Error ;_; -" +ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.conn.State == ConnectionState.Open)
                {
                    conn.Desconectar();
                }

            }            
        }        
        /// <summary>
        ///  abre un formulario y llama a una funcion
        /// </summary>
        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormMenuPrincipal.municipios.Clear();
            ClassMetodos @class = new ClassMetodos();
            @class.autocompletarcombo(comboBox1);
            comboBox1.DataSource = null;
            cargaMuni();
        }
    }
}
