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
    public partial class frmRegistroDeportista : Form
    {
        public frmRegistroDeportista()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                clsDeportista objDeportista = new clsDeportista();
                objDeportista.varCDeportista = txtCodigo.Text;
                objDeportista.varNombre = txtNombre.Text;
                objDeportista.varApellido = txtApellido.Text;
                objDeportista.varDireccion = txtDireccion.Text;
                objDeportista.varTelefono = Convert.ToInt32(txtTelefono.Text);
                objDeportista.varEdad = Convert.ToInt32(txtEdad.Text);
                objDeportista.varDeportes = lstDeporte.Text;
                objDeportista.Agregar();

                MessageBox.Show("Carga Realizada");

                Limpiar();

                txtCodigo.Focus();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            } 

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroDeportista_Load(object sender, EventArgs e)
        {

        }
    }
}
