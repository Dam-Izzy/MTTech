using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormCambiar : MaterialForm
    {
        String usuario;
        String contra;
        private readonly MaterialSkinManager materialSkinManager;
        public FormCambiar(String usuario, String contra)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contra = contra;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        SqlDataReader lector;
        conexion conn = new conexion();
        private void btncambiar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenu = new FormMenuPrincipal();
            try
            {

                if (String.IsNullOrEmpty(txtnueva.Text) || String.IsNullOrEmpty(txtantigua.Text))
                {
                    MessageBox.Show("Completa los campos");
                }
                else
                {
                    SqlCommand consulta = new SqlCommand("SELECT usuario, password from Usuario where usuario= '"+ usuario +"'",conn.conn);
                    if (txtantigua.Text!=null)
                    {
                        conn.Conectar();
                        lector = consulta.ExecuteReader();
                        while (lector.Read())
                        {
                            if (lector[1].ToString()==txtantigua.Text)
                            {
                                Actualizar();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña no coincide...");
                            }
                        }
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
            }
        }

        private void Actualizar()
        {
            lector.Close();
            SqlCommand cmd1 = new SqlCommand("update Usuario set password= '" + txtnueva.Text + "' where usuario='" + usuario + "'", conn.conn);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            lector = null;
            MessageBox.Show("Datos guardados correctamente", "MTtech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }
        private void limpiar()
        {
            txtnueva.Clear();
            txtantigua.Clear();
            this.Close();
        }
    }
}
