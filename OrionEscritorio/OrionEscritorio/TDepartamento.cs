using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class TDepartamento
    {
        public int ingresarDepartamento(Departamento depto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TEST(DATO_QLO) VALUES('{0}')", depto.datoqlo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        
        public static List<Departamento> listarTest()
        {
            List<Departamento> lista = new List<Departamento>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM TEST"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Departamento dpto = new Departamento();
                dpto.datoqlo = lector.GetString(0);
                lista.Add(dpto);
            }
            return lista;
        }
    }
}
