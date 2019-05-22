using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace MTtechapp
{
    public partial class FormIngresos : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormIngresos()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            InitializeComponent();
            CargaRegistros();
        }
        conexion conn = new conexion();
        public void CargaRegistros()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select G.idIngreso,G.tipo,G.descripcion,G.lugar,G.monto, G.fecha,M.idMunicipio,M.Nombre from Ingreso G inner join municipios M on(M.idMunicipio= G.lugar)", conn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.materialListView1.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idIngreso"].ToString());
                    elementos.SubItems.Add(filas["descripcion"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["monto"].ToString());
                    materialListView1.Items.Add(elementos);
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
        private void btnAgregarIng_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDescrip.Text) || String.IsNullOrEmpty(txtmonto.Text) || cbtipo.SelectedIndex.Equals(-1) || cbLocalidad.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    bool checado= false;
                    if (CheckEstado.Checked)
                    {
                        checado = true;
                    }
                    else
                    {
                        checado = false;
                    }
                    SqlCommand cmd = new SqlCommand("insert into Ingreso values('" + cbtipo.Text + "','" + txtDescrip.Text + "','" + cbLocalidad.SelectedValue + "',"+ txtmonto.Text + ",'" + dtpFiltro.Value.ToShortDateString() + "','"+ checado +"')", conn.conn);
                    conn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd1 = new SqlCommand("update Segmentacion set router= '" + txtrouter.Text + "',ip='" + txtIp.Text + "', comentario='" + txtCometarioip.Text + "' where idCliente="+ Convert.ToInt32(lbid.Text)+ "", conn.conn);
                    MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                conn.Desconectar();
                CargaRegistros();
            }
        }
        private void FormIngresos_Load(object sender, EventArgs e)
        {
            FormMenuPrincipal.municipios.Clear();
            cargaMuni();
        }
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
        public void cargaMuni()
        {
                cbLocalidad.DataSource = null;
                cbLocalidad.DisplayMember = "Nombre";
                cbLocalidad.ValueMember = "idMunicipio";
                cbLocalidad.DataSource = Cargamunicipio();
        }

        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnAgregarIng.Visible = false;
                BtnActualizar.Visible = true;
                conn.Conectar();
                int id = Convert.ToInt32(this.materialListView1.SelectedItems[0].SubItems[0].Text);
                string sql = "Select G.tipo,G.descripcion,G.monto,G.fecha,G.estado, M.Nombre, M.idMunicipio,G.idIngreso from ingreso G inner join municipios M on (M.idMunicipio=G.lugar) where idIngreso=" + id + "";
                SqlCommand cmd = new SqlCommand(sql, conn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cbtipo.Text = dr.GetString(0);
                    txtDescrip.Text = dr[1].ToString();
                    txtmonto.Text = dr.GetDouble(2).ToString();
                    dtpFiltro.Text = dr[3].ToString();
                    CheckEstado.Checked = dr.GetBoolean(4);
                    lbid.Text = dr[7].ToString();
                }
                dr.Close();

                DataSet dataset = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn.conn))
                {
                    da.Fill(dataset);
                }

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    cbLocalidad.DataSource = null;
                    cbLocalidad.DataSource = dataset.Tables[0];
                    cbLocalidad.DisplayMember = "Nombre";
                    cbLocalidad.ValueMember = "idMunicipio";
                }
                
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDescrip.Text) || String.IsNullOrEmpty(txtmonto.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    bool activo = true;
                    int error;
                    if (CheckEstado.Checked == false)
                        activo = false;
                    else
                        activo = true;
                    SqlCommand cmd = new SqlCommand("update Ingreso set tipo='" + cbtipo.Text + "',descripcion='" + txtDescrip.Text + "',lugar='" + cbLocalidad.SelectedValue + "',monto=" + Convert.ToDouble(txtmonto.Text) + ",fecha='"+ dtpFiltro.Value.ToShortDateString() +"',estado='"+ activo +"' where idIngreso="+lbid.Text+"", conn.conn);
                    conn.Conectar();
                    cmd.CommandType = CommandType.Text; 
                    error =cmd.ExecuteNonQuery();
                    if (error>0)
                    {
                        MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error ;_; ", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                conn.Desconectar();
                CargaRegistros();
                txtDescrip.Clear();
                txtmonto.Clear();
                CheckEstado.Checked = false;
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            FormVisualizadorIngresos visualizadorIngresos = new FormVisualizadorIngresos();
            visualizadorIngresos.ShowDialog();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select G.idIngreso,G.tipo,G.descripcion,G.lugar,G.monto, G.fecha,M.idMunicipio,M.Nombre from Ingreso G inner join municipios M on(M.idMunicipio= G.lugar) where G.fecha='"+ dtpFiltro.Value.ToShortDateString() +"'", conn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.materialListView1.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idIngreso"].ToString());
                    elementos.SubItems.Add(filas["descripcion"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["monto"].ToString());
                    materialListView1.Items.Add(elementos);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {            
            CargaRegistros();
        }
    }
}
