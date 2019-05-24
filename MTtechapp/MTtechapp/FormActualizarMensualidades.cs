using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormActualizarMensualidades : MaterialForm
    {
        public FormActualizarMensualidades()
        {
            InitializeComponent();
        }
        conexion cnn = new conexion();
        private void btnEnero_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarEnero", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", lbid.Text);
                    cmd.Parameters.AddWithValue("@Enero", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnFebrero_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarFebrero", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Febrero", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnMarzo_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarMarzo", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Marzo", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnAbril_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarAbril", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Abril", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnMayo_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarMayo", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Mayo", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnJunio_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarJunio", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Junio", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnJulio_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarJulio", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Julio", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnAgosto_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarAgosto", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Agosto", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnSeptiembre_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarSeptiembre", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Septiembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnOctubre_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarOctubre", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Octubre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnNoviembre_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarNoviembre", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Noviembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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

        private void btnDiciembre_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea editar este registro? ", "MTtech", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnn.Conectar();
                    int i;
                    SqlCommand cmd = new SqlCommand("dbo.spProcedureActualizarDiciembre", cnn.conn);
                    cmd.Parameters.AddWithValue("@Monto", txtmonto.Text);
                    cmd.Parameters.AddWithValue("@idCliente", cbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diciembre", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.Parameters.AddWithValue("@anio", SqlDbType.DateTime).SqlValue = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@fechapago", SqlDbType.DateTime).SqlValue = dtpmensualidad.Value.ToShortDateString();
                    cmd.CommandType = CommandType.StoredProcedure;
                    i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                    if (i > 0)
                    {
                        MessageBox.Show("Pago editado correctamente!", "MTtech");
                    }
                    else
                    {
                        MessageBox.Show("El pago no fue editado por alguna razón misteriosa. ;_;");
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
    }
}
