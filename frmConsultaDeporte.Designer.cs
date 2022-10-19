namespace pryArlaBD
{
    partial class frmConsultaDeporte
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
            this.grlDeportes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grlDeportes)).BeginInit();
            this.SuspendLayout();
            // 
            // grlDeportes
            // 
            this.grlDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlDeportes.Location = new System.Drawing.Point(12, 11);
            this.grlDeportes.Name = "grlDeportes";
            this.grlDeportes.Size = new System.Drawing.Size(776, 300);
            this.grlDeportes.TabIndex = 0;
            // 
            // frmConsultaDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grlDeportes);
            this.Name = "frmConsultaDeporte";
            this.Text = "Consulta-Deporte";
            ((System.ComponentModel.ISupportInitialize)(this.grlDeportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlDeportes;
    }
}