using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class TMotivo
    {
        public static List<Motivos> listarMotivo()
        {
            List<Motivos> lista = new List<Motivos>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM MOTIVO"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Motivos motivo = new Motivos();

                motivo.idMotivo  = lector.GetInt32(0);
                motivo.nombre = lector.GetString(1);
                motivo.descripcion = lector.GetString(2);
                //motivo.permiso_id = lector.GetInt32(3);

                lista.Add(motivo);
            }
            return lista;
        }

        public int ingresarMotivo(Motivos motivo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO MOTIVO(ID_MOTIVO, NOMBRE_MOTIVO, DESCRIPCION_MOTIVO, PERMISO_ID_PERMISO) VALUES('{0}', '{1}', '{2}', NULL)", motivo.idMotivo, motivo.nombre, motivo.descripcion), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int modificarMotivo(Motivos motivo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE MOTIVO SET NOMBRE_MOTIVO='{0}',DESCRIPCION_MOTIVO={1} WHERE ID_MOTIVO='{2}'", motivo.nombre, motivo.descripcion, motivo.idMotivo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int eliminarMotivo(int idMotivo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("DELETE FROM MOTIVO WHERE ID_MOTIVO='{0}'", idMotivo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


        //Queries
        public Motivos buscarMotivo(int idMotivo)
        {
            Motivos motivo = new Motivos();
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM MOTIVO WHERE ID_MOTIVO=@idMotivo"), conexion);
            orden.Parameters.Add("@ID_MOTIVO", idMotivo);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                motivo.idMotivo = lector.GetInt32(0);
                motivo.nombre = lector.GetString(1);
                motivo.descripcion = lector.GetString(2);
                //motivo.permiso_id = lector.GetInt32(3);

            }
            conexion.Close();
            return motivo;
        }



    }
}
