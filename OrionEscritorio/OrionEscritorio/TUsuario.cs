using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

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
                usu.nombre = lector.GetString(2);
                usu.clave = lector.GetString(1);
                usu.rut_funcionario = lector.GetString(3);
                usu.perfil_id = lector.GetInt32(4);


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

            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            
            OracleCommand orden3 = new OracleCommand(string.Format("INSERT INTO USUARIO(CLAVE_USUARIO, NOMBRE_USUARIO, FUNCIONARIO_RUT_FUNCIONARIO, PERFIL_ID_PERFIL) VALUES('{0}', '{1}', '{2}', '{3}')", usu.clave, usu.nombre, usu.rut_funcionario, usu.perfil_id), conexion);
            resp = orden3.ExecuteNonQuery();

            conexion.Close();
            return resp;
        }


        public int modBuscar(Usuario usu)
        {
            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select * from Usuario where ID_USUARIO =" + "'" + usu.idUsuario+"'"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                
                usu.clave = lector.GetString(1);
                usu.nombre = lector.GetString(2);
            }
            else
            {
                MessageBox.Show("ID DE USUARIO NO ENCONTRADA");
            }


            return resp;

        }

        public int modificarUsuario(Usuario usu)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE USUARIO SET CLAVE_USUARIO='{0}',PERFIL_ID_PERFIL='{1}' WHERE ID_USUARIO='{2}'", usu.clave, usu.perfil_id,usu.idUsuario), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            

            MessageBox.Show("USUARIO MODIFICADO CORRECTAMENTE");
           
            return resp;

        }

        public int eliminarUsuario(int idUsuario)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("DELETE FROM USUARIO WHERE ID_USUARIO='{0}'", idUsuario), conexion);
            resp = orden.ExecuteNonQuery();
            if (resp!=0)
            {
                MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("USUARIO NO ELIMINADO");
            }
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
