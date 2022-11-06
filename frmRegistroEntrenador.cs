using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaBD
{
    public partial class frmRegistroEntrenador : Form
    {
        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            clsEntrenador objEntrenador = new clsEntrenador();
            objEntrenador.varCDeportista = txtCodigo.Text;
            objEntrenador.varNombre = txtNombre.Text;
            objEntrenador.varApellido = txtApellido.Text;
            objEntrenador.varDireccion = txtDireccion.Text;
            objEntrenador.varProvincia = lstProvincia.Text;
            objEntrenador.varDeportes = lstDeporte.Text;
            objEntrenador.Agregar();

            MessageBox.Show("Carga Realizada");

            Limpiar();

            txtCodigo.Focus();
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            lstProvincia.SelectedIndex = -1;
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
