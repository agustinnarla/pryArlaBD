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
    public partial class frmModificar_EliminarEntrenador : Form
    {
        public frmModificar_EliminarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsEntrenador objEntrenador = new clsEntrenador();
            objEntrenador.Buscar(varCodigo);

            if (objEntrenador.varCDeportista != varCodigo)
            {
                MessageBox.Show("El entrenador no se encuentra en la base de datos");
                txtCodigo.Enabled = true;
            }
            else
            {
                txtNombre.Text = objEntrenador.varNombre;
                txtApellido.Text = objEntrenador.varApellido;
                txtDireccion.Text = objEntrenador.varDireccion;
                lstProvincia.Text = objEntrenador.varProvincia;
                lstDeporte.Text = Convert.ToString(objEntrenador.varDeportes);
                txtCodigo.Enabled = false;
                Habilitar();
            }
        }

        private void frmModificar_EliminarEntrenador_Load(object sender, EventArgs e)
        {

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
        private void Habilitar()
        {
            cmdModificar.Enabled = true;
            cmdEliminar.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            
            txtNombre.Enabled = true;
            lstProvincia.Enabled = true;
            lstDeporte.Enabled = true;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsEntrenador objEntrenador = new clsEntrenador();
            objEntrenador.Eliminar(varCodigo);
            MessageBox.Show("Entrenador eliminado");
            Limpiar();
            txtCodigo.Enabled = true;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsEntrenador objEntrenador = new clsEntrenador();
            objEntrenador.Modificar(varCodigo);
            MessageBox.Show("Entrenador modificado");
            Limpiar();
            txtCodigo.Enabled = true;
        }
    }
}
