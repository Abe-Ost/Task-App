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
        public Interfaz()
            {
                InitializeComponent();
            }
        public void Leer()
        {
            //conexion a BD
            using (SqlConnection conn = ConnectionToSQL())
            {
                //abrir la conexion
                conn.Open();
                //definir el query 
                string query = "SELECT t.id, t.titulo, t.descripcion, c.nombre AS CategoriaTarea, e.nombreEstado FROM Tareas t JOIN Estados e ON t.estadoId = e.id JOIN Categorias c ON t.categoriaId = c.id";
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
                //esconde las opciones de editar
                lblIngresa.Hide();
                lblNuevoTituloTarea.Hide();
                txtNuevoNombreTarea.Hide();
                lblNuevaDescripcionTarea.Hide();
                txtNuevaDescripcionTarea.Hide();
                lblNuevaCategoria.Hide();
                cmbCategoriaTarea.Hide();
                lblNuevoEstado.Hide();
                cmbEstadoTarea.Hide();
                btnNuevoCancelar.Hide();
                btnEditarTarea.Hide();
            }

            private void btnAgregarTarea_Click(object sender, EventArgs e)
            {
                this.Close();
                Agregar form = new Agregar();
                form.Show();
            }

             private void btnBorrar_Click(object sender, EventArgs e)
            {
                Borrar();
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
                string query = "DELETE FROM Tareas WHERE ID = @ID"; 

                using (SqlConnection connection = ConnectionToSQL())
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                lblIngresa.Show();
                lblNuevoTituloTarea.Show();
                txtNuevoNombreTarea.Show();
                lblNuevaDescripcionTarea.Show();
                txtNuevaDescripcionTarea.Show();
                lblNuevaCategoria.Show();
                cmbCategoriaTarea.Show();
                lblNuevoEstado.Show();
                cmbEstadoTarea.Show();
                btnNuevoCancelar.Show();
                btnEditarTarea.Show();

                DataGridViewRow filaSeleccionada = dgvTareas.SelectedRows[0];
                txtNuevoNombreTarea.Text = filaSeleccionada.Cells["titulo"].Value.ToString();
                txtNuevaDescripcionTarea.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
                cmbCategoriaTarea.Text = filaSeleccionada.Cells["CategoriaTarea"].Value.ToString();
                // habilita esto cuando hayamos agregado la columna de categorias, recuerda cambiar el nombre por el de la columna
                cmbEstadoTarea.SelectedItem = filaSeleccionada.Cells["nombreEstado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void lnklblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult opcionPresionada = MessageBox.Show("¿Estás seguro de cerrar sesión?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcionPresionada == DialogResult.OK)
                {
                    // Código a ejecutar si el usuario presionó "OK"
                    MessageBox.Show("Sesión cerrada correctamente.");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoCancelar_Click(object sender, EventArgs e)
        {
            Leer();
            //esconde las opciones de editar
            lblIngresa.Hide();
            lblNuevoTituloTarea.Hide();
            txtNuevoNombreTarea.Hide();
            lblNuevaDescripcionTarea.Hide();
            txtNuevaDescripcionTarea.Hide();
            lblNuevaCategoria.Hide();
            cmbCategoriaTarea.Hide();
            lblNuevoEstado.Hide();
            cmbEstadoTarea.Hide();
            btnNuevoCancelar.Hide();
            btnEditarTarea.Hide();
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvTareas.SelectedRows[0];
                int idTarea = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                string nuevoNombre = txtNuevoNombreTarea.Text;
                string nuevaDescripcion = txtNuevaDescripcionTarea.Text;
                string nuevaCategoriaNombre = cmbCategoriaTarea.Text;
                string nuevoEstadoNombre = cmbEstadoTarea.Text; // Obtener el nombre del estado

                try
                {
                    using (SqlConnection conexion = ConnectionToSQL())
                    {
                        conexion.Open();

                        // Obtener el ID de la categoría
                        int nuevaCategoriaId;
                        string consultaCategoria = "SELECT id FROM Categorias WHERE nombre = @NombreCategoria";
                        using (SqlCommand comandoCategoria = new SqlCommand(consultaCategoria, conexion))
                        {
                            comandoCategoria.Parameters.AddWithValue("@NombreCategoria", nuevaCategoriaNombre);
                            object resultadoCategoria = comandoCategoria.ExecuteScalar();
                            if (resultadoCategoria != null)
                            {
                                nuevaCategoriaId = Convert.ToInt32(resultadoCategoria);
                            }
                            else
                            {
                                MessageBox.Show("La categoría ingresada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Obtener el ID del estado
                        int nuevoEstadoId;
                        string consultaEstado = "SELECT id FROM Estados WHERE nombreEstado = @NombreEstado";
                        using (SqlCommand comandoEstado = new SqlCommand(consultaEstado, conexion))
                        {
                            comandoEstado.Parameters.AddWithValue("@NombreEstado", nuevoEstadoNombre);
                            object resultadoEstado = comandoEstado.ExecuteScalar();
                            if (resultadoEstado != null)
                            {
                                nuevoEstadoId = Convert.ToInt32(resultadoEstado);
                            }
                            else
                            {
                                MessageBox.Show("El estado ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Verificar si la categoría existe
                        string consultaVerificacionCategoria = "SELECT COUNT(*) FROM Categorias WHERE id = @CategoriaId";
                        using (SqlCommand comandoVerificacionCategoria = new SqlCommand(consultaVerificacionCategoria, conexion))
                        {
                            comandoVerificacionCategoria.Parameters.AddWithValue("@CategoriaId", nuevaCategoriaId);
                            int countCategoria = (int)comandoVerificacionCategoria.ExecuteScalar();
                            if (countCategoria == 0)
                            {
                                MessageBox.Show("La categoría seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Verificar si el estado existe
                        string consultaVerificacionEstado = "SELECT COUNT(*) FROM Estados WHERE id = @EstadoId";
                        using (SqlCommand comandoVerificacionEstado = new SqlCommand(consultaVerificacionEstado, conexion))
                        {
                            comandoVerificacionEstado.Parameters.AddWithValue("@EstadoId", nuevoEstadoId);
                            int countEstado = (int)comandoVerificacionEstado.ExecuteScalar();
                            if (countEstado == 0)
                            {
                                MessageBox.Show("El estado seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Actualizar la tarea
                        string consulta = "UPDATE Tareas SET titulo = @Nombre, descripcion = @Descripcion, categoriaId = @Categoria, estadoId = @Estado WHERE Id = @Id";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Nombre", nuevoNombre);
                            comando.Parameters.AddWithValue("@Descripcion", nuevaDescripcion);
                            comando.Parameters.AddWithValue("@Categoria", nuevaCategoriaId);
                            comando.Parameters.AddWithValue("@Estado", nuevoEstadoId);
                            comando.Parameters.AddWithValue("@Id", idTarea);
                            comando.ExecuteNonQuery();
                        }
                        Leer();
                        lblIngresa.Hide();
                        lblNuevoTituloTarea.Hide();
                        txtNuevoNombreTarea.Hide();
                        lblNuevaDescripcionTarea.Hide();
                        txtNuevaDescripcionTarea.Hide();
                        lblNuevaCategoria.Hide();
                        cmbCategoriaTarea.Hide();
                        lblNuevoEstado.Hide();
                        cmbEstadoTarea.Hide();
                        btnNuevoCancelar.Hide();
                        btnEditarTarea.Hide();

                        MessageBox.Show("Tarea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
