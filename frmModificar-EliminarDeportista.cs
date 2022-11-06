using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaBD
{
    public partial class frmModificar_EliminarDeportista : Form
    {
        public frmModificar_EliminarDeportista()
        {
            InitializeComponent();
        }
        
        public OleDbConnection objConexion;
       
        public OleDbCommand objComando;

    
        public string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsDeportista objDeportista = new clsDeportista();
            objDeportista.Buscar(varCodigo);
           
            if (objDeportista.varCDeportista != varCodigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
                txtCodigo.Enabled = true;
            }
            else
            {
                txtNombre.Text = objDeportista.varNombre;
                txtApellido.Text = objDeportista.varApellido;
                txtDireccion.Text = objDeportista.varDireccion;
                txtEdad.Text = Convert.ToString(objDeportista.varEdad);
                txtTelefono.Text = Convert.ToString(objDeportista.varTelefono);
                lstDeporte.Text = Convert.ToString(objDeportista.varDeportes);
                txtCodigo.Enabled = false;
                Habilitar();
            }
           
           

            
            
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsDeportista objDeportista = new clsDeportista();
            objDeportista.Modificar(varCodigo);
            MessageBox.Show("Deportista modificado");
            Limpiar();
            txtCodigo.Enabled = true;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string varCodigo = txtCodigo.Text;
            clsDeportista objDeportista = new clsDeportista();
            objDeportista.Eliminar(varCodigo);
            MessageBox.Show("Deportista eliminado");
            Limpiar();
            txtCodigo.Enabled = true;
        }

        private void frmModificar_Eliminar_Load(object sender, EventArgs e)
        {
            
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
        private void Habilitar()
        {
            cmdModificar.Enabled = true;
            cmdEliminar.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtEdad.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            lstDeporte.Enabled = true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
