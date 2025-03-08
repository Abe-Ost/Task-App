namespace WindowsFormsApp1
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcionTarea = new System.Windows.Forms.Label();
            this.lblTituloTarea = new System.Windows.Forms.Label();
            this.cmbCategoriaTarea = new System.Windows.Forms.ComboBox();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstadoTarea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(155, 306);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(97, 25);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDescripcionTarea
            // 
            this.lblDescripcionTarea.AutoSize = true;
            this.lblDescripcionTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTarea.Location = new System.Drawing.Point(42, 183);
            this.lblDescripcionTarea.Name = "lblDescripcionTarea";
            this.lblDescripcionTarea.Size = new System.Drawing.Size(210, 25);
            this.lblDescripcionTarea.TabIndex = 17;
            this.lblDescripcionTarea.Text = "Descripcion de la tarea";
            // 
            // lblTituloTarea
            // 
            this.lblTituloTarea.AutoSize = true;
            this.lblTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTarea.Location = new System.Drawing.Point(96, 146);
            this.lblTituloTarea.Name = "lblTituloTarea";
            this.lblTituloTarea.Size = new System.Drawing.Size(156, 25);
            this.lblTituloTarea.TabIndex = 16;
            this.lblTituloTarea.Text = "Titulo de la tarea";
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
            this.cmbCategoriaTarea.Location = new System.Drawing.Point(280, 307);
            this.cmbCategoriaTarea.Name = "cmbCategoriaTarea";
            this.cmbCategoriaTarea.Size = new System.Drawing.Size(301, 28);
            this.cmbCategoriaTarea.TabIndex = 15;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Location = new System.Drawing.Point(280, 184);
            this.txtDescripcionTarea.Multiline = true;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(574, 108);
            this.txtDescripcionTarea.TabIndex = 14;
            this.txtDescripcionTarea.Text = "\r\n\r\n";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTarea.Location = new System.Drawing.Point(280, 143);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(416, 30);
            this.txtNombreTarea.TabIndex = 13;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLogin.Location = new System.Drawing.Point(369, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(252, 55);
            this.lblLogin.TabIndex = 19;
            this.lblLogin.Text = "Crear tarea";
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarTarea.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarTarea.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarTarea.Location = new System.Drawing.Point(514, 435);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(182, 52);
            this.btnAgregarTarea.TabIndex = 20;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Ivory;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(280, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 52);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(155, 357);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 25);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.FormattingEnabled = true;
            this.cmbEstadoTarea.Items.AddRange(new object[] {
            "selecciona..",
            "completado",
            "pendiente",
            "cancelado"});
            this.cmbEstadoTarea.Location = new System.Drawing.Point(280, 357);
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(182, 28);
            this.cmbEstadoTarea.TabIndex = 23;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(967, 557);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcionTarea);
            this.Controls.Add(this.lblTituloTarea);
            this.Controls.Add(this.cmbCategoriaTarea);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.txtNombreTarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcionTarea;
        private System.Windows.Forms.Label lblTituloTarea;
        private System.Windows.Forms.ComboBox cmbCategoriaTarea;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstadoTarea;
    }
}