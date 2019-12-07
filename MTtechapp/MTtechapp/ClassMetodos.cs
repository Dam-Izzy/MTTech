using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public class ClassMetodos
    {
        conexion cnn = new conexion();
        /// <summary>
        /// Busca un usuario
        /// </summary>
        /// <param name="cadena">cadena de busqueda</param>
        /// <param name="lv">listview de salida</param>
        public void BuscarUsuario(String cadena, ListView lv)
        {
            lv.Items.Clear();
            cnn.Conectar();                                    
            OleDbDataAdapter adaptador = new OleDbDataAdapter("Select idusuario, usuario from Usuario where usuario like '%" + cadena + "%'", cnn.cn);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["idusuario"].ToString());
                elementos.SubItems.Add(filas["usuario"].ToString());                
                lv.Items.Add(elementos);

            }
        }
        /// <summary>
        /// Buscar item en agenda
        /// </summary>
        /// <param name="cadena">cadena a buscar</param>
        /// <param name="lv">listvew que muestra datos</param>
        public void BuscarAgenda(String cadena, ListView lv)
        {
            lv.Items.Clear();
            cnn.Conectar();                                    
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT A.idagenda, A.idlugar, A.diagnostico, A.equipo, A.fecha,A.descripcion, M.Nombre, ISNULL (C.NombreCompleto, 'N/A') as NombreCompleto from agenda A INNER JOIN municipios M on (A.idlugar = M.idMunicipio) INNER JOIN cliente C on (C.idCliente= A.idCliente) where A.diagnostico like '%" + cadena + "%' or A.equipo like '%"+ cadena + "%' or A.fecha like '%" + cadena + "%' or A.descripcion like '%" + cadena + "%'", cnn.cn);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["NombreCompleto"].ToString());
                elementos.SubItems.Add(filas["Nombre"].ToString());
                elementos.SubItems.Add(filas["diagnostico"].ToString());
                elementos.SubItems.Add(filas["descripcion"].ToString());
                elementos.SubItems.Add(filas["equipo"].ToString());
                elementos.SubItems.Add(filas["fecha"].ToString());
                lv.Items.Add(elementos);

            }
        }

        /// <summary>
        /// busca un pago
        /// </summary>
        /// <param name="lv">listview de salida</param>
        /// <param name="dtp">fecha de entrada</param>
        /// <param name="valor">cadena de busqueda</param>
        public void buscarpago(ListView lv, DateTimePicker dtp, String valor)
        {
            string theDate = dtp.Value.ToString("yyyy-MM");
            try
            {

                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT C.idCliente, C.NombreCompleto, p.nombreArticulo, p.fechaPago, p.Precio, C.comentario, p.idPago, ps.idPagos, ps.idCliente as clientes, ps.idPago FROM dbo.pago p INNER JOIN dbo.Pagos ps on (p.idPago= ps.idPago)INNER JOIN dbo.Cliente C on (ps.idCliente= C.idCliente) WHERE C.NombreCompleto LIKE '%"+ valor +"%' or nombreArticulo LIKE '%"+ valor + "%'or fechaPago LIKE '%" + valor + "%' or precio LIKE '%" + valor + "%' or comentario LIKE '%" + valor + "%'", cnn.cn);
                lv.Items.Clear();
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                    elementos.SubItems.Add(filas["Precio"].ToString());
                    elementos.SubItems.Add(filas["fechapago"].ToString());
                    elementos.SubItems.Add(filas["comentario"].ToString());
                    elementos.SubItems.Add(filas["idPago"].ToString());
                    lv.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal ;_; " + ex, "MTech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                cnn.Desconectar();
            }

        }
        /// <summary>
        /// lee datos de la base de datos
        /// </summary>
        /// <param name="text">listview de de entrada</param>
        public void autocompletarpago(TextBox text)
        {
            try
            {
                string query = "SELECT C.idCliente, C.NombreCompleto, p.nombreArticulo, p.fechaPago, p.Precio, C.comentario, p.idPago, ps.idPagos, ps.idCliente as clientes, ps.idPago FROM dbo.pago p INNER JOIN dbo.Pagos ps on(p.idPago = ps.idPago)INNER JOIN dbo.Cliente C on(ps.idCliente = C.idCliente)";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["NombreCompleto"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["nombreArticulo"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["fechapago"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["precio"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["comentario"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// carga un pago
        /// </summary>
        /// <param name="lv">listview de carga de datos</param>
        public void clickpagos(ListView lv)
        {
            string item = lv.SelectedItems[0].SubItems[8].Text;
            string item2 = lv.SelectedItems[0].SubItems[7].Text;
            try
            {
                if (lv.SelectedIndices.Count <= -1)
                {
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select P.idPago, P.NombreArticulo, P.Precio, P.fechapago,C.NombreCompleto,C.telefono,C.direccion, C.Comentario,P.cantidad, P.Fk_pagoCliente, C.idCliente, PS.idPagos, PS.idPago from Cliente C inner join pago P on(C.idCliente= P.Fk_pagoCliente) INNER JOIN Pagos PS on(PS.idPago= P.idPago) where PS.idPago=" + Convert.ToInt32(item) + "AND P.idPago=" + Convert.ToInt32(item2) + "", cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    FormPago fag = new FormPago();
                    fag.materialRaisedButton1.Visible = false;
                    fag.btnActualizarpago.Visible = true;
                    if (dr.Read())
                    {
                        fag.cmbCliente.Text = dr[4].ToString();
                        fag.cmbCliente.ValueMember = dr.GetInt32(10).ToString();
                        fag.txtArticulo.Text = dr[1].ToString();
                        fag.txtPrecio.Text = dr[2].ToString();
                        fag.dtpFechaPago.Text = dr[3].ToString();
                        fag.lvtel.Text = dr[5].ToString();
                        fag.lvDireccion.Text = dr[6].ToString();
                        fag.lvcomment.Text = dr[7].ToString();
                        fag.txtcantidad.Text = dr[8].ToString();
                        fag.lbpago.Text = dr[0].ToString();
                        dr.Close();
                    }
                    fag.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal ;_; " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// lee datos de la base de datos
        /// </summary>
        /// <param name="text">listview de de entrada</param>
        public void autocompletaragenda(TextBox text)
        {
            try
            {
                string query = "Select idagenda, diagnostico, equipo, fecha, descripcion from agenda";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["diagnostico"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["equipo"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["fecha"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["descripcion"].ToString());
                }                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// lee datos de la base de datos
        /// </summary>
        /// <param name="lv">listview de de entrada</param>
        public void ActualizarAgenda(ListView lv)
        {
            FormPago formPago = new FormPago();
            formPago.materialRaisedButton1.Visible = false;
            string item = lv.SelectedItems[0].SubItems[8].Text;
            string item2 = lv.SelectedItems[0].SubItems[7].Text;
            MessageBox.Show(item2 + "" + item2);
            try
            {
                if (lv.SelectedIndices.Count <= -1)
                {
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select A.idCliente, A.idlugar, A.diagnostico, A.equipo, A.fecha, A.descripcion where P.idPago=" + Convert.ToInt32(item2) + "AND PS.idPago=" + Convert.ToInt32(item2) + "", cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    using (FormPago fag = new FormPago())
                    {
                        fag.btnActualizarpago.Visible = true;
                        if (dr.Read())
                        {
                            fag.cmbCliente.Text = dr[4].ToString();
                            fag.txtArticulo.Text = dr[1].ToString();
                            fag.txtPrecio.Text = dr[2].ToString();
                            fag.dtpFechaPago.Text = dr[3].ToString();
                            fag.lvtel.Text = dr[6].ToString();
                            fag.lvDireccion.Text = dr[7].ToString();
                            fag.lvcomment.Text = dr[8].ToString();
                            fag.txtcantidad.Text = dr[9].ToString();
                            fag.lbpago.Text = dr[11].ToString();
                            dr.Close();
                        }
                        fag.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal ;_; " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }

        }
        /// <summary>
        /// borra un pago realizado
        /// </summary>
        /// <param name="lb">idpago de entrada</param>
        /// <param name="lb2">id pagos de entrada</param>
        public void BorrarPago(int lb, int lb2)
        {
            try
            {

                if (MessageBox.Show("Desea borrar este registro? " + lb, "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i, o;
                    SqlCommand cmd = new SqlCommand("delete from pago where idPago='" + lb + "'", cnn.conn);
                    SqlCommand cmd1 = new SqlCommand("delete from Pagos where idPagos='" + lb2 + "'", cnn.conn);
                    o = cmd1.ExecuteNonQuery();
                    i = cmd.ExecuteNonQuery();                    
                    if (i > 0 && o > 0)
                    {
                        MessageBox.Show("Pago eliminado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue eliminado por alguna razón misteriosa. ;_;");
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
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// funcion para autocompletar escritura de un combobox
        /// </summary>
        /// <param name="text">texto de entrada</param>
        public void autocompletarcombo(ComboBox text)
        {
            try
            {
                string query = "Select NombreCompleto, idCliente from Cliente";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["NombreCompleto"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["equipo"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["fecha"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// Borra una mensualidad
        /// </summary>
        /// <param name="mensualidades">id de mensualidades</param>
        /// <param name="mensualidad">id de mensualidad</param>
        /// <param name="Cliente">id de cliente</param>
        public void BorrarMensualidad(int mensualidades, int mensualidad, int Cliente)
        {
            try
            {

                if (MessageBox.Show("Borrará todos los pagos de este cliente... \n ¿Desea continuar? " + mensualidad, "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i, y;
                    SqlCommand cmd = new SqlCommand("delete from Mensualidad where idMensualidad='" + mensualidad + "' and idCliente =" + Cliente + "", cnn.conn);
                    SqlCommand sqlCommand = new SqlCommand("delete from Mensualidades where idMensualidadC='" + mensualidades + "'and idCliente =" + Cliente + "", cnn.conn);
                    y = sqlCommand.ExecuteNonQuery();
                    i = cmd.ExecuteNonQuery();
                    if (i > 0  && y>0)
                    {
                        MessageBox.Show("Pago eliminado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue eliminado por alguna razón misteriosa. ;_;");
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
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// Muestra datos de cortes en el menu principal y los guarda
        /// </summary>
        /// <param name="lv">list view de salida</param>
        /// <param name="lb">label de entrada</param>
        public void llenarCortes(ListView lv, Label lb)
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago,DATEADD(m, 1, dbo.Mensualidad.fechaPago) as corte, SUM(dbo.Cliente.ClavePago) as total FROM dbo.Cliente INNER JOIN dbo.Segmentacion ON dbo.Segmentacion.IdCliente = dbo.Cliente.idCliente INNER JOIN dbo.municipios ON dbo.municipios.idMunicipio = dbo.Cliente.idMunicipio INNER JOIN dbo.Mensualidades ON dbo.Mensualidades.idCliente = dbo.Cliente.idCliente INNER JOIN dbo.Mensualidad ON dbo.Mensualidades.idMensualidad = dbo.Mensualidad.idMensualidad where fechapago= CONVERT (date, SYSDATETIME()) group by dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                lv.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["ip"].ToString());
                    elementos.SubItems.Add(filas["fechaPago"].ToString());
                    elementos.SubItems.Add(filas["corte"].ToString());
                    elementos.SubItems.Add(filas["total"].ToString());
                    lb.Text = filas["total"].ToString();
                    if (MessageBox.Show("¿Desea realizar agregar los cortes? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String idCliente = filas["idCliente"].ToString();
                        String NombreCompleto = filas["NombreCompleto"].ToString();
                        String Nombre = filas["Nombre"].ToString();
                        String ip = filas["ip"].ToString();
                        DateTime fechapago = Convert.ToDateTime(filas["fechaPago"]);
                        DateTime corte = Convert.ToDateTime(filas["corte"].ToString());
                        String total = filas["total"].ToString();
                        SqlCommand cmd = new SqlCommand("dbo.spProcedureAgregarCorte", cnn.conn);
                        cmd.Parameters.AddWithValue("@cliente", NombreCompleto);
                        cmd.Parameters.AddWithValue("@lugar", Nombre);
                        cmd.Parameters.AddWithValue("@ip", ip);
                        cmd.Parameters.AddWithValue("@mensualidad", fechapago);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@corte", corte);
                        cnn.Conectar();
                        cmd.CommandType = CommandType.StoredProcedure;
                        int j;
                        j = cmd.ExecuteNonQuery();
                        if (j > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd.Dispose();
                        }
                       
                    }
                    
                    lv.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal " + ex);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// autocompleta texto en un combobox
        /// </summary>
        /// <param name="text"> texto de consulta de busqueda</param>
        public void autocompletarmunicipio(ComboBox text)
        {
            try
            {
                string query = "Select Nombre, idMunicipio from municipios";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["Nombre"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["equipo"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["fecha"].ToString());
                    //text.AutoCompleteCustomSource.Add(dr["descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// filtra mensualidades
        /// </summary>
        /// <param name="lv">listview de salida</param>
        /// <param name="date">fecha de entrada y lectura de datos</param>
        public void filtrarmesualidad(ListView lv, DateTime date)
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago, DATEADD(m, 1, dbo.Mensualidad.fechaPago) AS corte, SUM(dbo.Cliente.ClavePago) as total FROM dbo.Cliente INNER JOIN dbo.Segmentacion ON dbo.Segmentacion.IdCliente = dbo.Cliente.idCliente INNER JOIN dbo.municipios ON dbo.municipios.idMunicipio = dbo.Cliente.idMunicipio INNER JOIN dbo.Mensualidades ON dbo.Mensualidades.idCliente = dbo.Cliente.idCliente INNER JOIN dbo.Mensualidad ON dbo.Mensualidades.idMensualidad = dbo.Mensualidad.idMensualidad WHERE dbo.Mensualidad.fechaPago = '"+ date +"' group by dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago ", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                lv.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["ip"].ToString());
                    elementos.SubItems.Add(filas["fechaPago"].ToString());
                    elementos.SubItems.Add(filas["corte"].ToString());
                    elementos.SubItems.Add(filas["total"].ToString());
                    lv.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal " + ex);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        /// <summary>
        /// autocompleta clientes 
        /// </summary>
        /// <param name="text">texto de entrada</param>
        /// <param name="comboBox">texto de salida</param>
        public void autocompletarClienteMensualidad(ComboBox text, ComboBox comboBox)
        {
            try
            {
                string query = "SELECT C.idCliente, C.NombreCompleto, C.idMunicipio, M.idMunicipio FROM dbo.Cliente C INNER JOIN dbo.municipios M on (C.idMunicipio = M.idMunicipio) WHERE C.idMunicipio ='"+ comboBox.SelectedValue +"'";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["NombreCompleto"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;_; " + ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }


    }
}
