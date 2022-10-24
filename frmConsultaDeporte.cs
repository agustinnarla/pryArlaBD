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
    public partial class frmConsultaDeporte : Form
    {
        public frmConsultaDeporte()
        {
            InitializeComponent();
        }


        string varSetenciaSQL = "SELECT * FROM DEPORTISTA";
        string varRuta = "DEPORTE.accdb";

        OleDbConnection objConexion;
        OleDbCommand objComando;
        OleDbDataAdapter objLectura;

        DataSet objAgregarDatos;

        
        private void grlDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmConsultaDeporte_Load(object sender, EventArgs e)
        {

            try
            {
                objConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRuta);
                objConexion.Open();

                objComando = new OleDbCommand(varSetenciaSQL, objConexion);

                objLectura = new OleDbDataAdapter(objComando);

                objAgregarDatos = new DataSet();

                objLectura.Fill(objAgregarDatos, "DEPORTISTA");

                grlDeportes.DataMember = "DEPORTISTA";

                grlDeportes.DataSource = objAgregarDatos;

                objConexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }
    }
}
