using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration; //referencia que permite conectar a la base de datos desde App.config
using System.Data.SqlClient; //referencia que permite conectar a la base de datos

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        //private void para retornar conexion SQL
        private SqlConnection ConnectionToSQL() //metodo que conecta la base de datos haciendo uso de App.config
        {
            try //se agrega un capturador de errores por si la conexion falla
            {
                var conString = ConfigurationManager.ConnectionStrings["TareasDB"].ConnectionString;
                SqlConnection Conector = new SqlConnection(conString);
                return Conector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "username";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.ForeColor= Color.Black;
            if (txtUser.Text == "username")
            {
                txtUser.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "password";
            txtUser.Text = "username";
            btnIngresar.TabIndex = 0;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //atrapo los textos de los 2 textbox
            string usuario = txtUser.Text;
            string contrasena = txtPassword.Text;
            // Consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM Usuarios WHERE nombreUsuario = @usuario AND contrasena = @contrasena";
            //using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlConnection con = ConnectionToSQL();
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Agregar parámetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        // Ejecutar la consulta y obtener el resultado
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Ingreso exitoso!", "Hola!", MessageBoxButtons.OK);
                            this.Hide();
                            Interfaz inter = new Interfaz();
                            inter.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado", "No existe ese usuario y/o contrasena", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar credenciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LeerUsuario(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "username";
            }
            else 
            {
                textBox.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
