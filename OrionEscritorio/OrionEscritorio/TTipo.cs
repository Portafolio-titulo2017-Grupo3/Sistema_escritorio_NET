using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class TTipo
    {
        public static List<Tipo> listarTipo()
        {
            List<Tipo> lista = new List<Tipo>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM TIPO"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Tipo tipo = new Tipo();

                tipo.idTipo = lector.GetInt32(0);
                tipo.nombre = lector.GetString(1);
                tipo.descripcion = lector.GetString(2);
                //tipo.permiso_id = lector.GetInt32(3);

                lista.Add(tipo);
            }
            return lista;
        }

        public int ingresarTipo(Tipo tipo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TIPO(ID_TIPO, NOMBRE_TIPO, DESCRIPCION_TIPO, PERMISO_ID_PERMISO) VALUES('{0}', '{1}', '{2}', NULL)", tipo.idTipo, tipo.nombre, tipo.descripcion), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int modificarTipo(Tipo tipo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE TIPO SET NOMBRE_TIPO='{0}',DESCRIPCION_TIPO={1} WHERE ID_TIPO='{2}'", tipo.nombre, tipo.descripcion, tipo.idTipo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int eliminarTipo(int idTipo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("DELETE FROM TIPO WHERE ID_TIPO='{0}'", idTipo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


        //Queries
        public Tipo buscarTipo(int idTipo)
        {
            Tipo tipo = new Tipo();
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM TIPO WHERE ID_TIPO=@idTipo"), conexion);
            orden.Parameters.Add("@ID_TIPO", idTipo);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                tipo.idTipo = lector.GetInt32(0);
                tipo.nombre = lector.GetString(1);
                tipo.descripcion = lector.GetString(2);
                //motivo.permiso_id = lector.GetInt32(3);

            }
            conexion.Close();
            return tipo;
        }
    }
}
