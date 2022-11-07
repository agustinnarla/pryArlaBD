namespace pryArlaBD
{
    partial class frmModificar_EliminarEntrenador
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrendador = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtProvincia);
            this.mrcDatos.Controls.Add(this.lstDeporte);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Controls.Add(this.lblProvincia);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Location = new System.Drawing.Point(12, 73);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(302, 192);
            this.mrcDatos.TabIndex = 4;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos";
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.Enabled = false;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporte.Location = new System.Drawing.Point(130, 142);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(147, 21);
            this.lstDeporte.TabIndex = 14;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(16, 142);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(45, 13);
            this.lblDeporte.TabIndex = 11;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 86);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(130, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(130, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(130, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigoEntrendador
            // 
            this.lblCodigoEntrendador.AutoSize = true;
            this.lblCodigoEntrendador.Location = new System.Drawing.Point(28, 19);
            this.lblCodigoEntrendador.Name = "lblCodigoEntrendador";
            this.lblCodigoEntrendador.Size = new System.Drawing.Size(101, 13);
            this.lblCodigoEntrendador.TabIndex = 5;
            this.lblCodigoEntrendador.Text = "Codigo Entrendador";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(142, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Location = new System.Drawing.Point(239, 37);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 30);
            this.cmdConsultar.TabIndex = 7;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(37, 271);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 30);
            this.cmdEliminar.TabIndex = 10;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(225, 271);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 30);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(131, 271);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 30);
            this.cmdModificar.TabIndex = 8;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(16, 114);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 9;
            this.lblProvincia.Text = "Provincia ";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Location = new System.Drawing.Point(130, 114);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(147, 20);
            this.txtProvincia.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 313);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(1, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 73);
            this.panel2.TabIndex = 1;
            // 
            // frmModificar_EliminarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 313);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoEntrendador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmModificar_EliminarEntrenador";
            this.Text = "Modificar/Eliminar Entrenador";
            this.Load += new System.EventHandler(this.frmModificar_EliminarEntrenador_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoEntrendador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}