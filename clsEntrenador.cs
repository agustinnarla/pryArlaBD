using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaBD
{
    internal class clsEntrenador
    {
        private OleDbConnection objConexion = new OleDbConnection();
        private OleDbCommand objComando = new OleDbCommand();
        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";

        private string varTabla = "ENTRENADORES";

        private string varCodigoEntrenador;
        private string varNombreEntrenador;
        private string varApellidoEntrenador;
        private string varDireccionEntrenador;
        private string varProvinciaEntrenador;
        private string varDeporte;

        public string varCDeportista
        {
            get { return varCodigoEntrenador; }
            set { varCodigoEntrenador = value; }
        }
        public string varNombre
        {
            get { return varNombreEntrenador; }
            set { varNombreEntrenador = value; }
        }
        public string varApellido
        {
            get { return varApellidoEntrenador; }
            set { varApellidoEntrenador = value; }
        }
        public string varDireccion
        {
            get { return varDireccionEntrenador; }
            set { varDireccionEntrenador = value; }
        }
        public string varProvincia
        {
            get { return varProvinciaEntrenador; }
            set { varProvinciaEntrenador = value; }
        }
        
        public string varDeportes
        {
            get { return varDeporte; }
            set { varDeporte = value; }
        }
        public void Agregar()
        {
            try
            {
                objConexion = new OleDbConnection(varRuta);
                objConexion.Open();

                objComando = new OleDbCommand();

                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.Text;

                //Carga de la base de datos
                objComando.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    " VALUES ('" + varCodigoEntrenador + "','" + varNombre + "','" + varApellido + "','" + varDireccion + "','" + varProvincia + "','" + varDeportes + "')";

                objComando.ExecuteNonQuery();
                MessageBox.Show("Datos cargados ");
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
            }
            objConexion.Close();
        }
        public void Buscar(string parCodigo)
        {
            try
            {
                objConexion.ConnectionString = varRuta;
                objConexion.Open();

                //objComando toma la conexion 
                objComando.Connection = objConexion;
                //me trae la tabla 
                objComando.CommandType = CommandType.TableDirect;

                objComando.CommandText = varTabla;

                //recibo el contenido 
                OleDbDataReader objLectura = objComando.ExecuteReader();

                //Si hay elementos 
                if (objLectura.HasRows)
                {
                    //Procede a leer
                    while (objLectura.Read())
                    {
                        if (objLectura.GetString(0) == parCodigo)
                        {
                            varCodigoEntrenador = objLectura.GetString(0);
                            varNombreEntrenador = objLectura.GetString(1);
                            varApellidoEntrenador = objLectura.GetString(2);
                            varDireccionEntrenador = objLectura.GetString(3);
                            varProvinciaEntrenador = objLectura.GetString(4);
                            varDeporte = objLectura.GetString(5);
                        }
                    }
                }
                objConexion.Close();


            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message)
                /*throw*/;
            }
        }
        public void Eliminar(string parCodigoEntrenador)
        {
            try
            {
                string varSentenciaSQL = "DELETE FROM DEPORTISTA WHERE ('" + parCodigoEntrenador + "'= [CODIGO DEPORTISTA])";
                //conectamos base de datos 
                objConexion.ConnectionString = varRuta;
                objConexion.Open();

                //objComando toma la conexion 
                objComando.Connection = objConexion;
                //me trae la tabla 
                objComando.CommandType = CommandType.Text;

                objComando.CommandText = varSentenciaSQL;
                //ejecutamos la intruccion q nosotros le pedimos 
                objComando.ExecuteNonQuery();

                objConexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                /*throw*/

            }
        }
        public void Modificar(string parCDeportista)
        {
            try
            {
                string varSentenciaSQL = "UPDATE DEPORTISTA SET ([NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE]) WHERE ('" + varCodigoEntrenador + "'= [CODIGO DEPORTISTA])";

                //conectamos base de datos 
                objConexion.ConnectionString = varRuta;
                objConexion.Open();

                //objComando toma la conexion 
                objComando.Connection = objConexion;
                //me trae la tabla 
                objComando.CommandType = CommandType.Text;

                objComando.CommandText = varSentenciaSQL;
                //ejecutamos la intruccion q nosotros le pedimos 
                objComando.ExecuteNonQuery();

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
