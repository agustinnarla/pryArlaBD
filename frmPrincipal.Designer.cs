namespace pryArlaBD
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.stsConexion = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.msDatos = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsConexion.SuspendLayout();
            this.msDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsConexion
            // 
            this.stsConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblFecha});
            this.stsConexion.Location = new System.Drawing.Point(0, 354);
            this.stsConexion.Name = "stsConexion";
            this.stsConexion.Size = new System.Drawing.Size(753, 22);
            this.stsConexion.TabIndex = 0;
            this.stsConexion.Text = "stsConexion";
            this.stsConexion.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Conexion_ItemClicked);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(12, 17);
            this.lblEstado.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 17);
            this.lblFecha.Text = "-";
            // 
            // msDatos
            // 
            this.msDatos.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.msDatos.Location = new System.Drawing.Point(0, 0);
            this.msDatos.Name = "msDatos";
            this.msDatos.Size = new System.Drawing.Size(753, 24);
            this.msDatos.TabIndex = 1;
            this.msDatos.Text = "-";
            this.msDatos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistaToolStripMenuItem,
            this.entrenadorToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modifiarEliminarToolStripMenuItem});
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deportistaToolStripMenuItem.Text = "Deportista";
            this.deportistaToolStripMenuItem.Click += new System.EventHandler(this.deportistaToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarToolStripMenuItem.Text = "Agregar ";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modifiarEliminarToolStripMenuItem
            // 
            this.modifiarEliminarToolStripMenuItem.Name = "modifiarEliminarToolStripMenuItem";
            this.modifiarEliminarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modifiarEliminarToolStripMenuItem.Text = "Modificar/Eliminar";
            this.modifiarEliminarToolStripMenuItem.Click += new System.EventHandler(this.modifiarEliminarToolStripMenuItem_Click);
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarEliminarToolStripMenuItem});
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // modificarEliminarToolStripMenuItem
            // 
            this.modificarEliminarToolStripMenuItem.Name = "modificarEliminarToolStripMenuItem";
            this.modificarEliminarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificarEliminarToolStripMenuItem.Text = "Modificar/Eliminar";
            this.modificarEliminarToolStripMenuItem.Click += new System.EventHandler(this.modificarEliminarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeportistaToolStripMenuItem,
            this.consultaEntrenadorToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaDeportistaToolStripMenuItem
            // 
            this.consultaDeportistaToolStripMenuItem.Name = "consultaDeportistaToolStripMenuItem";
            this.consultaDeportistaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultaDeportistaToolStripMenuItem.Text = "Consulta-Deportista";
            this.consultaDeportistaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeportistaToolStripMenuItem_Click);
            // 
            // consultaEntrenadorToolStripMenuItem
            // 
            this.consultaEntrenadorToolStripMenuItem.Name = "consultaEntrenadorToolStripMenuItem";
            this.consultaEntrenadorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultaEntrenadorToolStripMenuItem.Text = "Consulta-Entrenador ";
            this.consultaEntrenadorToolStripMenuItem.Click += new System.EventHandler(this.consultaEntrenadorToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 376);
            this.Controls.Add(this.stsConexion);
            this.Controls.Add(this.msDatos);
            this.MainMenuStrip = this.msDatos;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.stsConexion.ResumeLayout(false);
            this.stsConexion.PerformLayout();
            this.msDatos.ResumeLayout(false);
            this.msDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.MenuStrip msDatos;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEntrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiarEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarToolStripMenuItem;
    }
}

