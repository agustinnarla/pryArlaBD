using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Win32;

namespace pryArlaBD
{
    internal class clsDeportista
    {
        private OleDbConnection objConexion = new OleDbConnection();
        private OleDbCommand objComando = new OleDbCommand();
        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";

        private string varTabla = "DEPORTISTA";

        private string varCodigoDeportista;
        private string varNombreDeportista;
        private string varApellidoDeportista;
        private string varDireccionDeportista;
        private int varTelefonoDeportista;
        private int varEdadDeportista;
        private string varDeporte;

        public string varCDeportista
        {
            get { return varCodigoDeportista; }
            set { varCodigoDeportista = value; }
        }
        public string varNombre
        {
            get { return varNombreDeportista; }
            set { varNombreDeportista = value; }
        }
        public string varApellido
        {
            get { return varApellidoDeportista; }
            set { varApellidoDeportista = value; }
        }
        public string varDireccion
        {
            get { return varDireccionDeportista; }
            set { varDireccionDeportista = value; }
        }
        public int varTelefono
        {
            get { return varTelefonoDeportista; }
            set { varTelefonoDeportista = value; }
        }
        public int varEdad
        {
            get { return varEdadDeportista; }
            set { varEdadDeportista = value; }
        }
        public string varDeportes
        {
            get { return varDeporte; }
            set { varDeporte = value; }
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
                            varCodigoDeportista = objLectura.GetString(0);
                            varNombreDeportista = objLectura.GetString(1);
                            varApellidoDeportista = objLectura.GetString(2);
                            varDireccionDeportista = objLectura.GetString(3);
                            varTelefonoDeportista = int.Parse(objLectura.GetString(4));
                            varEdadDeportista = objLectura.GetInt32(5);
                            varDeporte = objLectura.GetString(6);
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
        public void Modificar(string parCDeportista)
        {
            try
            {
                string varSentenciaSQL = "UPDATE DEPORTISTA SET NOMBRE = '" + varNombre + "', APELLIDO="  + varApellido + ",DIRECCION='" + varDireccion + "', TELEFONO=" + varTelefono + ", EDAD =" + varEdad + ",[DEPORTE=" + varDeportes + " WHERE ('" + varCodigoDeportista + "'= [CODIGO DEPORTISTA])";
                

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
        public void Eliminar(string parCodigoDeportista)
        {
            try
            {
                string varSentenciaSQL = "DELETE FROM DEPORTISTA WHERE ('" + parCodigoDeportista + "'= [CODIGO DEPORTISTA])";
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
        public void Agregar()
        {
            try
            {
                string varSentenciaSQL = "INSERT INTO DEPORTISTA([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + varCodigoDeportista + "','" + varNombre + "','" + varApellido + "','" + varDireccion + "','" + varTelefono + "','" + varEdad + "','" + varDeporte + "')";
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
                ;
            }
        }
    }
}
