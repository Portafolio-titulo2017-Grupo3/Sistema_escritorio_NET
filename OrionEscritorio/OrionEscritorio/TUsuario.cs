using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

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

        public DataTable listarDatos()
        {
          
            DataTable dt = new DataTable();
            OracleConnection conexion = Conexion.abrirConexion();
            String query = "select * from perfil order by ID_PERFIL";
            OracleCommand command = new OracleCommand(query, conexion);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        public int ingresarUsuario(Usuario usu)
        {


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select max(id_usuario) from usuario"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                usu.idUsuario = 1+lector.GetInt32(0);
            }


                int resp = 0;
        
            OracleCommand orden2 = new OracleCommand(string.Format("INSERT INTO USUARIO(ID_USUARIO, NOMBRE_USUARIO, CLAVE_USUARIO,PERFIL_ID_PERFIL ,FUNCIONARIO_RUT_FUNCIONARIO) VALUES('{0}', '{1}', '{2}', '{3}','{4}')", usu.idUsuario, usu.nombre, usu.clave, usu.perfil_id, usu.rut_funcionario), conexion);
            resp = orden2.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


        public int modBuscar(Usuario usu)
        {
            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select * from Usuario where FUNCIONARIO_RUT_FUNCIONARIO =" + "'" + usu.rut_funcionario+"'"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                usu.nombre = lector.GetString(1);
                usu.clave = lector.GetString(2);
            }


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
