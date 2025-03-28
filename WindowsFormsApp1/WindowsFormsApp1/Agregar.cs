﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Agregar : Form
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
        public Agregar()
        {
            InitializeComponent();
        }
        private void AgregarTarea()
        {
            // 1. Obtener los valores de los controles
            string titulo = txtNombreTarea.Text.Trim();
            string descripcion = txtDescripcionTarea.Text.Trim();
            int categoriaId = cmbCategoriaTarea.SelectedIndex;
            int estadoId = cmbEstadoTarea.SelectedIndex;

            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ConnectionString a la base de datos
            //string connectionString = "server=ABEPC\\SQLEXPRESS;Initial Catalog=TareasDB;Integrated Security=True;TrustServerCertificate=True";

            // 2. Crear la consulta SQL con parámetros
            string query = "INSERT INTO Tareas (titulo, descripcion, categoriaId, estadoId) " +
                           "VALUES (@titulo, @descripcion, @categoriaId, @estadoId)";

            using (SqlConnection con = ConnectionToSQL())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 3. Agregar los parámetros
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
                        cmd.Parameters.AddWithValue("@estadoId", estadoId);

                        // 4. Ejecutar la consulta
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos(); // Método para limpiar los controles
                            this.Close();
                            Interfaz inter = new Interfaz();
                            inter.Show();    
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No has seleccionado y/o ingresado todos los campos requeridos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para limpiar los controles después de agregar una tarea
        private void LimpiarCampos()
        {
            txtNombreTarea.Clear();
            txtDescripcionTarea.Clear();
            cmbCategoriaTarea.SelectedIndex = -1;
            cmbEstadoTarea.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz inter = new Interfaz();
            inter.Show();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            cmbCategoriaTarea.SelectedIndex = 0;
            cmbEstadoTarea.SelectedIndex = 0;
        }
    }
}
