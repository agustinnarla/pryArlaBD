namespace pryArlaBD
{
    partial class frmConsultaEntrenador
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
            this.grlEntrenador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grlEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // grlEntrenador
            // 
            this.grlEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlEntrenador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grlEntrenador.Location = new System.Drawing.Point(0, 0);
            this.grlEntrenador.Name = "grlEntrenador";
            this.grlEntrenador.ReadOnly = true;
            this.grlEntrenador.Size = new System.Drawing.Size(800, 450);
            this.grlEntrenador.TabIndex = 0;
            this.grlEntrenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grlEntrenador_CellContentClick);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grlEntrenador);
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta-Entrenador";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlEntrenador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlEntrenador;
    }
}