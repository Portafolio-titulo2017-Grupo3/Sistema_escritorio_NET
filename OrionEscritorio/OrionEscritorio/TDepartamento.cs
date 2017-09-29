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
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select max(id_depto) from departamento"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                dpto.idDepto = 1 + lector.GetInt32(0);
            }


            int resp = 0;

            OracleCommand orden2 = new OracleCommand(string.Format("INSERT INTO DEPARTAMENTO(ID_DEPTO, NOMBRE_DEPTO) VALUES('{0}', '{1}')", dpto.idDepto, dpto.nombre), conexion);
            resp = orden2.ExecuteNonQuery();
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
        public Departamento buscarDepartamento(Departamento dpto)
        {
            //Departamento dpto = new Departamento();
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("SELECT * FROM DEPARTAMENTO WHERE ID_DEPTO='{0}'", dpto.idDepto), conexion);
            //orden.Parameters.Add("@ID_DEPTO", idDpto);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                dpto.nombre = lector.GetString(1);
            }
            conexion.Close();
            return dpto;
        }

        public int modBuscar(Departamento dpto)
        {
            int resp = 0;


            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(String.Format("select * from DEPARTAMENTO where ID_DEPTO =" + "'" + dpto.idDepto + "'"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                dpto.nombre = lector.GetString(1);
            }


            return resp;

        }

        public int modificarDepartamento(Departamento dpto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("UPDATE DEPARTAMENTO SET NOMBRE_DEPTO='"+ dpto.nombre + "' WHERE ID_DEPTO='"+ dpto.idDepto + "'"), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

    }
}
