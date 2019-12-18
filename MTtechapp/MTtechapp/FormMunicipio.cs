using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormMunicipio : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        //inicializador de componentes
        public FormMunicipio()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        //evento de carga de inicio de formulario, que llama a una funcion de poblado de datos
        private void FormMunicipio_Load(object sender, EventArgs e)
        {
            materialRaisedButton1.Visible = false;
            Llenar();
        }

        conexion conn = new conexion();//instancia de base de datos 
        //boton que agrega un municipio a la base de datos 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtmunicipios.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into municipios values('" + txtmunicipios.Text + "')", conn.conn);
                    conn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmunicipios.Clear();
                    Llenar();
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
        //carga la lista de municipios para llenar un combobox
        public void Llenar()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select Nombre, idMunicipio from municipios", conn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.lvmun.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idMunicipio"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    lvmun.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal " + ex);
            }
            finally
            {
                conn.Desconectar();
            }
        }
        //Actualiza el nombre de un municipio seleccionado 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtmunicipios.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update municipios set Nombre='" + txtmunicipios.Text + "' where idMunicipio ='"+ lbid.Text +"'", conn.conn);
                    conn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmunicipios.Clear();
                    btnActualizar.Visible = false;
                    btnAgregar.Visible = true;
                    materialRaisedButton1.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                conn.Desconectar();
                Llenar();
            }
        }
        //carga el elemento al que se le dio doble click
        private void lvmun_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnAgregar.Visible = false;
                btnActualizar.Visible = true;
                materialRaisedButton1.Visible = true;
                conn.Conectar();
                int id = Convert.ToInt32(this.lvmun.SelectedItems[0].SubItems[0].Text);
                string sql = "SELECT idMunicipio, Nombre from municipios where idMunicipio=" + id + "";
                SqlCommand cmd = new SqlCommand(sql, conn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbid.Text = dr.GetInt32(0).ToString();
                    txtmunicipios.Text = dr.GetString(1);
                }
                dr.Close();               
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }
        //boton que elimina un municipio, esta funcion falla si el munipio ya tiene asignado a algun cliente 
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea borrar este registro?", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("delete from municipios where idMunicipio='" + Convert.ToInt32(lbid.Text.Trim()) + "'", conn.conn);
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i >= 0)
                    {
                        MessageBox.Show("municipio eliminado correctamente!", "MTtech");
                        txtmunicipios.Clear();
                        Llenar();
                    }
                    else
                    {
                        MessageBox.Show("El municipio no fue eliminado por alguna razón misteriosa. ;_; \n" +
                            "debes borrar los clientes de este municipio");
                    }
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes borrar los clientes de este municipio -" + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Desconectar();

            }
        }
    }
}
