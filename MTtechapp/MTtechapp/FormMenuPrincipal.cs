using MaterialSkin;
using MaterialSkin.Controls;
using MTtechapp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace MTtechapp
{
    public partial class FormMenuPrincipal : MaterialForm
    {
        String usuario;
        String contra;
        private readonly MaterialSkinManager materialSkinManager;
        public List<Cliente> lista_Clientes = new List<Cliente>();
        public static List<Municipio> municipios = new List<Municipio>();
        public FormMenuPrincipal(String usuario, String contra)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            this.usuario = usuario;
            this.contra = contra;
            metodos.autocompletaragenda(txtagen);
            metodos.autocompletarpago(textBox1);
            metodos.autocompletarmunicipio(cbLugarTorre);
            metodos.autocompletarcombo(cbClienteAgenda);
            metodos.llenarCortes(lvCortes, lvTotal);
            autocompletar(txtbuscarid);
        }
        public FormMenuPrincipal()
        {
        }
        private void txtagregar_Click(object sender, EventArgs e)
        {
            FormAgregar fa = new FormAgregar();
            fa.ShowDialog();
        }
        conexion cnn = new conexion();
        public void LlenarListView()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT S.IdCliente,C.NombreCompleto AS Nombre, C.telefono, C.direccion, S.router, S.ip, S.comentario, CASE C.activo WHEN 'True' THEN 'Si' ELSE 'No' END AS activo, C.FechaInstalacion, S.IdCliente, C.ClavePago, M.idMunicipio, M.Nombre as Localidad, C.idMunicipio, C.idCliente FROM dbo.Cliente AS C INNER JOIN dbo.Segmentacion AS S ON(C.idCliente = S.IdCliente) INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio ORDER BY Nombre ASC ", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.lvClientes.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["telefono"].ToString());
                    elementos.SubItems.Add(filas["direccion"].ToString());
                    elementos.SubItems.Add(filas["router"].ToString());
                    elementos.SubItems.Add(filas["ip"].ToString());
                    elementos.SubItems.Add(filas["comentario"].ToString());
                    elementos.SubItems.Add(Convert.ToString(filas["activo"]));
                    elementos.SubItems.Add(Convert.ToString(filas["FechaInstalacion"]));
                    elementos.SubItems.Add(filas["ClavePago"].ToString());
                    elementos.SubItems.Add(filas["Localidad"].ToString());
                    elementos.SubItems.Add(filas["idMunicipio"].ToString());
                    lvClientes.Items.Add(elementos);
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Ocurrio un error en la base de datos " + sql);
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
        public void llenarPagos()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT P.idPago, C.NombreCompleto, P.nombreArticulo, P.Precio, C.idCliente, PS.idCliente AS cliente, PS.idPago AS pago, C.telefono, C.direccion, P.cantidad, (P.cantidad* P.Precio) as total, PS.idPagos,P.fechaPago FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago = PS.idPago)", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                cnn.Conectar();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.lvPagos.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                    elementos.SubItems.Add(filas["direccion"].ToString());
                    elementos.SubItems.Add(filas["telefono"].ToString());
                    elementos.SubItems.Add(filas["cantidad"].ToString());
                    elementos.SubItems.Add(filas["precio"].ToString());
                    elementos.SubItems.Add(filas["total"].ToString());
                    elementos.SubItems.Add(filas["idPago"].ToString());
                    elementos.SubItems.Add(filas["pago"].ToString());
                    elementos.SubItems.Add(filas["fechaPago"].ToString());
                    lvPagos.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("algo salio mal ;_; " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public void cargaEquipo()
        {
            var items = new[] {
            new { Text = "Equipo 1", Value = "1" },
            new { Text = "Equipo 2", Value = "2" } };
            cbEquipo.DisplayMember = "Text";
            cbEquipo.ValueMember = "Value";
            cbEquipo.DataSource = items;
        }
        public void cargaHerramientas()
        {
            var items = new[] {
            new { Text = "Graficar clientes", Value = "1" },
            new { Text = "Agregar herramientas", Value = "2" } };

            cbGrapic.DisplayMember = "Text";
            cbGrapic.ValueMember = "Value";
            cbGrapic.DataSource = items;
        }

        ClassMetodos metodos = new ClassMetodos();
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            FormPrincipal1 form = new FormPrincipal1();
            form.Close();
            LlenarListView();
            llenarPagos();
            cargaEquipo();
            Llenarlv();
            llenarAgenda();
            cargaHerramientas();
            this.ContextMenuStrip = PoppupMenu;
            materialTabControl1.TabPages.Remove(tabPage3);
            Settings.Default.recordar = materialCheckBox2.Checked;
        }
        public static double A = 0;
        public void sumar()
        {
            foreach (ListViewItem I in lvPagos.Items)
            {
                A += double.Parse(I.SubItems[6].Text);
                lvTotal.Text = A.ToString();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    string sql = "SELECT P.idPago, C.NombreCompleto, P.nombreArticulo, P.Precio, C.idCliente, PS.idCliente AS cliente, PS.idPago AS pago, C.telefono, C.direccion, P.cantidad, (P.cantidad* P.Precio) as total, PS.idPagos,P.fechaPago FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago = PS.idPago) where C.NombreCompleto like '%" + textBox1.Text + "%'or P.nombreArticulo like '%" + textBox1.Text + "%' or P.Precio like '%" + textBox1.Text + "%' or C.telefono like '%" + textBox1.Text + "%'or C.direccion like '%" + textBox1.Text + "%' or P.cantidad like '%" + textBox1.Text + "%'or P.precio like '%" + textBox1.Text + "%'";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, cnn.cn);
                    DataSet ds = new DataSet();
                    DataTable tabla = new DataTable();
                    adaptador.Fill(ds);
                    tabla = ds.Tables[0];
                    this.lvPagos.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elementos = new ListViewItem(filas["NombreCompleto"].ToString());
                        elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                        elementos.SubItems.Add(filas["direccion"].ToString());
                        elementos.SubItems.Add(filas["telefono"].ToString());
                        elementos.SubItems.Add(filas["cantidad"].ToString());
                        elementos.SubItems.Add(filas["precio"].ToString());
                        elementos.SubItems.Add(filas["total"].ToString());
                        elementos.SubItems.Add(filas["idPago"].ToString());
                        elementos.SubItems.Add(filas["pago"].ToString());
                        elementos.SubItems.Add(filas["fechaPago"].ToString());
                        lvPagos.Items.Add(elementos);
                    }
                }
                else if (String.IsNullOrEmpty(textBox1.Text))
                {
                    metodos.buscarpago(lvPagos, dtpAgenda, textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fecha. :^)");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Error database engine" + sql, "MTtech,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error, " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FormPago fp = new FormPago();
            fp.carga();
            fp.ShowDialog();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            sumar();
        }
        public void autocompletar(TextBox text)
        {
            try
            {
                string query = "Select S.IdCliente, C.NombreCompleto, C.telefono, C.direccion, S.router, S.ip,S.comentario,C.activo, C.FechaInstalacion, S.IdCliente from Cliente C inner join Segmentacion S on(C.idCliente=S.IdCliente)";
                SqlCommand cmd = new SqlCommand(query, cnn.conn);
                SqlDataReader dr;
                cnn.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    text.AutoCompleteCustomSource.Add(dr["NombreCompleto"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["telefono"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["direccion"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["router"].ToString());
                    text.AutoCompleteCustomSource.Add(dr["ip"].ToString());
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
        private void btnBuscar11_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvClientes.Items.Clear();
                if (String.IsNullOrEmpty(txtbuscarid.Text))
                {
                    MessageBox.Show("No puedes dejar espacios vacios", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                String kek = txtbuscarid.Text;
                if (kek.Equals("Cerrar", StringComparison.InvariantCultureIgnoreCase))
                {
                    Application.Exit();
                }
                else if (kek.Equals("cambiar", StringComparison.InvariantCultureIgnoreCase))
                {
                    FormCambiar cambiar = new FormCambiar(usuario, contra);
                    cambiar.Show();
                }
                else if (kek.Equals("Sesion", StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Hide();
                    FormPrincipal1 principal1 = new FormPrincipal1();
                    principal1.Show();
                }
                else
                {
                    cnn.Conectar();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT S.IdCliente,C.NombreCompleto AS Nombre, C.telefono, C.direccion, S.router, S.ip, S.comentario, CASE C.activo WHEN 'True' THEN 'Si' ELSE 'No' END AS activo, C.FechaInstalacion, S.IdCliente, C.ClavePago, M.idMunicipio, M.Nombre as Localidad, C.idMunicipio, C.idCliente FROM dbo.Cliente AS C INNER JOIN dbo.Segmentacion AS S ON(C.idCliente = S.IdCliente) INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio where C.NombreCompleto like '%" + txtbuscarid.Text + "%' or C.telefono like '%" + txtbuscarid.Text + "%' or C.direccion like'%" + txtbuscarid.Text + "%' or S.router like'%" + txtbuscarid.Text + "%' or S.ip like'%" + txtbuscarid.Text + "%' or S.comentario like'%" + txtbuscarid.Text + "%'", cnn.cn);
                    DataSet ds = new DataSet();
                    DataTable tabla = new DataTable();
                    adaptador.Fill(ds);
                    tabla = ds.Tables[0];
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                        elementos.SubItems.Add(filas["Nombre"].ToString());
                        elementos.SubItems.Add(filas["telefono"].ToString());
                        elementos.SubItems.Add(filas["direccion"].ToString());
                        elementos.SubItems.Add(filas["router"].ToString());
                        elementos.SubItems.Add(filas["ip"].ToString());
                        elementos.SubItems.Add(filas["comentario"].ToString());
                        elementos.SubItems.Add(Convert.ToString(filas["activo"]));
                        elementos.SubItems.Add(Convert.ToString(filas["FechaInstalacion"]));
                        elementos.SubItems.Add(filas["ClavePago"].ToString());
                        elementos.SubItems.Add(filas["Localidad"].ToString());
                        elementos.SubItems.Add(filas["idMunicipio"].ToString());
                        lvClientes.Items.Add(elementos);
                    }
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
        private void RBactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (RBactivos.Checked)
                {
                    cnn.Conectar();
                    this.lvClientes.Items.Clear();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT S.IdCliente,C.NombreCompleto AS Nombre, C.telefono, C.direccion, S.router, S.ip, S.comentario, CASE C.activo WHEN 'True' THEN 'Si' ELSE 'No' END AS activo, C.FechaInstalacion, S.IdCliente, C.ClavePago, M.idMunicipio, M.Nombre as Localidad, C.idMunicipio, C.idCliente FROM dbo.Cliente AS C INNER JOIN dbo.Segmentacion AS S ON(C.idCliente = S.IdCliente) INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio where C.activo = 'true' and M.idMunicipio = '" + cbmunicipios.SelectedValue + "'", cnn.cn);
                    DataSet ds = new DataSet();
                    DataTable tabla = new DataTable();
                    adaptador.Fill(ds);
                    tabla = ds.Tables[0];
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                        elementos.SubItems.Add(filas["Nombre"].ToString());
                        elementos.SubItems.Add(filas["telefono"].ToString());
                        elementos.SubItems.Add(filas["direccion"].ToString());
                        elementos.SubItems.Add(filas["router"].ToString());
                        elementos.SubItems.Add(filas["ip"].ToString());
                        elementos.SubItems.Add(filas["comentario"].ToString());
                        elementos.SubItems.Add(filas["activo"].ToString());
                        elementos.SubItems.Add(filas["FechaInstalacion"].ToString());
                        elementos.SubItems.Add(filas["ClavePago"].ToString());
                        lvClientes.Items.Add(elementos);
                    }

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
        private void RBdesacctivados_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cnn.Conectar();
                this.lvClientes.Items.Clear();
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT S.IdCliente,C.NombreCompleto AS Nombre, C.telefono, C.direccion, S.router, S.ip, S.comentario, CASE C.activo WHEN 'True' THEN 'Si' ELSE 'No' END AS activo, C.FechaInstalacion, S.IdCliente, C.ClavePago, M.idMunicipio, M.Nombre as Localidad, C.idMunicipio, C.idCliente FROM dbo.Cliente AS C INNER JOIN dbo.Segmentacion AS S ON(C.idCliente = S.IdCliente) INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio where C.activo = 'false' and M.idMunicipio = '" + cbmunicipios.SelectedValue + "'", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["telefono"].ToString());
                    elementos.SubItems.Add(filas["direccion"].ToString());
                    elementos.SubItems.Add(filas["router"].ToString());
                    elementos.SubItems.Add(filas["ip"].ToString());
                    elementos.SubItems.Add(filas["comentario"].ToString());
                    elementos.SubItems.Add(filas["activo"].ToString());
                    elementos.SubItems.Add(filas["FechaInstalacion"].ToString());
                    elementos.SubItems.Add(filas["ClavePago"].ToString());
                    lvClientes.Items.Add(elementos);
                }
            }
            catch (Exception)
            {

                throw;
            }

            cnn.Desconectar();
        }

        private void cbmunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lvClientes.Items.Clear();
            int selected = Convert.ToInt32(cbmunicipios.SelectedValue);
            try
            {
                OleDbDataAdapter cmd = new OleDbDataAdapter("Select C.idCliente, C.NombreCompleto, C.telefono, C.direccion, S.router, S.ip,C.activo,S.comentario,M.Nombre,M.idMunicipio, S.idSegmentacion from Cliente C inner join Segmentacion S on(C.idCliente=S.IdCliente) inner join  municipios M on(M.idMunicipio=C.idMunicipio) where M.idMunicipio=" + selected + "", cnn.cn);
                cnn.Conectar();
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                cmd.Fill(ds);
                tabla = ds.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["telefono"].ToString());
                    elementos.SubItems.Add(filas["direccion"].ToString());
                    elementos.SubItems.Add(filas["router"].ToString());
                    elementos.SubItems.Add(filas["ip"].ToString());
                    elementos.SubItems.Add(filas["comentario"].ToString());
                    elementos.SubItems.Add(filas["activo"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    lvClientes.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal :(" + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmunicipios.SelectedValue.Equals(-1))
                {
                    MessageBox.Show("debes de reseleccionar el municipio");
                }
                else
                {
                    FormVistaPagos fp = new FormVistaPagos(Convert.ToInt32(cbmunicipios.SelectedValue));
                    fp.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes reseleccionar el municipio. ");

            }
        }

        private void btnMensualidad_Click(object sender, EventArgs e)
        {
            FormPagoMensualidad mensualidad = new FormPagoMensualidad();
            mensualidad.ShowDialog();
        }
        public static List<ClaseInformeAgenda> lista = new List<ClaseInformeAgenda>();

        private void txtagenda_Click(object sender, EventArgs e)
        {
            try
            {
                string theDate = dtpAgenda.Value.ToString("yyyy-MM-dd");

                if (comboBox1.SelectedIndex.Equals(-1) )
                {
                    MessageBox.Show("No debes dejar campos vacios", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    bool realizadoCliente, realizadoOtro, RealizadoTorre;
                    if (cbrealizado.Checked== true)
                    {
                        realizadoCliente = true;
                    }
                    else
                    {
                        realizadoCliente = false;   
                    }
                    if (cbotro.Checked== true)
                    {
                        realizadoOtro = true;
                    }
                    else
                    {
                        realizadoOtro = false;
                    }
                    if (chbtoo.Checked== true)
                    {
                        RealizadoTorre = true;
                    }
                    else
                    {
                        RealizadoTorre = false;
                    }
                    SqlCommand cmd = new SqlCommand("insert into agenda(idCliente,idlugar,diagnostico,equipo,fecha,descripcion, estado, indicaciones,  prioridad, tipo) values('" + cbClienteAgenda.SelectedValue + "','" + cbLugarCliente.SelectedValue + "','" + txtDiag.Text + "','" + cbEquipo.Text + "','" + theDate + "','" + txtdescripcion1.Text + "', '"+ realizadoCliente +"', '"+ txtind.Text +"', '"+ cbprioriC.Text +"','"+ comboBox1.Text +"')", cnn.conn);
                    SqlCommand torre = new SqlCommand("insert into agenda(idCliente,idlugar,diagnostico,equipo,fecha,descripcion, estado, indicaciones,  prioridad, tipo) values('1','" + cbLugarTorre.SelectedValue + "','" + txtdiagnostico.Text + "','N/A','" + theDate + "','" + txtproblem.Text + "','" + RealizadoTorre + "', '" + txtutilizado.Text + "', '" + cbprioriGlobal.Text + "','" + comboBox1.Text + "')", cnn.conn);
                    SqlCommand global = new SqlCommand("insert into agenda(idCliente,idlugar,diagnostico,equipo,fecha,descripcion, estado, indicaciones,  prioridad, tipo) values('1','"+cbLugarGlobla.SelectedValue  +"','" + txtotrodiag.Text + "','N/A','" + theDate + "','" + txtfallo.Text + "', '" + realizadoOtro + "', '" + txtotrocoment.Text + "', '" + cbprioriGlobal.Text + "','" + comboBox1.Text + "')", cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    torre.CommandType = CommandType.Text;
                    global.CommandType = CommandType.Text;
                    if (comboBox1.Text.Equals("Cliente"))
                    {
                        cmd.ExecuteNonQuery(); 
                    }
                    else if (comboBox1.Text.Equals("Torre"))
                    {
                        torre.ExecuteNonQuery();
                    }
                    else if (comboBox1.Text.Equals("Socio")|| comboBox1.Text.Equals("Otro") || comboBox1.Text.Equals("fichas"))
                    {
                        global.ExecuteNonQuery();
                    }

                    FormReporteAgenda agenda = new FormReporteAgenda();
                    ClaseInformeAgenda agendadatos = new ClaseInformeAgenda
                    {
                        descripcion = txtdescripcion1.Text,
                        lugar = cbLugarTorre.Text,
                        Equipo = cbEquipo.Text,
                        diagnostico = txtDiag.Text,
                        cliente = cbClienteAgenda.Text
                    };
                    agenda.DatosAgenda.Add(agendadatos);
                    lista.Add(agendadatos);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal ;_; " + ex, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
                llenarAgenda();
            }
        }//insertar agenda
        public List<Cliente> CargaCombo()
        {

            try
            {
                cnn.Conectar();
                string command = "select c.idCliente, c.NombreCompleto, c.telefono,c.comentario, c.idMunicipio as MC, m.idMunicipio as MM, m.Nombre from Cliente c inner join municipios m on (c.idmunicipio= m.idMunicipio)";
                SqlCommand cmd = new SqlCommand(command, cnn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Cliente usuarios = new Cliente();
                    usuarios.idCliente = Convert.ToInt32(lector[0]);
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
            finally { cnn.Desconectar(); }
            return lista_Clientes;
        }
        public List<Municipio> Cargafiltro()
        {

            try
            {
                cnn.Conectar();
                string command = "Select M.idMunicipio, M.Nombre,C.IdMunicipio,C.IdCliente from Cliente C inner join municipios M on (C.IdMunicipio= M.Idmunicipio) where c.idCliente='" + cbClienteAgenda.SelectedValue +"'";
                SqlCommand cmd = new SqlCommand(command, cnn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Municipio usuarios = new Municipio();
                    usuarios.idMunicipio = lector[0].ToString();
                    usuarios.Nombre = lector[1].ToString();
                    municipios.Add(usuarios);
                }
                lector.Close();
                
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
            return municipios;
        }


        public List<Municipio> Cargamunicipio()
        {
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("select * from municipios ", cnn.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Municipio usuarios = new Municipio();
                    usuarios.idMunicipio = lector.GetInt32(0).ToString();
                    usuarios.Nombre = lector[1].ToString();
                    municipios.Add(usuarios);
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
            return municipios;
        }
        public void cargaCliente()
        {
            lista_Clientes.Clear();
            cbClienteAgenda.DataSource = null;
            cbClienteAgenda.DisplayMember = "NombreCompleto";
            cbClienteAgenda.ValueMember = "idCliente";
            cbClienteAgenda.DataSource = CargaCombo();
        }
        public void cargafiltro()
        {
            municipios.Clear();
            cbLugarCliente.DataSource = null;
            cbLugarCliente.DisplayMember = "Nombre";
            cbLugarCliente.ValueMember = "idMunicipio";
            cbLugarCliente.DataSource = Cargafiltro();
        }

        public void cargaMuni()
        {
            municipios.Clear();
            cbLugarTorre.DataSource = null;
            cbLugarTorre.DisplayMember = "Nombre";
            cbLugarTorre.ValueMember = "idMunicipio";
            cbLugarTorre.DataSource = Cargamunicipio();
        }
        private void cbLugar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            municipios.Clear();
            cargaMuni();
        }
        private void cbmunicipios_Click(object sender, EventArgs e)
        {
            municipios.Clear();
            cbmunicipios.DisplayMember = "Nombre";
            cbmunicipios.ValueMember = "idmunicipio";
            cbmunicipios.DataSource = Cargamunicipio();
        }
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
        private int colorSchemeIndex;
        private void materialTabSelector1_DoubleClick(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2) colorSchemeIndex = 0;

            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }
        private void lbmas_Click(object sender, EventArgs e)
        {

        }
        public void limpiard()
        {
            txtUsuario.Clear();
            txtpasss.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text) || cbNivel.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Usuario values('" + txtUsuario.Text + "','" + txtpasss.Text + "','" + cbNivel.Text + "')", cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd1 = new SqlCommand("update Segmentacion set router= '" + txtrouter.Text + "',ip='" + txtIp.Text + "', comentario='" + txtCometarioip.Text + "' where idCliente="+ Convert.ToInt32(lbid.Text)+ "", conn.conn);
                    MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiard();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal..." + ex);
            }
            finally
            {
                cnn.Desconectar();
                Llenarlv();
            }
        }

        public void Llenarlv()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select U.idusuario, U.usuario, U.password, U.idRol, r.idrol from Usuario U inner join roles r on (U.idRol=r.idrol)", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.lvUsuarios.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idusuario"].ToString());
                    elementos.SubItems.Add(filas["usuario"].ToString());
                    lvUsuarios.Items.Add(elementos);
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
        public void carganivel()
        {
            var items = new[] {
            new { Text = "1", Value = "1" },
            new { Text = "2", Value = "2" }, };
            cbNivel.DisplayMember = "Text";
            cbNivel.ValueMember = "Value";
            cbNivel.DataSource = items;
        }
        private void btnActual_Click(object sender, EventArgs e)
        {
            string item = lvUsuarios.SelectedItems[0].SubItems[0].Text;
            btnActual.Visible = true;
            this.lvUsuarios.Items.Clear();
            SqlCommand cmd = new SqlCommand("update Usuario set usuario='" + txtUsuario.Text + "',password='" + txtpasss.Text + "',idRol=" + Convert.ToInt32(cbNivel.SelectedValue) + " where idusuario=" + Convert.ToInt32(item) + "", cnn.conn);

            try
            {
                int i;
                cnn.Conectar();
                cmd.CommandType = CommandType.Text;
                i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString());
                if (i < 0)
                {
                    MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnActual.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error ;_;");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal :( " + ex.Message);
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        private void limpiar()
        {
            txtUsuario.Clear();
            txtpasss.Clear();
        }
        private void llenarAgenda()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT A.idagenda, A.idlugar, A.diagnostico, A.equipo, A.fecha,A.descripcion, A.tipo, M.Nombre, ISNULL (C.NombreCompleto, 'N/A') as NombreCompleto, A.idCliente from agenda A INNER JOIN municipios M on (A.idlugar = M.idMunicipio) INNER JOIN cliente C on (C.idCliente= A.idCliente)", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.lvAgenda.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];

                    ListViewItem elementos = new ListViewItem(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["tipo"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["diagnostico"].ToString());
                    elementos.SubItems.Add(filas["descripcion"].ToString());
                    elementos.SubItems.Add(filas["equipo"].ToString());
                    elementos.SubItems.Add(filas["idagenda"].ToString());
                    elementos.SubItems.Add(filas["fecha"].ToString());
                    elementos.SubItems.Add(filas["idCliente"].ToString());
                    lvAgenda.Items.Add(elementos);
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
        }//llenar agenda
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CrearDoc();
            lista.Clear();
            CargarSeleccionados();
            FormReporteAgenda formReporte = new FormReporteAgenda();
            formReporte.ShowDialog();
        }

        private void cbLugar_MouseClick(object sender, MouseEventArgs e)
        {
            cargaMuni();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormMunicipio municipio = new FormMunicipio();
            municipio.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormMunicipio usuarios = new FormMunicipio();
            usuarios.btnActualizar.Visible = true;
            usuarios.btnAgregar.Visible = false;
            try
            {
                cnn.Conectar();
                SqlCommand cmd = new SqlCommand("select idMunicipio, Nombre from municipios where idMunicipio= '" + cbLugarTorre.SelectedValue + "'", cnn.conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    usuarios.txtmunicipios.Text = lector[1].ToString();
                    usuarios.lbid.Text = lector[0].ToString();
                    usuarios.ShowDialog();
                }
                lector.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static List<ClaseInformeAgenda> Instalaciones = new List<ClaseInformeAgenda>();
        public List<ClaseInformeAgenda> CargarSeleccionadosIns()
        {
            foreach (var item in lvAgenda.SelectedItems.Cast<ListViewItem>())
            {
                ClaseInformeAgenda informeAgenda = new ClaseInformeAgenda();
                String Consulta = "Select NombreCompleto, direccion, telefono, ClavePago, tipo from Cliente where idCliente= " + item.SubItems[7].Text.ToString() + " and tipo= '"+ item.SubItems[6].Text.ToString() + "'";
                SqlCommand sql = new SqlCommand(Consulta, cnn.conn);
                cnn.Conectar();
                SqlDataReader dr = sql.ExecuteReader();
                informeAgenda.cliente = item.SubItems[0].Text.ToString();
                informeAgenda.lugar = item.SubItems[1].Text.ToString();
                informeAgenda.diagnostico = item.SubItems[2].Text.ToString();
                informeAgenda.descripcion = item.SubItems[3].Text.ToString();
                informeAgenda.Equipo = item.SubItems[4].Text.ToString();
                informeAgenda.fecha = item.SubItems[5].Text.ToString();
                if (item.SubItems[0].Text.Contains("N/A"))
                {
                    //
                }
                else
                {
                    while (dr.Read())
                    {
                        informeAgenda.domicilio = dr.GetString(1);
                        informeAgenda.Tel = dr.GetString(2);
                    }
                }

                dr.Close();

                Instalaciones.Add(informeAgenda);
            }
            return Instalaciones;
        }
        public List<ClaseInformeAgenda> CargarSeleccionados()
        {
            foreach (var item in lvAgenda.SelectedItems.Cast<ListViewItem>())
            {
                ClaseInformeAgenda informeAgenda = new ClaseInformeAgenda();
                String Consulta = "Select NombreCompleto, direccion, telefono, ClavePago from Cliente where idCliente= " + item.SubItems[7].Text.ToString() + "";
                SqlCommand sql = new SqlCommand(Consulta, cnn.conn);
                cnn.Conectar();
                SqlDataReader dr = sql.ExecuteReader();
                informeAgenda.cliente = item.SubItems[0].Text.ToString();
                informeAgenda.lugar = item.SubItems[1].Text.ToString();
                informeAgenda.diagnostico = item.SubItems[2].Text.ToString();
                informeAgenda.descripcion = item.SubItems[3].Text.ToString();
                informeAgenda.Equipo = item.SubItems[4].Text.ToString();
                informeAgenda.fecha = item.SubItems[5].Text.ToString();
                if (item.SubItems[0].Text.Contains("N/A"))
                {
                    //
                }
                else
                {
                    while (dr.Read())
                    {
                        informeAgenda.domicilio = dr.GetString(1);
                        informeAgenda.Tel = dr.GetString(2);
                    }
                }
                
                dr.Close();

                lista.Add(informeAgenda);
            }
            return lista;
        }
        private void CrearDoc()
        {
            try
            {
                string texto = "";
                foreach (var item in lvAgenda.SelectedItems.Cast<ListViewItem>())
                {
                    ClaseInformeAgenda informeAgenda = new ClaseInformeAgenda();
                    informeAgenda.cliente = item.SubItems[0].Text.ToString();
                    informeAgenda.lugar = item.SubItems[1].Text.ToString();
                    informeAgenda.diagnostico = item.SubItems[2].Text.ToString();
                    informeAgenda.descripcion = item.SubItems[3].Text.ToString();
                    informeAgenda.Equipo = item.SubItems[4].Text.ToString();
                    informeAgenda.fecha = item.SubItems[5].Text.ToString();
                    informeAgenda.tipo = item.SubItems[6].Text.ToString();
                  
                        texto = "Agenda del dia " + DateTime.Now.ToLongDateString() + " \n" +
                   "" +
                   "----------------------------------------------\n"+
                        "Revisar  " + item.SubItems[0].Text.ToString() + "\n";
                    lista.Add(informeAgenda);
                }
                string rutaCompleta = @" C:\Users\MT Network's\Desktop\Agenda.txt";
               

                using (StreamWriter mylogs = File.AppendText(rutaCompleta))         //se crea el archivo
                {

                    mylogs.WriteLine(texto);

                    mylogs.Close();


                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cbEquipo_MouseClick(object sender, MouseEventArgs e)
        {
            //cargadefault();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Formticked t = new Formticked(lvPagos);
            t.ShowDialog();

        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            //FormAgregar fag = new FormAgregar();
            //string idCl = this.lvClientes.SelectedItems[0].SubItems[0].Text;
            //MessageBox.Show(idCl);

        }
      
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            metodos.BuscarUsuario(materialSingleLineTextField2.Text, lvUsuarios);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            metodos.BuscarAgenda(txtagen.Text, lvAgenda);
        }
        private void btncalc_Click(object sender, EventArgs e)
        {
            FormMensaje cal = new FormMensaje();
            cal.ShowDialog();
        }
        private void lvPagos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClassMetodos metodos = new ClassMetodos();
            metodos.clickpagos(lvPagos);
        }

        private void lvUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnActual.Visible = true;
                cnn.Conectar();
                int id = Convert.ToInt32(this.lvUsuarios.SelectedItems[0].SubItems[0].Text);
                SqlCommand cmd = new SqlCommand("Select U.usuario, U.password, U.idRol, r.idrol, U.idusuario from Usuario U inner join roles r on (U.idRol=r.idrol) where U.idusuario=" + id + "", cnn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtUsuario.Text = dr[0].ToString();
                    txtpasss.Text = dr[1].ToString();
                    cbNivel.Text = dr.GetInt32(2).ToString();
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
        private void LimpiarTorre()
        {
            txtid.ResetText();
            dtpAgenda.Refresh();
            cbLugarTorre.Refresh();
            txtutilizado.Clear();
            txtproblem.Clear();
            txtdiagnostico.Clear();
            chbtoo.Checked = false;
            cbtorre.Refresh();
        }
        private void LimpiarCliente()
        {
            txtid.ResetText();
            dtpAgenda.Refresh();
            cbLugarCliente.Refresh();
            txtind.Clear();
            txtdescripcion1.Clear();
            txtDiag.Clear();
            cbrealizado.Checked = false;
            cbprioriC.Refresh();
        }
        private void LimpiarOtro()
        {
            txtid.ResetText();
            dtpAgenda.Refresh();
            cbLugarGlobla.Refresh();
            txtotrocoment.Clear();
            txtfallo.Clear();
            txtotrodiag.Clear();
            cbotro.Checked = false;
            cbprioriGlobal.Refresh();

        }

        private void lvAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(lvAgenda.SelectedItems[0].SubItems[6].Text);
            MessageBox.Show("Esto sale-> " + id);
            try
            {
                cnn.Conectar();
                string sql = "SELECT A.idagenda, A.idlugar, A.diagnostico, A.equipo, A.fecha, A.descripcion, M.Nombre, ISNULL( C.NombreCompleto, 'N/A' ) AS NombreCompleto, A.idCliente, A.estado, A.indicaciones, A.prioridad, A.tipo, M.idMunicipio, C.idCliente, C.NombreCompleto, C.telefono, C.direccion, C.ClavePago FROM dbo.agenda AS A INNER JOIN dbo.municipios AS M ON (A.idlugar = M.idMunicipio) INNER JOIN dbo.Cliente AS C ON (C.idCliente = A.idCliente) where A.idagenda=" + id + "";
                SqlCommand cmd = new SqlCommand(sql, cnn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataSet dataset = new DataSet();
                if (dr.Read())
                {
                    if (dr.GetString(12).Equals("Torre"))
                    {
                        LimpiarCliente();
                        LimpiarOtro();
                        gbTorre.Location = new System.Drawing.Point(25, 112);
                        grupoCliente.Visible = false;
                        gbTorre.Visible = true;
                        gbglobal.Visible = false;
                        btnActualizar.Visible = true;
                        txtagenda.Visible = false;
                        btncancelar.Visible = true;
                        comboBox1.Text = dr.GetString(12);//combo tipo
                        txtid.Text = dr.GetInt32(0).ToString(); //ID ID
                        dtpAgenda.Text = dr[4].ToString();//Fecha agenda
                        cbLugarTorre.SelectedValue = dr[6].ToString();
                        txtutilizado.Text = dr[10].ToString();//indicaciones
                        txtproblem.Text = dr[5].ToString();//descipción
                        txtdiagnostico.Text = dr[2].ToString();//diagnostico
                        chbtoo.Checked = dr.GetBoolean(9);
                        cbtorre.Text = dr.GetString(11);
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                        {
                            da.Fill(dataset);
                        }
                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            cbLugarTorre.DataSource = dataset.Tables[0];
                            cbLugarTorre.DisplayMember = "Nombre";
                            cbLugarTorre.ValueMember = "idMunicipio";
                        }
                        dr.Close();

                    }
                    else if (dr.GetString(12).Equals("Cliente"))
                    {
                        LimpiarOtro();
                        LimpiarTorre();
                        grupoCliente.Location = new System.Drawing.Point(25, 113);
                        grupoCliente.Visible = true;
                        gbTorre.Visible = false;
                        gbglobal.Visible = false;
                        btnActualizar.Visible = true;
                        txtagenda.Visible = false;
                        btncancelar.Visible = true;
                        comboBox1.Text = dr.GetString(12);
                        cbEquipo.Text = dr.GetString(3);//combo tipo
                        txtid.Text = dr.GetInt32(0).ToString();//ID ID
                        dtpAgenda.Text = dr[4].ToString();//Fecha agenda
                        cbLugarCliente.SelectedValue = dr[6].ToString();//combo lugar
                        txtind.Text = dr[10].ToString();//indicaciones
                        txtdescripcion1.Text = dr[5].ToString();//descipción
                        txtDiag.Text = dr[2].ToString();//diagnostico
                        cbrealizado.Checked = dr.GetBoolean(9);//check realizado
                        cbprioriC.Text = dr.GetString(11);//combo nivel
                        dr.Close();
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                        {
                            da.Fill(dataset);
                        }
                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            cbLugarCliente.DataSource = dataset.Tables[0];
                            cbLugarCliente.DisplayMember = "Nombre";
                            cbLugarCliente.ValueMember = "idMunicipio";
                            cbClienteAgenda.DataSource = dataset.Tables[0];
                            cbClienteAgenda.DisplayMember = "NombreCompleto";
                            cbClienteAgenda.ValueMember = "idCliente";
                        }
                    }

                    else if (dr.GetString(12).Equals("otro")|| dr.GetString(12).Equals("fichas")|| dr.GetString(12).Equals("Socio"))
                    {
                        LimpiarTorre();
                        LimpiarCliente();
                        gbglobal.Location = new System.Drawing.Point(25, 112);
                        grupoCliente.Visible = false;
                        gbTorre.Visible = false;
                        gbglobal.Visible = true;
                        btnActualizar.Visible = true;
                        txtagenda.Visible = false;
                        btncancelar.Visible = true;
                        comboBox1.Text = dr.GetString(12);//combo tipo
                        txtid.Text = dr.GetInt32(0).ToString();//ID ID
                        dtpAgenda.Text = dr[4].ToString();//Fecha agenda
                        cbLugarGlobla.SelectedValue = dr[6].ToString();//combo lugar
                        txtotrocoment.Text = dr[10].ToString();//indicaciones
                        txtfallo.Text = dr[5].ToString();//descipción
                        txtotrodiag.Text = dr[2].ToString();//diagnostico 
                        cbotro.Checked = dr.GetBoolean(9);//check realizado
                        cbprioriGlobal.Text = dr.GetString(11);//combo nivel
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                        {
                            da.Fill(dataset);
                        }
                        if (dataset.Tables[0].Rows.Count > 0)
                        {                            
                            cbLugarGlobla.DataSource = dataset.Tables[0];
                            cbLugarGlobla.DisplayMember = "Nombre";
                            cbLugarGlobla.ValueMember = "idMunicipio";
                        }
                        dr.Close();
                    }
                }
                //using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                //{
                //    da.Fill(dataset);
                //}

                //if (dataset.Tables[0].Rows.Count > 0)
                //{
                //    cbClienteAgenda.DataSource = dataset.Tables[0];
                //    cbClienteAgenda.DisplayMember = "NombreCompleto";
                //    cbClienteAgenda.ValueMember = "idCliente";
                //}
                //if (dataset.Tables[0].Rows.Count > 0)
                //{
                //    cbEquipo.DataSource = dataset.Tables[0];
                //    cbEquipo.DisplayMember = "equipo";
                //    cbEquipo.ValueMember = "equipo";
                //}
                //if (dataset.Tables[0].Rows.Count > 0)
                //{
                //    cbLugarTorre.DataSource = dataset.Tables[0];
                //    cbLugarTorre.DisplayMember = "Nombre";
                //    cbLugarTorre.ValueMember = "idlugar";
                //}
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }//Carga agenda------

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            bool Cliente, Global, torre;
            if (cbrealizado.Checked==true)
            {
                Cliente = true;
            }
            else
            {
                Cliente = false;
            }
            if (cbotro.Checked==true)
            {
                Global = true;
            }
            else
            {
                Global = false;
            }
            if (chbtoo.Checked == true)
            {
                torre = true;
            }
            else
            {
                torre = false;
            }
            //Comando de actualización de un cliente
            SqlCommand sqlCommand = new SqlCommand("update agenda set idCliente=@idCliente1,idlugar=@idlugar1,diagnostico=@diagnostico1,equipo=@equipo1,fecha=@fecha1,descripcion=@descripcion1, estado=@estado1,indicaciones=@indicaciones1,prioridad= @prioridad1,tipo=@tipo1 where idagenda=" + id + "", cnn.conn);
            sqlCommand.Parameters.AddWithValue("@idCliente1", cbClienteAgenda.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@idlugar1", cbLugarCliente.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@diagnostico1", txtDiag.Text);
            sqlCommand.Parameters.AddWithValue("@equipo1", cbEquipo.Text);
            sqlCommand.Parameters.AddWithValue("@fecha1", dtpAgenda.Value.ToShortDateString());
            sqlCommand.Parameters.AddWithValue("@descripcion1", txtdescripcion1.Text);
            sqlCommand.Parameters.AddWithValue("@idagenda1", txtid.Text);
            sqlCommand.Parameters.AddWithValue("@indicaciones1", txtind.Text);
            sqlCommand.Parameters.AddWithValue("@prioridad1", cbprioriC.Text);
            sqlCommand.Parameters.AddWithValue("@tipo1", comboBox1.Text);
            sqlCommand.Parameters.AddWithValue("@estado1", Cliente);
            //Fin
            //Torre
            SqlCommand sqlTorre = new SqlCommand("update agenda set idlugar=@idlugar2,diagnostico=@diagnostico2,fecha=@fecha2,descripcion=@descripcion2, estado=@estado2,indicaciones=@indicaciones2,prioridad= @prioridad2,tipo=@tipo2 where idagenda=" + id + "", cnn.conn);
            sqlTorre.Parameters.AddWithValue("@idlugar2", cbLugarCliente.SelectedValue);
            sqlTorre.Parameters.AddWithValue("@diagnostico2", txtdiagnostico.Text);
            //sqlCommand.Parameters.AddWithValue("@equipo", cbEquipo.Text);
            sqlTorre.Parameters.AddWithValue("@fecha2", dtpAgenda.Value.ToShortDateString().ToString());
            sqlTorre.Parameters.AddWithValue("@descripcion2", txtproblem.Text);
            sqlTorre.Parameters.AddWithValue("@idagenda2", txtid.Text);
            sqlTorre.Parameters.AddWithValue("@indicaciones2", txtutilizado.Text);
            sqlTorre.Parameters.AddWithValue("@prioridad2", chbtoo.Text);
            sqlTorre.Parameters.AddWithValue("@tipo2", comboBox1.Text);
            sqlTorre.Parameters.AddWithValue("@estado2", torre);
            //Otro
            SqlCommand sqlOtro = new SqlCommand("update agenda set idCliente=@idCliente,idlugar=@idlugar,diagnostico=@diagnostico,equipo=@equipo,fecha=@fecha,descripcion=@descripcion, estado=@estado,indicaciones=@indicaciones,prioridad= @prioridad,tipo=@tipo where idagenda=" + id + "", cnn.conn);
            sqlOtro.Parameters.AddWithValue("@idCliente", cbClienteAgenda.SelectedValue);
            sqlOtro.Parameters.AddWithValue("@idlugar", cbLugarGlobla.SelectedValue);
            sqlOtro.Parameters.AddWithValue("@diagnostico", txtotrodiag.Text);
            //sqlCommand.Parameters.AddWithValue("@equipo", cbEquipo.Text);
            sqlOtro.Parameters.AddWithValue("@fecha", dtpAgenda.Value.ToShortDateString().ToString());
            sqlOtro.Parameters.AddWithValue("@descripcion", txtfallo.Text);
            sqlOtro.Parameters.AddWithValue("@idagenda", txtid.Text);
            sqlOtro.Parameters.AddWithValue("@indicaciones", txtotrocoment.Text);
            sqlOtro.Parameters.AddWithValue("@prioridad", cbprioriC.Text);
            sqlOtro.Parameters.AddWithValue("@tipo", comboBox1.Text);
            sqlOtro.Parameters.AddWithValue("@estado", Global);
            /*
             Si este objeto pertenece a tal
                guardar valores

                Mientras cambien a tal
                guardar valores
                    commit
                    Ejecutar update
             */
            /*Si este registro pertenece a tal categoria se debe tratar como tal, pero al cambiar el tipo de registro cambia los objetos de registro
             * se debe de guardar temporalmente los datos registrados, e intentar cargarlos en un nuevo formulario, despues se guarda y limpia los campos para evitar posibles duplicaciones
             *--orden--
             * ID ID Agenda---- AUTO
             * ID ID Cliente -------0
             * ID ID Municipios-----1
             * Diagnostico----------2
             * equipo---------------3
             * fecha----------------4
             * descripción----------5
             * estado---------------6
             * indicaciones---------7
             * prioridad------------8
             * tipo-----------------9       
            */
            try
            {
                if (String.IsNullOrEmpty(txtDiag.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    cnn.Conectar();
                    sqlOtro.CommandType = CommandType.Text;
                    sqlTorre.CommandType = CommandType.Text;
                    int i=0;
                    int j=0;
                    int k=0;
                    if (comboBox1.Text.Equals("Cliente")||(comboBox1.Text.Equals("Instalacion")))
                    {
                        
                        i = sqlCommand.ExecuteNonQuery();

                    }
                    else if (comboBox1.Text.Equals("Torre"))
                    {
                         j = sqlTorre.ExecuteNonQuery();

                    }
                    else if (comboBox1.Text.Equals("otro") || comboBox1.Text.Equals("fichas") || comboBox1.Text.Equals("Socio"))
                    {

                        k = sqlOtro.ExecuteNonQuery();

                    }

                    if (i > 0|| k>0 || j>0)
                    {
                        MessageBox.Show("Datos actualizados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarAgenda();
                        LimpiarOtro();
                        LimpiarCliente();
                        btnActualizar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Algo salio mal... ;_;" + sql, "MTtech");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal... ;_;" + ex);
            }
            finally
            {
                cnn.Desconectar();
                llenarAgenda();
            }
        }

        private void limpiarAgenda()
        {
            txtdescripcion1.Clear();
            txtagen.Visible = true;
            btnActualizar.Visible = false;
            cbEquipo.DataSource = null;
            cargaEquipo();
            txtDiag.Clear();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea borrar este registro?", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lvAgenda.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debes seleccionar un item de la agenda...");
                    }
                    else
                    {
                        int id = Convert.ToInt32(this.lvAgenda.SelectedItems[0].SubItems[6].Text);
                        cnn.Conectar();
                        int ig;
                        SqlCommand cmd2 = new SqlCommand("delete from agenda where idagenda='" + Convert.ToInt32(id) + "'", cnn.conn);
                        ig = cmd2.ExecuteNonQuery();
                        if (ig >= 0)
                        {
                            MessageBox.Show("Item eliminado correctamente!", "MTtech");
                        }
                        else
                        {
                            MessageBox.Show("El item no fue eliminado por alguna razón misteriosa. ;_;");
                        }
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
                llenarAgenda();
            }
        }
        private void materialCheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (materialCheckBox2.Checked == true)
            {
                materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
                Settings.Default.modo = true;
                Settings.Default.modo = materialCheckBox2.Checked = true;
                Settings.Default.Upgrade();
            }
            else
            {
                Settings.Default.modo = false;
                Settings.Default.modo = materialCheckBox2.Checked = false;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Settings.Default.Upgrade();
            }
        }

        private void cbGrapic_MouseClick(object sender, EventArgs e)
        {
            if (cbGrapic.SelectedValue.Equals("1"))
            {
                FormGraphicClientes graphicClientes = new FormGraphicClientes();
                graphicClientes.ShowDialog();
            }
            else
            {
                FormHerramienta herramienta = new FormHerramienta();
                herramienta.Show();
            }
        }
        private void dtpBuscaragenda_CloseUp(object sender, EventArgs e)
        {
            lvAgenda.Items.Clear();
            cnn.Conectar();
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT A.idagenda, A.idlugar, A.diagnostico, A.equipo, A.fecha,A.descripcion, M.Nombre, ISNULL (C.NombreCompleto, 'N/A') as NombreCompleto from agenda A INNER JOIN municipios M on (A.idlugar = M.idMunicipio) INNER JOIN cliente C on (C.idCliente= A.idCliente) where A.fecha = '" + dtpBuscaragenda.Value.ToShortDateString() + "'", cnn.cn);
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
                lvAgenda.Items.Add(elementos);

            }
        }

        private void DtpVentas_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (DtpVentas.Value != null)
                {
                    string sql = "SELECT P.idPago, C.NombreCompleto, P.nombreArticulo, P.Precio, C.idCliente, PS.idCliente AS cliente, PS.idPago AS pago, C.telefono, C.direccion, P.cantidad, (P.cantidad* P.Precio) as total, PS.idPagos,P.fechaPago FROM Pagos PS INNER JOIN Cliente C ON (PS.idCliente = C.idCliente)INNER JOIN pago P ON (P.idPago = PS.idPago) where fechaPago='" + DtpVentas.Value.ToShortDateString() + "'";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, cnn.cn);
                    DataSet ds = new DataSet();
                    DataTable tabla = new DataTable();
                    adaptador.Fill(ds);
                    tabla = ds.Tables[0];
                    this.lvPagos.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elementos = new ListViewItem(filas["NombreCompleto"].ToString());
                        elementos.SubItems.Add(filas["nombreArticulo"].ToString());
                        elementos.SubItems.Add(filas["direccion"].ToString());
                        elementos.SubItems.Add(filas["telefono"].ToString());
                        elementos.SubItems.Add(filas["cantidad"].ToString());
                        elementos.SubItems.Add(filas["precio"].ToString());
                        elementos.SubItems.Add(filas["total"].ToString());
                        elementos.SubItems.Add(filas["idPago"].ToString());
                        elementos.SubItems.Add(filas["pago"].ToString());
                        elementos.SubItems.Add(filas["fechaPago"].ToString());
                        lvPagos.Items.Add(elementos);
                    }
                }
                else if (String.IsNullOrEmpty(textBox1.Text))
                {
                    metodos.buscarpago(lvPagos, dtpAgenda, textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fecha. :^)");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void lvClientes_DoubleClick(object sender, MouseEventArgs e)
        {
            FormActualizar fag = new FormActualizar();
            string idCl = this.lvClientes.SelectedItems[0].SubItems[0].Text;
            string sql = "SELECT C.idCliente, C.NombreCompleto, C.telefono, C.direccion, C.comentario, C.activo, C.equipo, C.idMunicipio, M.Nombre, C.FechaInstalacion, C.ClavePago, S.router, S.ip, S.comentario, S.IdCliente,S.idSegmentacion,M.idMunicipio FROM Cliente C INNER JOIN Segmentacion S ON(C.idCliente = S.IdCliente)INNER JOIN municipios M ON(C.idMunicipio = M.idMunicipio) where C.idCliente=" + idCl + "";            try
            {
                if (lvClientes.SelectedIndices.Count == 0)
                {
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fag.lbid.Text = dr[0].ToString();
                        fag.txtnombre.Text = dr[1].ToString();
                        fag.txtTelefono.Text = dr[2].ToString();
                        fag.txtdireccion.Text = dr[3].ToString();
                        fag.txtcomentario.Text = dr[4].ToString();
                        fag.cbActivo.Checked = dr.GetBoolean(5);
                        fag.cbEquipo.Checked = dr.GetBoolean(6);
                        fag.dtpInstalacion.Text = dr[9].ToString();
                        fag.txtcodigo.Text = dr[10].ToString();
                        fag.txtrouter.Text = dr[11].ToString();
                        fag.txtIp.Text = dr[12].ToString();
                        fag.txtCometarioip.Text = dr[13].ToString();
                        fag.lbSeg.Text = dr[15].ToString();
                        dr.Close();
                        DataSet dataset = new DataSet();
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                        {
                            da.Fill(dataset);
                        }

                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            fag.comboBox1.DataSource = dataset.Tables[0];
                            fag.comboBox1.DisplayMember = "Nombre";
                            fag.comboBox1.ValueMember = "idMunicipio";
                        }
                        fag.ShowDialog();
                    }
                }
            }
            catch (SqlException ss)
            {
                MessageBox.Show("Algo salio mal ;_; --" + ss.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal ;_; \n " + ex.Message, "MTtech ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Desconectar();
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            LlenarListView();
        }
        /// <summary>
        /// Esta funcion se carga los registros de cortes, además de que se 
        /// hace el calculo de las mensualidades que se van registrando durante el dia
        /// </summary>
        /// <param name="sender">objeto de evento</param>
        /// <param name="e">valor de evento</param>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                lvMen.Text = ":)";
                A = 0;
                metodos.llenarCortes(lvCortes, lvTotal);
                Int32 hora = DateTime.Now.Hour;
                foreach (ListViewItem I in lvCortes.Items)
                {
                    A += double.Parse(I.SubItems[6].Text);
                }
                if (A >= 4000 && hora <= 16)
                {
                    MessageBox.Show("Superaste el monto de 4,000, depositar lo mas pronto posible");
                }
                lvMen.Text = A.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex);
            }
        }
        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            llenarPagos();
        }
        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Conectar();
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago, DATEADD(m, 1, dbo.Mensualidad.fechaPago) AS corte, SUM(dbo.Cliente.ClavePago) as total FROM dbo.Cliente INNER JOIN dbo.Segmentacion ON dbo.Segmentacion.IdCliente = dbo.Cliente.idCliente INNER JOIN dbo.municipios ON dbo.municipios.idMunicipio = dbo.Cliente.idMunicipio INNER JOIN dbo.Mensualidades ON dbo.Mensualidades.idCliente = dbo.Cliente.idCliente INNER JOIN dbo.Mensualidad ON dbo.Mensualidades.idMensualidad = dbo.Mensualidad.idMensualidad WHERE dbo.Mensualidad.fechaPago like '%" + txtbuscarcorte.Text + "%' or dbo.Cliente.NombreCompleto Like '%" + txtbuscarcorte.Text + "%' group by dbo.Cliente.idCliente, dbo.Cliente.NombreCompleto, dbo.Segmentacion.IdCliente, dbo.Segmentacion.ip, dbo.Cliente.idMunicipio, dbo.municipios.idMunicipio, dbo.municipios.Nombre, dbo.Mensualidades.idMensualidadC, dbo.Mensualidades.idCliente, dbo.Mensualidades.idMensualidad, dbo.Mensualidad.idMensualidad, dbo.Mensualidad.monto, dbo.Mensualidad.idCliente, dbo.Mensualidad.anio, dbo.Mensualidad.fechaPago ", cnn.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                lvCortes.Items.Clear();
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
                    lvCortes.Items.Add(elementos);
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

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            FormIngresos ingresos = new FormIngresos();
            ingresos.ShowDialog();
        }
        private void Txtbuscarid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar11.PerformClick();
            }
        }
        FormPagoMensualidad pago = new FormPagoMensualidad();
        public void llenarComboCliente()
        {
            string idCl = this.lvClientes.SelectedItems[0].SubItems[0].Text;
            string id = this.lvClientes.SelectedItems[0].SubItems[11].Text;
            string sql = "Select M.idMunicipio, M.Nombre,C.IdMunicipio,C.IdCliente,C.NombreCompleto, C.ClavePago from Cliente C inner join municipios M on (C.IdMunicipio= M.Idmunicipio) where C.idCliente=" + idCl + " and M.idMunicipio="+ id +"";
            try
            {
                if (lvClientes.SelectedIndices.Count == 0)
                {
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cnn.conn);
                    cnn.Conectar();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        pago.lbidid.Text = dr[0].ToString();
                        pago.txtmonto.Text = dr[5].ToString();
                        dr.Close();                     
                        DataSet dataset = new DataSet();
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cnn.conn))
                        {
                            da.Fill(dataset);
                        }
                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            pago.cbCliente.DataSource = dataset.Tables[0];
                            pago.cbCliente.DisplayMember = "NombreCompleto";
                            pago.cbCliente.ValueMember = "idCliente";
                            pago.cmbLugar.DataSource = dataset.Tables[0];
                            pago.cmbLugar.DisplayMember = "Nombre";
                            pago.cmbLugar.ValueMember = "idMunicipio";
                        }
                        pago.ShowDialog();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Algo salio mal \n"+e);
            }
            }
        public bool test = false;

        private void MensualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llenarComboCliente();
            test = true;
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            cbLugarTorre.Refresh();
            cbEquipo.Refresh();
            txtdescripcion1.Clear();
            cbClienteAgenda.Refresh();
            txtDiag.Clear();
            btnActualizar.Visible = false;
            cbEquipo.DataSource = null;
            cbEquipo.Items.Clear();
            cargaEquipo();
            btncancelar.Visible = false;
            txtagenda.Visible = true;
            txtind.Clear();
        }

       
        private void CbLugarTorre_MouseClick(object sender, MouseEventArgs e)
        {
            cargaMuni();
        }
        private void CbLugarGlobla_MouseClick(object sender, MouseEventArgs e)
        {
            cargaMuni();
        }
        private void CbLugarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            cargaMuni();
        }

        private void Cbmunicipios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cnn.Conectar();
            this.lvClientes.Items.Clear();
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT S.IdCliente,C.NombreCompleto AS Nombre, C.telefono, C.direccion, S.router, S.ip, S.comentario, CASE C.activo WHEN 'True' THEN 'Si' ELSE 'No' END AS activo, C.FechaInstalacion, S.IdCliente, C.ClavePago, M.idMunicipio, M.Nombre as Localidad, C.idMunicipio, C.idCliente FROM dbo.Cliente AS C INNER JOIN dbo.Segmentacion AS S ON(C.idCliente = S.IdCliente) INNER JOIN dbo.municipios M ON C.idMunicipio = M.idMunicipio where M.idMunicipio = '" + cbmunicipios.SelectedValue + "' ORDER BY Nombre ASC ", cnn.cn);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["idCliente"].ToString());
                elementos.SubItems.Add(filas["Nombre"].ToString());
                elementos.SubItems.Add(filas["telefono"].ToString());
                elementos.SubItems.Add(filas["direccion"].ToString());
                elementos.SubItems.Add(filas["router"].ToString());
                elementos.SubItems.Add(filas["ip"].ToString());
                elementos.SubItems.Add(filas["comentario"].ToString());
                elementos.SubItems.Add(filas["activo"].ToString());
                elementos.SubItems.Add(filas["FechaInstalacion"].ToString());
                elementos.SubItems.Add(filas["ClavePago"].ToString());
                lvClientes.Items.Add(elementos);
            }
        }
        private void CbClienteAgenda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbLugarCliente.Items.Count == 0)
            {
                cargafiltro();
            }
            else
            {
                municipios.Clear();
                cbLugarCliente.DataSource = null;
                cbLugarCliente.Items.Clear();
                cargafiltro();
            }
        }

        private void CbClienteAgenda_Click(object sender, EventArgs e)
        {
            cargaCliente();
        }   

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Torre"))
            {
                grupoCliente.Visible = false;
                gbTorre.Visible = true;
                gbglobal.Visible = false;
                gbTorre.Location = new System.Drawing.Point(25, 106);

            }
            else if (comboBox1.Text.Equals("Cliente")|| comboBox1.Text.Equals("Instalacion"))
            {
                grupoCliente.Visible = true;
                gbTorre.Visible = false;
                gbglobal.Visible = false;
                grupoCliente.Location = new System.Drawing.Point(25, 106);
            }
            else if (comboBox1.Text.Equals("fichas") || comboBox1.Text.Equals("Otro") || comboBox1.Text.Equals("Socio"))
            {
                grupoCliente.Visible = false;
                gbTorre.Visible = false;
                gbglobal.Visible = true;
                gbglobal.Location = new System.Drawing.Point(25, 106);
            }
        }

        private void Cbrealizado_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error algo salio mal ;_;" + ex.Message);
            }
        }
    }
}