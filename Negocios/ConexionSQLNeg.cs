using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class ConexionSQLNeg
    {
        ConexionSQL ConexionAccess = new ConexionSQL();
        ConexionSQL ConexionSQL = new ConexionSQL();
       // EntCompañias EntCompañias = new EntCompañias();


        public  int ConsultaCompañia()
        {
            return ConexionAccess.ConsultaCompañia();
        }

        public DataTable ListadoCompañia() 
        {
            return ConexionAccess.ListadoCompañia();        
        }

        public string BuscaCompañia(string nombreCompnia)
        {
            return ConexionAccess.BuscaCompañia(nombreCompnia);
        }

        public Boolean ContraseñaCorrecta(string Nombreusuario, string Contraseña)
        {
            return ConexionSQL.ContraseñaCorrecta(Nombreusuario, Contraseña);
        }

        public int CantUsuario() 
        {
            return ConexionSQL.CantUsuario();
        }

    }
}
