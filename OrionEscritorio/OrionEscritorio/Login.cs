using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class Login
    {
        public Boolean validarUsuario(String usuar, String clave)
        {
            Boolean existe;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand("SELECT * FROM USUARIO WHERE NOMBRE_USUARIO='" + usuar + "' AND CLAVE_USUARIO='" + clave + "' ", conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read()) existe = true;
            else existe = false;
            return existe;
        }

    }
}
