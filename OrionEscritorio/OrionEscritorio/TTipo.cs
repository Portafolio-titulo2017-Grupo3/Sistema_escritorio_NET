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
                tipo.descripcion = lector.GetString(1);
                tipo.nombre = lector.GetString(2);
                //tipo.permiso_id = lector.GetInt32(3);

                lista.Add(tipo);
            }
            return lista;
        }

        public int ingresarTipo(Tipo tipo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TIPO(DESCRIPCION_TIPO,NOMBRE_TIPO) VALUES('{0}','{1}')", tipo.descripcion,tipo.nombre), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int modificarTipo(Tipo tipo)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE TIPO SET NOMBRE_TIPO='{0}',DESCRIPCION_TIPO='{1}' WHERE ID_TIPO='{2}'", tipo.nombre,tipo.descripcion, tipo.idTipo), conexion);
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
        public int modBuscar(Tipo dpto)
        {
            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select * from tipo where ID_TIPO =" + "'" + dpto.idTipo + "'"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                dpto.descripcion = lector.GetString(1);
                dpto.nombre = lector.GetString(2);
                
            }


            return resp;

        }
    }
    }

