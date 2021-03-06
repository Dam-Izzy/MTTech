﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MTtechapp
{
    public partial class FormPagoMensualidad : MaterialForm
    {
        conexion cone =new conexion();
        public List<Cliente> lista_Clientes = new List<Cliente>();
        public List<Municipio> municipios = new List<Municipio>();
        private readonly MaterialSkinManager materialSkinManager;
        public FormPagoMensualidad()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

        }
        FormAgregar fm = new FormAgregar();
        public List<Cliente> CargaCombo()
        {
            try
            {
                cone.Conectar();
                SqlCommand cmd = new SqlCommand("select * from Cliente where idMunicipio="+ cmbLugar.SelectedValue +"", cone.conn);
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
            finally { cone.Desconectar(); }
            return lista_Clientes;
        }
        public List<Municipio> Cargamunicipio()
        {

            try
            {
                cone.Conectar();
                SqlCommand cmd = new SqlCommand("select * from municipios ", cone.conn);
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
            finally { cone.Desconectar(); }
            return municipios;
        }
        public void carga()
        {
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "idCliente";
            cbCliente.DataSource = CargaCombo();
        }
        public void cargaMes()
        {
            var items = new[] {
            new { Text = "Enero", Value = "pagado" },
            new { Text = "Febrero", Value = "pagado" },
            new { Text = "Marzo", Value = "pagado" },
            new { Text = "Abril", Value = "pagado" },
            new { Text = "Mayo", Value = "pagado" },
            new { Text = "Junio", Value = "pagado" },
            new { Text = "Julio", Value = "pagado" },
            new { Text = "Agosto", Value = "pagado" },
            new { Text = "Septiembre", Value = "pagado" },
            new { Text = "Octubre", Value = "pagado" },
            new { Text = "Noviembre", Value = "pagado" },
            new { Text = "Diciembre", Value = "pagado" },};
            cbMes.DisplayMember = "Text";
            cbMes.ValueMember = "Value";
            cbMes.DataSource = items;
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCliente.SelectedIndex.Equals(-1) || cbMes.SelectedIndex.Equals(-1) || cmbLugar.SelectedIndex.Equals(-1) || String.IsNullOrEmpty(txtmonto.Text))
                {
                    MessageBox.Show("No debes dejar campos vacios...","MTtech",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else
                {
                    if (cbMes.Text.Equals("Enero"))
                    {
                        guardarenero();
                    }
                    else if (cbMes.Text.Equals("Febrero"))
                    {
                        guardarfebrero();
                    }
                    else if (cbMes.Text.Equals("Marzo"))
                    {
                        guardarMarzo();
                    }
                    else if (cbMes.Text.Equals("Abril"))
                    {
                        guardarAbril();
                    }
                    else if (cbMes.Text.Equals("Mayo"))
                    {
                        guardarMayo();
                    }
                    else if (cbMes.Text.Equals("Junio"))
                    {
                        guardarJunio();
                    }
                    else if (cbMes.Text.Equals("Julio"))
                    {
                        guardarJulio();
                    }
                    else if (cbMes.Text.Equals("Agosto"))
                    {
                        guardarAgosto();
                    }
                    else if (cbMes.Text.Equals("Septiembre"))
                    {
                        guardarSeptiembre();
                    }
                    else if (cbMes.Text.Equals("Octubre"))
                    {
                        guardarOctubre();
                    }
                    else if (cbMes.Text.Equals("Noviembre"))
                    {
                        guardarNoviembre();
                    }
                    else if (cbMes.Text.Equals("Diciembre"))
                    {
                        guardarDiciembre();
                    }
                }
            }
            catch(SqlException sql)
            {
                MessageBox.Show("Algo salio mal ;_;" + sql.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal ;_;" + ex.Message);
            }
        }
        public void guardarenero()
        {
            cone.Conectar();
            try
            {
                if (cbMes.Text.Equals("Enero"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateEnero", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Enero", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue= DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        if (MessageBox.Show("¿Desea enviar un mensaje a " + cbCliente.Text+ " de acreditación de pago de mensualidad?", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            const string accountSid = "AC46161011010dec31c96b0d928901bb93";
                            const string authToken = "ae7f70c43e47d801b79d8d447bde32b3";
                            try
                            {
                                TwilioClient.Init(accountSid, authToken);
                                var message = MessageResource.Create(
                                body: "Pago de mensualidad correspondiente al mes de enero acreditado, cualquier duda o aclaración llame al 43 6 20 81",
                                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                                to: new Twilio.Types.PhoneNumber("whatsapp:+5212441046466")
                            );
                                Console.WriteLine(message.Sid);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex.Message);
                            }
                        }

                        }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
            }
        }
        public void guardarfebrero()
        {
            try
            {
                if (cbMes.Text.Equals("Febrero"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateFebrero", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Febrero", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch(SqlException ex){
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
            }
            limpiar();
        }
        public void guardarMarzo()
        {
            try
            {
                if (cbMes.Text.Equals("Marzo"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateMarzo", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Marzo", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j!= 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            limpiar();
        }
        public void guardarAbril()
        {
            try
            {
                if (cbMes.Text.Equals("Abril"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateAbril", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Abril", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j != 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarMayo()
        {
            try
            {
                if (cbMes.Text.Equals("Mayo"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateMayo", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Mayo", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString(); 
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarJunio()
        {
            try
            {
                if (cbMes.Text.Equals("Junio"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateJunio", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Junio", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarJulio()
        {
            try
            {
                if (cbMes.Text.Equals("Julio"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateJulio", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Julio", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarAgosto()
        {
            try
            {
                if (cbMes.Text.Equals("Agosto"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateAgosto", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Agosto", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.SmallDateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarSeptiembre()
        {
            try
            {
                if (cbMes.Text.Equals("Septiembre"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateSeptiembre", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Septiembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarOctubre()
        {
            try
            {
                if (cbMes.Text.Equals("Octubre"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateOctubre", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Octubre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        public void guardarNoviembre()
        {
            try
            {
                if (cbMes.Text.Equals("Noviembre"))
                {
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureUpdateNoviembre", cone.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Noviembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cone.Conectar();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int j;
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        int j;
        SqlCommand cmd;
        public void guardarDiciembre()
        {
            if (cbMes.Text.Equals("Diciembre"))
            {                
                cmd = new SqlCommand("dbo.spProcedureUpdateDiciembre", cone.conn);
                cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                cmd.Parameters.AddWithValue("@Diciembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();                    
                cone.Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
            }
                try
            {
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Guardado", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        cmd.Cancel();
                        MessageBox.Show("Error", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message," MTtech",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }
        private void limpiar()
        {
            cbCliente.SelectedItem = 1;
            cbMes.SelectedItem = 1;
            txtmonto.Clear();
        }
        public void cargamun()
        {
            cmbLugar.DisplayMember = "Nombre";
            cmbLugar.ValueMember = "idMunicipio";
            cmbLugar.DataSource = Cargamunicipio();
        }        
        public void LlenarMensualidades()
        {
            try
            {
                OleDbDataAdapter adaptador = new OleDbDataAdapter("Select * from getMensualidades('" + dtpbuscar.Value.ToShortDateString() + "')", cone.cn);
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adaptador.Fill(ds);
                tabla = ds.Tables[0];
                this.materialListView1.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["idMensualidadC"].ToString());
                    elementos.SubItems.Add(filas["NombreCompleto"].ToString());
                    elementos.SubItems.Add(filas["Nombre"].ToString());
                    elementos.SubItems.Add(filas["CL"].ToString());
                    elementos.SubItems.Add(filas["md"].ToString());
                    elementos.SubItems.Add(filas["mc"].ToString());
                    materialListView1.Items.Add(elementos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal " + ex);
            }
            finally
            {
               cone.Desconectar();
            }
        }
        ClassMetodos classMetodos = new ClassMetodos();
        private void FormPagoMensualidad_Load(object sender, EventArgs e)
        {
            LlenarMensualidades();
            cargaMes();
            classMetodos.autocompletarClienteMensualidad(cbCliente,
                                                         cmbLugar);
        }
        string mensualidad;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string idImprimir = this.materialListView1.SelectedItems[0].SubItems[5].Text;
                int idSeleccionado = int.Parse(idImprimir);
                FormDialogo imprimir = new FormDialogo(dtpbuscar.Value, idSeleccionado);
                imprimir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("el comporbante no pudo ser impreso por una razón misteriosa T.T \n " + ex);
            }
        }
        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            FormActualizarMensualidades fag = new FormActualizarMensualidades();
            string idCl = this.materialListView1.SelectedItems[0].SubItems[4].Text;
            string sql = "SELECT M.idCliente, M.Enero, M.Febrero, M.Marzo, M.Abril, M.Mayo, M.Junio, M.Julio, M.Agosto, M.Septiembre, M.Octubre, M.Noviembre, M.Diciembre, Mu.Nombre, C.FechaInstalacion, C.ClavePago, Mu.idMunicipio,C.NombreCompleto,C.idCliente, idMensualidad FROM Cliente C INNER JOIN municipios Mu ON(C.idMunicipio = Mu.idMunicipio) inner join Mensualidad M on(M.idCliente= C.idCliente)  where idMensualidad=" + idCl + "";
            try
            {
                if (materialListView1.SelectedIndices.Count == 0)
                {
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sql, cone.conn);
                    cone.Conectar();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        fag.lbid.Text = dr[0].ToString();
                        fag.lbEnero.Text = dr[1].ToString();
                        fag.lbFebrero.Text = dr[2].ToString();
                        fag.lbMarzo.Text = dr[3].ToString();
                        fag.lbAbril.Text = dr[4].ToString();
                        fag.lbmayo.Text = dr[5].ToString();
                        fag.lbjunio.Text = dr[6].ToString();
                        fag.lbJuilio.Text = dr[7].ToString();
                        fag.lbAgosto.Text = dr[8].ToString();
                        fag.lbSeptiembre.Text = dr[9].ToString();
                        fag.lbOctubre.Text = dr[10].ToString();
                        fag.lbNoviembre.Text = dr[11].ToString();
                        fag.lbDiciembre.Text = dr[12].ToString();
                        fag.dtpmensualidad.Text = dr.GetString(14);
                        fag.txtmonto.Text = dr[15].ToString();
                        dr.Close();
                        DataSet dataset = new DataSet();
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, cone.conn))
                        {
                            da.Fill(dataset);
                        }
                        if (dataset.Tables[0].Rows.Count > 0)
                        {
                            fag.cbCliente.DataSource = dataset.Tables[0];
                            fag.cbCliente.DisplayMember = "NombreCompleto";
                            fag.cbCliente.ValueMember = "idCliente";
                            fag.cmbLugar.DataSource = dataset.Tables[0];
                            fag.cmbLugar.DisplayMember = "Nombre";
                            fag.cmbLugar.ValueMember = "idMunicipio";
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
                cone.Desconectar();
            }
        }
        private void materialRaisedButton2_Click(object sender, EventArgs e){
            try
            {
                if (materialListView1.SelectedItems.Count ==0)
                {
                    MessageBox.Show("Error, debes seleccionar un elemento de la lista.");
                }
                else
                {
                    string idmensualidades = this.materialListView1.SelectedItems[0].SubItems[0].Text;
                    string idmensualidad = this.materialListView1.SelectedItems[0].SubItems[4].Text;
                    string idCliente = this.materialListView1.SelectedItems[0].SubItems[5].Text;
                    ClassMetodos metodos = new ClassMetodos();
                    metodos.BorrarMensualidad(int.Parse(idmensualidades), int.Parse(idmensualidad), int.Parse(idCliente));
                    MessageBox.Show(idmensualidad.ToString() + "<-idmensualidad" + idmensualidades.ToString() + "<-idMensualidades " + idCliente.ToString() + "->idCliente" );
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error, por una extraña razón no se pudo eliminar el registro T.T " + ex);
            }
            finally
            {
                LlenarMensualidades();
                limpiar();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LlenarMensualidades();
        }

        private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            classMetodos.autocompletarClienteMensualidad(cbCliente, cmbLugar);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cbCliente.Items != null)
                {
                    String query = "Select idCliente,ClavePago from Cliente where idCliente='" + cbCliente.SelectedValue + "'";
                    SqlCommand cmd = new SqlCommand(query, cone.conn);
                    SqlDataReader dr;
                    cone.Conectar();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtmonto.Enabled = false;
                        txtmonto.Text = dr[1].ToString();
                        mensualidad = dr[1].ToString();
                    }
                    dr.Close();
                }
            }
        }       
        private void cmbLugar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCliente.Items.Count == 0 || cbCliente.SelectedIndex.Equals(-1) || cbCliente.SelectedIndex.Equals(""))
            {
                cbCliente.DataSource = null;
                lista_Clientes.Clear();
                cbCliente.Items.Clear();
                carga();
            } 
            else
            {
                cbCliente.DataSource = null;
                lista_Clientes.Clear();
                cbCliente.Items.Clear();
                carga();
            }
        }

        private void lbsumar_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(txtmonto.Text);
                if (String.IsNullOrEmpty(txtdescuento.Text))
                {
                    MessageBox.Show("El valor no debe ser cero...");
                }
                else if (monto == 0)
                {
                    MessageBox.Show("El monto no puede ser menor a cero...");
                    txtmonto.Text = mensualidad;
                    lbRestar.Enabled = false;
                    lbsumar.Enabled = false;
                }
                else
                {
                    double desc = Convert.ToDouble(txtdescuento.Text);
                    monto = monto + desc;
                    txtmonto.Text = monto.ToString();
                }               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal " + ex);
            }
        }

        private void lbRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(txtmonto.Text);
                if (String.IsNullOrEmpty(txtdescuento.Text))
                {
                    MessageBox.Show("El valor no debe ser cero...");
                }
                else if (monto == 0)
                {
                    MessageBox.Show("El monto no puede ser menor a cero...");
                    txtmonto.Text = mensualidad;
                }
                else
                {
                    double desc = Convert.ToDouble(txtdescuento.Text);
                    monto = monto - desc;
                    txtmonto.Text = monto.ToString();
                    lbRestar.Enabled = false;
                    lbsumar.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo salio mal " + ex);
            }
        }

        private void CmbLugar_Enter(object sender, EventArgs e)
        {
            cargamun();
            ClassMetodos @class = new ClassMetodos();
            @class.autocompletarmunicipio(cmbLugar);
        }

        private void CbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCliente.Items != null)
            {
                String query = "Select idCliente,ClavePago from Cliente where idCliente='" + cbCliente.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, cone.conn);
                SqlDataReader dr;
                cone.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtmonto.Enabled = false;
                    txtmonto.Text = dr[1].ToString();
                    mensualidad = dr[1].ToString();
                }
                dr.Close();
            }
        }
    }
}
