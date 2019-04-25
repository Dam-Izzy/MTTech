using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MTtechapp
{
    public partial class FormPago : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public FormPago()
        {
            InitializeComponent();
            btnActualizarpago.Visible = false;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            ClassMetodos @class = new ClassMetodos();
            @class.autocompletarcombo(cmbCliente);
        }
        public List<Cliente> ListaCliente = new List<Cliente>();
        conexion cone = new conexion();
       
        public List<Cliente> CargaCombo()
        {
            List<Cliente> lista_Clientes = new List<Cliente>();
            try
            {
                cone.Conectar();
                SqlCommand cmd = new SqlCommand("select * from Cliente", cone.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Cliente usuarios = new Cliente();
                    usuarios.idCliente = Int16.Parse(lector[0].ToString());
                    usuarios.NombreCompleto = lector[1].ToString();
                    usuarios.telefono = lector[2].ToString();
                    usuarios.direccion = lector[3].ToString();
                    usuarios.comentario = lector[4].ToString();
                    lista_Clientes.Add(usuarios);
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
            finally { cone.Desconectar(); }
            return lista_Clientes;
        }
        public void carga()
        {
            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = CargaCombo();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string theDate = dtpFechaPago.Value.ToString("yyyy-MM-dd");
                //string sql = "insert into pago values('" + txtArticulo.Text + "','" + txtPrecio.Text + "','" + theDate + "','" + cmbCliente.SelectedValue + "','" + txtcantidad.Text + "')";
                SqlCommand cmd = new SqlCommand("dbo.spProcedure", cone.conn);
                cmd.Parameters.AddWithValue("@nombreArticulo", txtArticulo.Text);
                cmd.Parameters.AddWithValue("@precio", double.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@fechaPago", theDate);
                cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtcantidad.Text));
                cmd.Parameters.AddWithValue("@Fk_pagoCliente", int.Parse(cmbCliente.SelectedValue.ToString()));
                cone.Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                int j;
                j=cmd.ExecuteNonQuery();
                if (j>0)
                {
                    MessageBox.Show("Guardado");
                    LvPagos.Clear();
                    llenarpago();
                    limpiar();
                    LvPagos.Refresh();
                }
                else
                {
                    MessageBox.Show("Algo salio mal ;_;");
                }
            }
            catch (Exception ext)
            {
                MessageBox.Show("Algo salio mal ;_;"  + ext.Message);
            }            
        }

        private void FormPago_Load(object sender, EventArgs e)
        {
            
            llenarpago();
        }
        public void llenarpago()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT P.idPago,C.NombreCompleto,P.nombreArticulo,P.fechaPago,C.comentario,P.Precio,P.cantidad,P.Fk_pagoCliente AS cliente,P.cantidad* P.Precio as total,C.idCliente,PS.idCliente AS cliente,PS.idPago, PS.idPagos FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago=PS.idPago)", cone.cn);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            this.LvPagos.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["idPago"].ToString());
                elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                elementos.SubItems.Add(filas["fechaPago"].ToString());
                elementos.SubItems.Add(filas["Precio"].ToString());
                elementos.SubItems.Add(filas["idCliente"].ToString());
                elementos.SubItems.Add(filas["idPagos"].ToString());
                LvPagos.Items.Add(elementos);
            }
        }
        private void limpiar()
        {
            txtArticulo.Clear();
            txtPrecio.Clear();

        }
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex.Equals(-1) || String.IsNullOrEmpty(txtArticulo.Text) || String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("No puedes dejar espacios vacios", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                generateinvoice();
                CargarSeleccionados();
            }
        }
        public void generateinvoice()
        {
            try
            {
            //    Int32 AB = 0;
            //    foreach (ListViewItem I in LvPagos.Items)
            //    {
            //        AB += int.Parse(I.SubItems[3].Text);
            //        String resultado = AB.ToString();
            //    }
            //    int rest = Convert.ToInt32(txtcantidad.Text) * AB;
                DatosReporte datos = new DatosReporte();
                datos.nombreCompleto = cmbCliente.Text;
                datos.NombreArticulo = txtArticulo.Text;
                datos.telefono = lvtel.Text;
                datos.direccion = lvDireccion.Text;
                datos.comentario = lvcomment.Text;
                //datos.total = AB;
                //datos.Precio = AB;
                datos.Precio = Convert.ToDouble(txtPrecio.Text);
                datos.subtotal = Convert.ToDouble(txtPrecio.Text)* Convert.ToDouble(txtcantidad.Text);
                datos.iva = Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtiva.Text) /100;
                datos.totalArticulos = Convert.ToInt32(txtcantidad.Text);
                datos.total = datos.iva + datos.subtotal;
                datos.fechaPago = dtpFechaPago.Text;
                FormReporte fr = new FormReporte();
                //fr.datosReportes.Add(datos);
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }

        }

        //private void materialListView2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (LvPagos.SelectedIndices.Count <= 0)
        //    {
        //        return;
        //    }
        //    string selected = this.LvPagos.SelectedItems[0].Text;
        //    materialRaisedButton1.Visible = false;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Select P.idPago,C.idCliente,C.NombreCompleto, P.nombreArticulo, P.Precio, P.fechaPago, C.telefono,C.direccion, C.comentario, P.cantidad  from pago P inner join Cliente C on(C.idCliente= P.idPago) where C.idCliente=" + selected + "", cone.conn);
        //        cone.Conectar();
        //        cmd.CommandType = CommandType.Text;
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            cmbCliente.ValueMember = dr.GetInt32(1).ToString();
        //            cmbCliente.Text = dr.GetString(2).ToString();
        //            txtArticulo.Text = dr[3].ToString();
        //            txtPrecio.Text = dr[4].ToString();
        //            dtpFechaPago.Text = dr[5].ToString();
        //            lvtel.Text = dr[6].ToString();
        //            lvDireccion.Text = dr[7].ToString();
        //            lvcomment.Text = dr[8].ToString();
        //            txtcantidad.Text = dr[9].ToString();
        //            dr.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Algo salio mal :(" + ex.Message);
        //    }
        //    finally
        //    {
        //        cone.Desconectar();
        //    }
        //}

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(cmbCliente.SelectedValue);
            try
            {
                DateTime dt= DateTime.Parse(dtpFechaPago.Text);
                OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT C.idCliente,C.NombreCompleto,C.telefono,C.direccion,C.comentario,P.idPago,P.nombreArticulo,P.Precio, P.fechaPago,P.cantidad AS cliente,C.idCliente,PS.idCliente AS cliente,PS.idPago AS pago FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago=PS.idPago) where C.idCliente=" + selected + "and P.fechaPago = '" + dt.ToShortDateString() + "'", cone.cn);
                cone.Conectar();
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                cmd.Fill(ds);
                tabla = ds.Tables[0];
                this.LvPagos.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                    elementos.SubItems.Add(filas["precio"].ToString());
                    elementos.SubItems.Add(filas["fechaPago"].ToString());
                    LvPagos.Items.Add(elementos);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal :(" + ex.Message);
            }
            finally
            {
                cone.Desconectar();
            }
        }

        private void btnActualizarpago_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update pago set nombreArticulo=@nombreArticulo,Precio=@Precio,fechaPago=@fechaPago,cantidad=@cantidad, Fk_pagoCliente=@Fk_pagoCliente WHERE idPago=@idPago", cone.conn);
            SqlCommand sqlpagos = new SqlCommand("update pagos set idCliente=@idCliente,idPago=@idPago where idPago=@idPago", cone.conn);
            sqlCommand.Parameters.AddWithValue("@nombreArticulo", txtArticulo.Text);
            sqlCommand.Parameters.AddWithValue("@Precio", Convert.ToInt32(txtPrecio.Text));
            sqlCommand.Parameters.AddWithValue("@fechaPago", dtpFechaPago.Value.ToShortDateString());
            sqlCommand.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            sqlCommand.Parameters.AddWithValue("@Fk_pagoCliente", cmbCliente.ValueMember);
            sqlCommand.Parameters.AddWithValue("@idPago", Convert.ToInt32(lbpago.Text));
            sqlpagos.Parameters.AddWithValue("@idPago", Convert.ToInt32(lbpago.Text));
            sqlpagos.Parameters.AddWithValue("@idCliente", cmbCliente.ValueMember);
            try
            {
                if (btnActualizarpago.Visible == true)
                {
                    materialRaisedButton1.Visible = false;
                }
                if (String.IsNullOrEmpty(txtArticulo.Text) || String.IsNullOrEmpty(txtcantidad.Text) || String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("No debes dejar espacios en blanco", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    cone.Conectar();
                    sqlCommand.CommandType = CommandType.Text;
                    int i = sqlCommand.ExecuteNonQuery();
                    int j = sqlpagos.ExecuteNonQuery();
                    if (i > 0 && j >0)
                    {
                        MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Algo salio mal :(" + sql.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal :(" + ex.Message);
            }

        }

        private void btnaddd_Click(object sender, EventArgs e)
        {

        }
        public static List<DatosReporte> lista = new List<DatosReporte>();
        public List<DatosReporte> CargarSeleccionados()
        {
            foreach (var item in LvPagos.SelectedItems.Cast<ListViewItem>())
            {
                DatosReporte informeAgenda = new DatosReporte();
                informeAgenda.idCliente =int.Parse(item.SubItems[0].Text.ToString());
                informeAgenda.nombreCompleto = item.SubItems[1].Text.ToString();
                //informeAgenda.telefono = item.SubItems[2].Text.ToString();
                //informeAgenda.direccion = item.SubItems[3].Text.ToString();
                informeAgenda.comentario = item.SubItems[2].Text.ToString();
                //informeAgenda.NombreArticulo = item.SubItems[3].Text.ToString();
                //informeAgenda.iva = double.Parse(item.SubItems[6].Text.ToString());
                //informeAgenda.Precio = double.Parse(item.SubItems[4].Text.ToString());
                informeAgenda.fechaPago = item.SubItems[3].Text.ToString();
                //informeAgenda.total = double.Parse(item.SubItems[9].Text.ToString());
                //informeAgenda.subtotal = double.Parse(item.SubItems[10].Text.ToString());
                //informeAgenda.totalArticulos = int.Parse(item.SubItems[11].Text.ToString());
                lista.Add(informeAgenda);

            }
            return lista;
        }

        private void LvPagos_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
            ClassMetodos classMetodos = new ClassMetodos();
            var pago = Convert.ToInt32(LvPagos.SelectedItems[0].SubItems[0].Text.ToString());
            var pagos = Convert.ToInt32(LvPagos.SelectedItems[0].SubItems[6].Text.ToString());
            classMetodos.BorrarPago(pago, pagos);
        }

        private void cmbCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected = Convert.ToInt32(cmbCliente.SelectedValue);
            try
            {
                OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT P.idPago,C.NombreCompleto,P.nombreArticulo,P.fechaPago,P.Precio,	P.Fk_pagoCliente AS cliente,C.idCliente,PS.idCliente AS cliente,PS.idPago AS pago FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago=PS.idPago) where C.idCliente=" + selected + "", cone.cn);
                cone.Conectar();
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                cmd.Fill(ds);
                tabla = ds.Tables[0];
                this.LvPagos.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                    elementos.SubItems.Add(filas["fechaPago"].ToString());
                    elementos.SubItems.Add(filas["pago"].ToString());
                    LvPagos.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal :(" + ex.Message);
            }
            finally
            {
                cone.Desconectar();
            }
        }
    }
}
