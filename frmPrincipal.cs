using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryArlaBD
{
    public partial class frmPrincipal : Form
    {
        public OleDbConnection objConexion;
        public OleDbCommand objDato;
        public OleDbDataReader objLecutra;

        public string varRuta = "DEPORTE.accdb";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.ToString();
                objConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRuta);
                objConexion.Open();
                lblEstado.Text = "Conectado: " + objConexion.ConnectionString;
                stsConexion.BackColor = Color.GreenYellow;
            }
            catch (Exception Mensajito)
            {
                stsConexion.BackColor = Color.Red;
                lblEstado.Text = Mensajito.Message;
                //throw;
            }
        }

        private void Conexion_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultaDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeporte objConsultaDeporte = new frmConsultaDeporte();
            objConsultaDeporte.ShowDialog();
            

        }

        private void consultaEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador objConsultaEntrenador = new frmConsultaEntrenador();
            objConsultaEntrenador.ShowDialog();
        }
    }
}
