namespace WindowsFormsApp1
{
    partial class Interfaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnklblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.cmbEstadoTarea = new System.Windows.Forms.ComboBox();
            this.lblNuevoEstado = new System.Windows.Forms.Label();
            this.btnNuevoCancelar = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.lblNuevaDescripcionTarea = new System.Windows.Forms.Label();
            this.lblNuevoTituloTarea = new System.Windows.Forms.Label();
            this.cmbCategoriaTarea = new System.Windows.Forms.ComboBox();
            this.txtNuevaDescripcionTarea = new System.Windows.Forms.TextBox();
            this.txtNuevoNombreTarea = new System.Windows.Forms.TextBox();
            this.lblIngresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(438, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoteCat List";
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(33, 144);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(1225, 444);
            this.dgvTareas.TabIndex = 4;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarTarea.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarTarea.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarTarea.Location = new System.Drawing.Point(332, 606);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(182, 56);
            this.btnAgregarTarea.TabIndex = 8;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Yellow;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(562, 610);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 52);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(779, 610);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 52);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1162, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // lnklblCerrarSesion
            // 
            this.lnklblCerrarSesion.AutoSize = true;
            this.lnklblCerrarSesion.Location = new System.Drawing.Point(1158, 100);
            this.lnklblCerrarSesion.Name = "lnklblCerrarSesion";
            this.lnklblCerrarSesion.Size = new System.Drawing.Size(100, 20);
            this.lnklblCerrarSesion.TabIndex = 30;
            this.lnklblCerrarSesion.TabStop = true;
            this.lnklblCerrarSesion.Text = "cerrar sesion";
            this.lnklblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCerrarSesion_LinkClicked);
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.FormattingEnabled = true;
            this.cmbEstadoTarea.Items.AddRange(new object[] {
            "selecciona..",
            "completado",
            "pendiente",
            "cancelado"});
            this.cmbEstadoTarea.Location = new System.Drawing.Point(952, 787);
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(238, 28);
            this.cmbEstadoTarea.TabIndex = 44;
            // 
            // lblNuevoEstado
            // 
            this.lblNuevoEstado.AutoSize = true;
            this.lblNuevoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEstado.Location = new System.Drawing.Point(774, 786);
            this.lblNuevoEstado.Name = "lblNuevoEstado";
            this.lblNuevoEstado.Size = new System.Drawing.Size(133, 25);
            this.lblNuevoEstado.TabIndex = 43;
            this.lblNuevoEstado.Text = "Nuevo estado";
            // 
            // btnNuevoCancelar
            // 
            this.btnNuevoCancelar.BackColor = System.Drawing.Color.Ivory;
            this.btnNuevoCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnNuevoCancelar.FlatAppearance.BorderSize = 0;
            this.btnNuevoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCancelar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoCancelar.Location = new System.Drawing.Point(429, 914);
            this.btnNuevoCancelar.Name = "btnNuevoCancelar";
            this.btnNuevoCancelar.Size = new System.Drawing.Size(182, 52);
            this.btnNuevoCancelar.TabIndex = 42;
            this.btnNuevoCancelar.Text = "Cancelar";
            this.btnNuevoCancelar.UseVisualStyleBackColor = false;
            this.btnNuevoCancelar.Click += new System.EventHandler(this.btnNuevoCancelar_Click);
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.BackColor = System.Drawing.Color.Chartreuse;
            this.btnEditarTarea.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnEditarTarea.FlatAppearance.BorderSize = 0;
            this.btnEditarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarTarea.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarTarea.Location = new System.Drawing.Point(668, 914);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(182, 52);
            this.btnEditarTarea.TabIndex = 41;
            this.btnEditarTarea.Text = "Editar";
            this.btnEditarTarea.UseVisualStyleBackColor = false;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCategoria.Location = new System.Drawing.Point(774, 738);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(154, 25);
            this.lblNuevaCategoria.TabIndex = 40;
            this.lblNuevaCategoria.Text = "Nueva categoria";
            // 
            // lblNuevaDescripcionTarea
            // 
            this.lblNuevaDescripcionTarea.AutoSize = true;
            this.lblNuevaDescripcionTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaDescripcionTarea.Location = new System.Drawing.Point(12, 782);
            this.lblNuevaDescripcionTarea.Name = "lblNuevaDescripcionTarea";
            this.lblNuevaDescripcionTarea.Size = new System.Drawing.Size(269, 25);
            this.lblNuevaDescripcionTarea.TabIndex = 39;
            this.lblNuevaDescripcionTarea.Text = "Nueva descripcion de la tarea";
            // 
            // lblNuevoTituloTarea
            // 
            this.lblNuevoTituloTarea.AutoSize = true;
            this.lblNuevoTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoTituloTarea.Location = new System.Drawing.Point(12, 738);
            this.lblNuevoTituloTarea.Name = "lblNuevoTituloTarea";
            this.lblNuevoTituloTarea.Size = new System.Drawing.Size(210, 25);
            this.lblNuevoTituloTarea.TabIndex = 38;
            this.lblNuevoTituloTarea.Text = "Nuevo titulo de la tarea";
            // 
            // cmbCategoriaTarea
            // 
            this.cmbCategoriaTarea.FormattingEnabled = true;
            this.cmbCategoriaTarea.Items.AddRange(new object[] {
            "Selecciona...",
            "Programación",
            "Bases de Datos",
            "Desarrollo Web",
            "Ingeniería de Software",
            "Redes y Seguridad",
            "Sistemas Operativos",
            "Inteligencia Artificial",
            "Arquitectura de Software",
            "DevOps",
            "Computación en la Nube"});
            this.cmbCategoriaTarea.Location = new System.Drawing.Point(952, 738);
            this.cmbCategoriaTarea.Name = "cmbCategoriaTarea";
            this.cmbCategoriaTarea.Size = new System.Drawing.Size(238, 28);
            this.cmbCategoriaTarea.TabIndex = 37;
            // 
            // txtNuevaDescripcionTarea
            // 
            this.txtNuevaDescripcionTarea.Location = new System.Drawing.Point(332, 783);
            this.txtNuevaDescripcionTarea.Multiline = true;
            this.txtNuevaDescripcionTarea.Name = "txtNuevaDescripcionTarea";
            this.txtNuevaDescripcionTarea.Size = new System.Drawing.Size(416, 108);
            this.txtNuevaDescripcionTarea.TabIndex = 36;
            this.txtNuevaDescripcionTarea.Text = "\r\n\r\n";
            // 
            // txtNuevoNombreTarea
            // 
            this.txtNuevoNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombreTarea.Location = new System.Drawing.Point(332, 738);
            this.txtNuevoNombreTarea.Name = "txtNuevoNombreTarea";
            this.txtNuevoNombreTarea.Size = new System.Drawing.Size(416, 30);
            this.txtNuevoNombreTarea.TabIndex = 35;
            // 
            // lblIngresa
            // 
            this.lblIngresa.AutoSize = true;
            this.lblIngresa.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresa.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblIngresa.Location = new System.Drawing.Point(43, 672);
            this.lblIngresa.Name = "lblIngresa";
            this.lblIngresa.Size = new System.Drawing.Size(180, 51);
            this.lblIngresa.TabIndex = 45;
            this.lblIngresa.Text = "Ingresa...";
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 992);
            this.Controls.Add(this.lblIngresa);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.lblNuevoEstado);
            this.Controls.Add(this.btnNuevoCancelar);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.lblNuevaDescripcionTarea);
            this.Controls.Add(this.lblNuevoTituloTarea);
            this.Controls.Add(this.cmbCategoriaTarea);
            this.Controls.Add(this.txtNuevaDescripcionTarea);
            this.Controls.Add(this.txtNuevoNombreTarea);
            this.Controls.Add(this.lnklblCerrarSesion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.LinkLabel linklblCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnklblCerrarSesion;
        private System.Windows.Forms.ComboBox cmbEstadoTarea;
        private System.Windows.Forms.Label lblNuevoEstado;
        private System.Windows.Forms.Button btnNuevoCancelar;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.Label lblNuevaDescripcionTarea;
        private System.Windows.Forms.Label lblNuevoTituloTarea;
        private System.Windows.Forms.ComboBox cmbCategoriaTarea;
        private System.Windows.Forms.TextBox txtNuevaDescripcionTarea;
        private System.Windows.Forms.TextBox txtNuevoNombreTarea;
        private System.Windows.Forms.Label lblIngresa;
    }
}