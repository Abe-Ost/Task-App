using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Interfaz : Form
    {
        //cadena de conexion
        private readonly string connectionString = "server=ABEPC\\SQLEXPRESS;Initial Catalog=TareasDB;Integrated Security=True;TrustServerCertificate=True";
        public Interfaz()
        {
            InitializeComponent();
        }
        public void Leer()
        {
            //conexion a BD
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //abrir la conexion
                conn.Open();
                //definir el query 
                string query = "SELECT t.ID, t.titulo, t.descripcion, e.nombreEstado FROM Tareas t JOIN Estados e ON t.estadoId = e.id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        LlenarDataGrid(dt);
                    }
                }
            }
        }
        private void LlenarDataGrid(DataTable dt)
        {
            dgvTareas.DataSource = dt;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            Leer(); 
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            this.Close();
            Agregar form = new Agregar();
            form.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Borrar();
            }
        }
        private void Borrar()
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro de continuar y eliminar esa tarea?", "Confirmación",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                if (this.dgvTareas.CurrentRow != null)
                {
                    int id = Convert.ToInt32(this.dgvTareas.CurrentRow.Cells["ID"].Value); 
                    if (EliminarDeBaseDeDatos(id))
                    {
                        this.dgvTareas.Rows.RemoveAt(this.dgvTareas.CurrentRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la tarea de la base de datos.");
                    }
                }
                MessageBox.Show("Tarea eliminada");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }
        private bool EliminarDeBaseDeDatos(int id)
        {
            string connectionString = "server=ABEPC\\SQLEXPRESS;Initial Catalog=TareasDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "DELETE FROM Tareas WHERE ID = @ID"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        int result = command.ExecuteNonQuery();
                        return result > 0; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la tarea: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
