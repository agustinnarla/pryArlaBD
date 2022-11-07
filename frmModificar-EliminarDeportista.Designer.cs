namespace pryArlaBD
{
    partial class frmModificar_EliminarDeportista
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(231, 288);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 30);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(137, 288);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 30);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lstDeporte);
            this.mrcDatos.Controls.Add(this.txtEdad);
            this.mrcDatos.Controls.Add(this.lblDeporte);
            this.mrcDatos.Controls.Add(this.lblEdad);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.txtTelefono);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Location = new System.Drawing.Point(22, 69);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(302, 202);
            this.mrcDatos.TabIndex = 3;
            this.mrcDatos.TabStop = false;
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
            this.lstDeporte.Location = new System.Drawing.Point(127, 161);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(147, 21);
            this.lstDeporte.TabIndex = 14;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(127, 135);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 13;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(22, 156);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(45, 13);
            this.lblDeporte.TabIndex = 11;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(22, 132);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 108);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 84);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(127, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(127, 84);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(127, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(114, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(127, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(40, 19);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoDeportista.TabIndex = 5;
            this.lblCodigoDeportista.Text = "Codigo Deportista";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(148, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Location = new System.Drawing.Point(242, 42);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 30);
            this.cmdConsultar.TabIndex = 6;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(43, 288);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 30);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 330);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(-19, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 62);
            this.panel2.TabIndex = 0;
            // 
            // frmModificar_EliminarDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 330);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmModificar_EliminarDeportista";
            this.Text = "Modificar/Eliminar Deportista";
            this.Load += new System.EventHandler(this.frmModificar_Eliminar_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}