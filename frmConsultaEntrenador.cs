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
    public partial class frmConsultaEntrenador : Form
    {
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        string varRuta = "DEPORTE.accdb";
        string varSentenciaSQL = "SELECT * FROM ENTRENADORES";

        OleDbConnection objConexion;
        OleDbCommand objComando;
        OleDbDataAdapter objLectura;

        //Agregamos datos 
        DataSet objAgregarDatos;

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {
            try
            {
                objConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRuta);
                objConexion.Open();

                objComando = new OleDbCommand(varSentenciaSQL, objConexion);

                objLectura = new OleDbDataAdapter(objComando);

                objAgregarDatos = new DataSet();

                objLectura.Fill(objAgregarDatos, "ENTRENADORES");

                //Data Member lectura de la tabla 
                grlEntrenador.DataMember = "ENTRENADORES";

                //Obtiene origen del dato 
                grlEntrenador.DataSource = objAgregarDatos;

                objConexion.Close();
                 
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }

        private void grlEntrenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
