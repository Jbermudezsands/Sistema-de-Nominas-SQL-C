using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class ConexionSQL
    {
       
        //EntCompañias EntCompañias = new EntCompañias();
        public ConexionSQL() { }
        string RutaBD = Directory.GetCurrentDirectory() + "\\CntNominas.dll";


        public string conexionAccess()
        {
            string ConexionAccess = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + RutaBD;
            return ConexionAccess;
        }

        public string conexionSQl()
        {
            string ConexionSQL =EntCompañias.Cadena;
            return ConexionSQL;
        }


        public OleDbConnection MiConexionAccess()
        {
            OleDbConnection MiConexionAccess = new OleDbConnection(conexionAccess());
            return MiConexionAccess;
        }

        public SqlConnection MiConexionSQL()
        {
           SqlConnection  MiConexionSQL = new SqlConnection(conexionSQl());
            return MiConexionSQL;
        }


        public int ConsultaCompañia()
        {
                       

            //Creo la Conexion con el archivo que tiene el listado de Compañias.
            using (OleDbConnection MiConexion = new OleDbConnection(conexionAccess()))
            {
                MiConexion.Open();
                string StrSQLAccess = "Select * From Servidor";
                OleDbDataAdapter DataAdapterAccess = new OleDbDataAdapter(StrSQLAccess, MiConexion);
                DataSet DataSetCompañias = new DataSet();
                DataAdapterAccess.Fill(DataSetCompañias, "Compañias");
                MiConexion.Close();
                return DataSetCompañias.Tables["Compañias"].Rows.Count;
            }

        }


        public DataTable ListadoCompañia()
        {
            using (OleDbConnection MiConexionAccess = new OleDbConnection(conexionAccess()))
            {

                MiConexionAccess.Open();
                string StrSQLAccess = "Select * From Servidor";
                OleDbDataAdapter DataAdapterAccess = new OleDbDataAdapter(StrSQLAccess, MiConexionAccess);
                DataSet DataSetCompañias = new DataSet();
                DataAdapterAccess.Fill(DataSetCompañias, "Compañias");
                MiConexionAccess.Close();
                return DataSetCompañias.Tables["Compañias"];

            }
        }


        public string BuscaCompañia(string NombreCompañia)
        {
            try
            {
                using (OleDbConnection MiConexionAccess = new OleDbConnection(conexionAccess()))
                {
                    int Count;
                    string Cadena = "";


                    MiConexionAccess.Open();
                    string StrSQLAccess = "Select * From Servidor Where (NombreBD= '" + NombreCompañia + "') ";
                    OleDbCommand Comando = new OleDbCommand(StrSQLAccess, MiConexionAccess);
                    OleDbDataAdapter DataAdapterAccess = new OleDbDataAdapter(Comando);
                    DataTable Compañia = new DataTable();
                    DataAdapterAccess.Fill(Compañia);
                    Count = Compañia.Rows.Count;
                    if (Count == 0)
                    {
                        Cadena = "";
                    }
                    else
                    {
                        Cadena = Compañia.Rows[0]["Servidor"].ToString();
                    }
                    return Cadena;
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    


    public int CantUsuario()
    {
        using (SqlConnection MiConexion = new SqlConnection(conexionSQl()))
        {
            int Contador;
            MiConexion.Open();
            string SQLString = "SELECT * FROM Usuarios";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(SQLString, MiConexion);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "Usuarios");
            Contador = DataSet.Tables["Usuarios"].Rows.Count;
            MiConexion.Close();
            return Contador;
        }

    }


    public Boolean ContraseñaCorrecta(string NombreUsuario, string Contraseña)
    {
        using (SqlConnection MiConexion = new SqlConnection(conexionSQl()))
        {
            Boolean Respuesta;
            MiConexion.Open();
            string SQLString = "SELECT * FROM Usuarios WHERE(NombreUsuario = '" + NombreUsuario + "') AND(Clave = '" + Contraseña + "')";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(SQLString, MiConexion);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "Usuarios");
            if (DataSet.Tables["Usuarios"].Rows.Count == 0)
            {
                Respuesta = false;
            }
            else
            {
                    EntCompañias.Nombre_Usuario = NombreUsuario;
                    EntCompañias.Contraseña = Contraseña;
                    Respuesta = true;
            }
            MiConexion.Close();

            return Respuesta;

        }

    }







}


   
}
