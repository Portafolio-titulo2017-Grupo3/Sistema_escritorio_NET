using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                motivo.descripcion = lector.GetString(1);

                lista.Add(motivo);
            }
            return lista;
        }

        public int ingresarMotivo(Motivos motivo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO MOTIVO(DESCRIPCION_MOTIVO) VALUES('{0}')", motivo.descripcion), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("MOTIVO CREADO EXITOSAMENTE");
            return resp;
        }

        public int modificarMotivo(Motivos motivo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE MOTIVO SET DESCRIPCION_MOTIVO='{0}' WHERE ID_MOTIVO='{1}'", motivo.descripcion, motivo.idMotivo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("MOTIVO MODIFICADO CORRECTAMENTE");
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
        public Motivos buscarMotivo(Motivos motivo)
        {
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM MOTIVO WHERE ID_MOTIVO='{0}'", motivo.idMotivo), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                motivo.idMotivo = lector.GetInt32(0);
                motivo.descripcion = lector.GetString(1);
            }
            else
            {
                MessageBox.Show("ID DE MOTIVO NO ENCONTRADA");
            }
            conexion.Close();
            return motivo;
        }



    }
}
