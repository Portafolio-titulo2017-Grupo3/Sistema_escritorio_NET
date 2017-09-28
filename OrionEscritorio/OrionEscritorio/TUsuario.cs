using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class TUsuario
    {

        public static List<Usuario> listarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM USUARIO"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Usuario usu = new Usuario();

                usu.idUsuario = lector.GetInt32(0);
                usu.nombre = lector.GetString(1);
                usu.clave = lector.GetString(2);
                usu.rut_funcionario = lector.GetString(3);


                lista.Add(usu);
            }

            return lista;
        }

        public int ingresarUsuario(Usuario usu)
        {
            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO USUARIO(ID_USUARIO, NOMBRE_USUARIO, CLAVE_USUARIO, FUNCIONARIO_RUT_FUNCIONARIO, PERFIL_ID_PERFIL) VALUES('{0}', '{1}', '{2}', NULL)", usu.idUsuario, usu.nombre, usu.clave, usu.rut_funcionario), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int modificarUsuario(Usuario usu)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE USUARIO SET CLAVE_USUARIO='{0}' WHERE NOMBRE_USUARIO='{1}'", usu.clave, usu.nombre), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int eliminarUsuario(string user)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("DELETE FROM USUARIO WHERE NOMBRE_USUARIO='{0}'", user), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


        //Queries
        public Usuario buscarUsuario(string user)
        {
            Usuario usu = new Usuario();
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM USUARIO WHERE NOMBRE_USUARIO=@user"), conexion);
            orden.Parameters.Add("@NOMBRE_USUARIO", user);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                usu.idUsuario = lector.GetInt32(0);
                usu.nombre = lector.GetString(1);
                usu.clave = lector.GetString(2);
                usu.rut_funcionario= lector.GetString(3);

            }
            conexion.Close();
            return usu;
        }
    }
}
