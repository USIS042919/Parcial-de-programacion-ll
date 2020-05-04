namespace Parcial_de_programacion_ll
{
    partial class alquiler
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
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbDatosAlquiler = new System.Windows.Forms.GroupBox();
            this.btnBuscarCategoriaPelicula = new System.Windows.Forms.Button();
            this.cboCategoriaPeliculas = new System.Windows.Forms.ComboBox();
            this.lblCategoriaPelicula = new System.Windows.Forms.Label();
            this.btnBuscarCategoriaCliente = new System.Windows.Forms.Button();
            this.cboCategoriaClientes = new System.Windows.Forms.ComboBox();
            this.txtdevolucion = new System.Windows.Forms.TextBox();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.lblprestamo = new System.Windows.Forms.Label();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.lblidAlquiler = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatosAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(322, 434);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(309, 94);
            this.grbEdicion.TabIndex = 14;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Alquiler";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(245, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 64);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(172, 16);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(71, 64);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(87, 16);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 64);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(2, 16);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 64);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Location = new System.Drawing.Point(74, 434);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(222, 94);
            this.grbNavegacion.TabIndex = 13;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.BackColor = System.Drawing.Color.LightSalmon;
            this.lblnregistros.Location = new System.Drawing.Point(83, 26);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnultimo.Location = new System.Drawing.Point(182, 16);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 53);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnsiguiente.Location = new System.Drawing.Point(143, 16);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 53);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.LightSalmon;
            this.btnanterior.Location = new System.Drawing.Point(41, 16);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 53);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.LightSalmon;
            this.btnprimero.Location = new System.Drawing.Point(2, 16);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 53);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbDatosAlquiler
            // 
            this.grbDatosAlquiler.Controls.Add(this.btnBuscarCategoriaPelicula);
            this.grbDatosAlquiler.Controls.Add(this.cboCategoriaPeliculas);
            this.grbDatosAlquiler.Controls.Add(this.lblCategoriaPelicula);
            this.grbDatosAlquiler.Controls.Add(this.btnBuscarCategoriaCliente);
            this.grbDatosAlquiler.Controls.Add(this.cboCategoriaClientes);
            this.grbDatosAlquiler.Controls.Add(this.txtdevolucion);
            this.grbDatosAlquiler.Controls.Add(this.lbldevolucion);
            this.grbDatosAlquiler.Controls.Add(this.txtvalor);
            this.grbDatosAlquiler.Controls.Add(this.lblvalor);
            this.grbDatosAlquiler.Controls.Add(this.txtprestamo);
            this.grbDatosAlquiler.Controls.Add(this.lblprestamo);
            this.grbDatosAlquiler.Controls.Add(this.lblCategoriaCliente);
            this.grbDatosAlquiler.Controls.Add(this.lblidAlquiler);
            this.grbDatosAlquiler.Controls.Add(this.textBox6);
            this.grbDatosAlquiler.Controls.Add(this.label6);
            this.grbDatosAlquiler.Enabled = false;
            this.grbDatosAlquiler.Location = new System.Drawing.Point(72, 10);
            this.grbDatosAlquiler.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosAlquiler.Name = "grbDatosAlquiler";
            this.grbDatosAlquiler.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosAlquiler.Size = new System.Drawing.Size(559, 412);
            this.grbDatosAlquiler.TabIndex = 12;
            this.grbDatosAlquiler.TabStop = false;
            this.grbDatosAlquiler.Text = "Datos de tablas";
            // 
            // btnBuscarCategoriaPelicula
            // 
            this.btnBuscarCategoriaPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscarCategoriaPelicula.Location = new System.Drawing.Point(345, 143);
            this.btnBuscarCategoriaPelicula.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarCategoriaPelicula.Name = "btnBuscarCategoriaPelicula";
            this.btnBuscarCategoriaPelicula.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarCategoriaPelicula.TabIndex = 29;
            this.btnBuscarCategoriaPelicula.Text = "Buscar Categorias";
            this.btnBuscarCategoriaPelicula.UseVisualStyleBackColor = false;
            this.btnBuscarCategoriaPelicula.Click += new System.EventHandler(this.btnBuscarCategoriaPelicula_Click);
            // 
            // cboCategoriaPeliculas
            // 
            this.cboCategoriaPeliculas.FormattingEnabled = true;
            this.cboCategoriaPeliculas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCategoriaPeliculas.Location = new System.Drawing.Point(177, 143);
            this.cboCategoriaPeliculas.Name = "cboCategoriaPeliculas";
            this.cboCategoriaPeliculas.Size = new System.Drawing.Size(146, 21);
            this.cboCategoriaPeliculas.TabIndex = 28;
            // 
            // lblCategoriaPelicula
            // 
            this.lblCategoriaPelicula.AutoSize = true;
            this.lblCategoriaPelicula.Location = new System.Drawing.Point(22, 146);
            this.lblCategoriaPelicula.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoriaPelicula.Name = "lblCategoriaPelicula";
            this.lblCategoriaPelicula.Size = new System.Drawing.Size(151, 13);
            this.lblCategoriaPelicula.TabIndex = 27;
            this.lblCategoriaPelicula.Text = "CATEGORIA DE PELICULAS:";
            // 
            // btnBuscarCategoriaCliente
            // 
            this.btnBuscarCategoriaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscarCategoriaCliente.Location = new System.Drawing.Point(345, 97);
            this.btnBuscarCategoriaCliente.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarCategoriaCliente.Name = "btnBuscarCategoriaCliente";
            this.btnBuscarCategoriaCliente.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarCategoriaCliente.TabIndex = 26;
            this.btnBuscarCategoriaCliente.Text = "Buscar Categorias";
            this.btnBuscarCategoriaCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCategoriaCliente.Click += new System.EventHandler(this.btnBuscarCategoriaCliente_Click);
            // 
            // cboCategoriaClientes
            // 
            this.cboCategoriaClientes.FormattingEnabled = true;
            this.cboCategoriaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCategoriaClientes.Location = new System.Drawing.Point(177, 101);
            this.cboCategoriaClientes.Name = "cboCategoriaClientes";
            this.cboCategoriaClientes.Size = new System.Drawing.Size(146, 21);
            this.cboCategoriaClientes.TabIndex = 25;
            // 
            // txtdevolucion
            // 
            this.txtdevolucion.Location = new System.Drawing.Point(156, 288);
            this.txtdevolucion.Margin = new System.Windows.Forms.Padding(1);
            this.txtdevolucion.Multiline = true;
            this.txtdevolucion.Name = "txtdevolucion";
            this.txtdevolucion.Size = new System.Drawing.Size(227, 46);
            this.txtdevolucion.TabIndex = 24;
            // 
            // lbldevolucion
            // 
            this.lbldevolucion.AutoSize = true;
            this.lbldevolucion.Location = new System.Drawing.Point(19, 305);
            this.lbldevolucion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(118, 13);
            this.lbldevolucion.TabIndex = 23;
            this.lbldevolucion.Text = "FECHA DEVOLUCION:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(156, 352);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(1);
            this.txtvalor.Multiline = true;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(227, 41);
            this.txtvalor.TabIndex = 22;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(19, 369);
            this.lblvalor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(46, 13);
            this.lblvalor.TabIndex = 21;
            this.lblvalor.Text = "VALOR:";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(156, 227);
            this.txtprestamo.Margin = new System.Windows.Forms.Padding(1);
            this.txtprestamo.Multiline = true;
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(227, 44);
            this.txtprestamo.TabIndex = 20;
            // 
            // lblprestamo
            // 
            this.lblprestamo.AutoSize = true;
            this.lblprestamo.Location = new System.Drawing.Point(19, 243);
            this.lblprestamo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblprestamo.Name = "lblprestamo";
            this.lblprestamo.Size = new System.Drawing.Size(126, 13);
            this.lblprestamo.TabIndex = 19;
            this.lblprestamo.Text = "FECHA DE PRESTAMO:";
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Location = new System.Drawing.Point(22, 100);
            this.lblCategoriaCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(138, 13);
            this.lblCategoriaCliente.TabIndex = 13;
            this.lblCategoriaCliente.Text = "CATEGORIA DE CLIENTE:";
            // 
            // lblidAlquiler
            // 
            this.lblidAlquiler.AutoSize = true;
            this.lblidAlquiler.Location = new System.Drawing.Point(342, 189);
            this.lblidAlquiler.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidAlquiler.Name = "lblidAlquiler";
            this.lblidAlquiler.Size = new System.Drawing.Size(21, 13);
            this.lblidAlquiler.TabIndex = 12;
            this.lblidAlquiler.Text = "ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 568);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(809, 538);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosAlquiler);
            this.Name = "alquiler";
            this.Text = "alquiler";
            this.Load += new System.EventHandler(this.alquiler_Load);
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatosAlquiler.ResumeLayout(false);
            this.grbDatosAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbDatosAlquiler;
        private System.Windows.Forms.ComboBox cboCategoriaPeliculas;
        private System.Windows.Forms.Label lblCategoriaPelicula;
        private System.Windows.Forms.Button btnBuscarCategoriaCliente;
        private System.Windows.Forms.ComboBox cboCategoriaClientes;
        private System.Windows.Forms.TextBox txtdevolucion;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.Label lblprestamo;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.Label lblidAlquiler;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCategoriaPelicula;
    }
}