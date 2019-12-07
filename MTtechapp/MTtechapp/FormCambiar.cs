using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTtechapp
{
    public partial class FormCambiar : MaterialForm
    {
        String usuario;//var usuario a cambiar
        String contra;//var contrasena a cambiar
        private readonly MaterialSkinManager materialSkinManager;//instancia de msm
        //incializacion de componentes del formulario
        public FormCambiar(String usuario, String contra)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contra = contra;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        SqlDataReader lector;//lector de datos
        conexion conn = new conexion();// Conexion a base de datos
        /// <summary>
        /// en esta funcion se valida el usuario y la contraseña del usuario, si son correctas 
        /// </summary>
        
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
        //Actualiza los datos del usuario tales como la contraseña y el usuario
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
        //limpia campos
        private void limpiar()
        {
            txtnueva.Clear();
            txtantigua.Clear();
            this.Close();
        }
    }
}
