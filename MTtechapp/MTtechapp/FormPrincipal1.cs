using MaterialSkin;
using MaterialSkin.Controls;
using MTtechapp.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormPrincipal1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public FormPrincipal1()
        {
            InitializeComponent();
            txtUsuario.Select();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        int count;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            materialProgressBar1.Visible = true;
            String usuario = txtUsuario.Text;
            String contra = txtcontra.Text;
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtcontra.Text))
                {
                    MessageBox.Show("No debes dejar campos vacios");
                    materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 0, 100);
                }
                else
                {
                    conexion cnn = new conexion();
                    cnn.Conectar();
                    SqlCommand cmd = new SqlCommand("Select * from Usuario where usuario=@username and password=@password and idRol=1", cnn.conn);
                    cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtcontra.Text);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    count = ds.Tables[0].Rows.Count;
                    FormMenuPrincipal fm = new FormMenuPrincipal(usuario,contra);

                    FormAgregar agregar = new FormAgregar();
                    if ((count == 1))
                    {
                            materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 30, 100);
                        if (txtUsuario.Text.Equals("Barbi") || txtUsuario.Text.Equals("admin"))
                        {                            
                            if (chkRecordar.Checked == true)
                            {
                                Settings.Default.recordar = true;
                                Settings.Default.recordar = chkRecordar.Checked;
                                Settings.Default.usuario = txtUsuario.Text;
                                Settings.Default.contrasena = txtcontra.Text;
                                
                                Settings.Default.Save();
                            }
                            else
                            {
                                Settings.Default.recordar = false;
                                Settings.Default.recordar = chkRecordar.Checked;                                
                                Settings.Default.usuario = "";
                                Settings.Default.contrasena = "";
                                Settings.Default.Save();
                            }
                             if (fm.materialCheckBox2.Checked==true)
                            {
                                Settings.Default.modo = true;
                                Settings.Default.modo = fm.materialCheckBox2.Checked;

                            }
                            else
                            {
                                Settings.Default.modo = false;
                                Settings.Default.modo = fm.materialCheckBox2.Checked;
                            }
                            if (materialProgressBar1.Value == 30)
                            {
                                materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 50, 100);

                            }
                             if (materialProgressBar1.Value == 50)
                            {
                                materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 92, 100);

                            }
                            fm.Show();
                            this.Hide();
                        }
                        else if (txtUsuario.Text.Equals("Sol"))
                        {
                            materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 100, 100);
                            fm.txtagregar.Enabled = false;
                            fm.DtpVentas.Enabled = false;
                            fm.materialTabControl1.TabPages.Remove(fm.tabPage3);
                            agregar.label1.Enabled = false;

                            this.Hide();
                            if (chkRecordar.Checked == true)
                            {
                                Settings.Default.recordar = true;
                                Settings.Default.recordar = chkRecordar.Checked;
                                Settings.Default.usuario = txtUsuario.Text;
                                Settings.Default.contrasena = txtcontra.Text;
                                Settings.Default.Save();
                            }
                            else
                            {
                                Settings.Default.recordar = false;
                                Settings.Default.recordar = chkRecordar.Checked;
                                Settings.Default.usuario = "";
                                Settings.Default.contrasena = "";
                                Settings.Default.Save();
                            }
                            MessageBox.Show("Hola, " + usuario.ToString(), "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fm.ShowDialog();
                        }
                    }
                    else
                    {
                        txtcontra.Clear();
                        MessageBox.Show("Datos erroneos");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex.Message);
            }
        }



        private void txtcontra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            String usuario = txtUsuario.Text;
            if (e.KeyChar==Convert.ToInt32(Keys.Enter))
            {
                btnIngresar_Click(sender,e);
            }
        }

        private void FormPrincipal1_Load(object sender, EventArgs e)
        {

                txtUsuario.Text = Settings.Default.usuario;
                txtcontra.Text = Settings.Default.contrasena;
                chkRecordar.Checked = Settings.Default.recordar;
            timer.Interval = 1000;
        }

        private void chkRecordar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecordar.Checked == true)
            {
                Settings.Default.recordar = true;
                Settings.Default.recordar = chkRecordar.Checked;
                Settings.Default.usuario = txtUsuario.Text;
                Settings.Default.contrasena = txtcontra.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.recordar = false;
                Settings.Default.recordar = chkRecordar.Checked;
                Settings.Default.usuario = "";
                Settings.Default.contrasena = "";
                Settings.Default.Save();
            }
        }

        private void materialLabel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            timer.Start();
            txtcontra.PasswordChar = (materialLabel1.Visible ? '\0' : '*');
        }

        private void materialLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Stop();
            txtcontra.PasswordChar = (materialLabel1.Visible ? '*' : '\0');
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
    }
}