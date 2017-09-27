using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient;

namespace OrionEscritorio
{
    class TDepartamento
    {
        public static List<Departamento> listarDepartamento()
        {
            List<Departamento> lista = new List<Departamento>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM DEPARTAMENTO"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Departamento dpto = new Departamento();

                dpto.idDepto = lector.GetInt32(0);
                dpto.nombre = lector.GetString(1);


                lista.Add(dpto);
            }
            return lista;
        }

        public int ingresarDepartamento(Departamento dpto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO MOTIVO(ID_DEPTO, NOMBRE_DEPTO) VALUES('{0}', '{1}')", dpto.idDepto, dpto.nombre), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int modificarDepartamento(Departamento dpto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton  
            OracleCommand orden = new OracleCommand(string.Format("UPDATE DEPARTAMENTO SET NOMBRE='{0}' WHERE ID_DEPTO='{1}'", dpto.nombre, dpto.idDepto), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public int eliminarDepartamento(int idDpto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("DELETE FROM DEPARTAMENTO WHERE ID_DEPTO='{0}'", idDpto), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


        //Queries
        public Departamento buscarDepartamento(int idDpto)
        {
            Departamento dpto = new Departamento();
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM DEPARTAMENTO WHERE ID_DEPTO=@idDpto"), conexion);
            orden.Parameters.Add("@ID_DEPTO", idDpto);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                dpto.idDepto = lector.GetInt32(0);
                dpto.nombre = lector.GetString(1);
            }
            conexion.Close();
            return dpto;
        }
    }
}
