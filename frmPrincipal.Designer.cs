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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEntrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsConexion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsConexion
            // 
            this.stsConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblFecha});
            this.stsConexion.Location = new System.Drawing.Point(0, 428);
            this.stsConexion.Name = "stsConexion";
            this.stsConexion.Size = new System.Drawing.Size(800, 22);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "-";
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
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deportistaToolStripMenuItem.Text = "Deportista";
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsConexion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.stsConexion.ResumeLayout(false);
            this.stsConexion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEntrenadorToolStripMenuItem;
    }
}

