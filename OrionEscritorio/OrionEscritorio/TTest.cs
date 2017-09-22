using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class TTest
    {
        public int ingresarTest(Test test)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TEST(DATO_QLO) VALUES('{0}')", test.datoqlo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public static List<Test> listarTest()
        {
            List<Test> lista = new List<Test>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM TEST"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Test test = new Test();
                test.datoqlo = lector.GetString(0);
                lista.Add(test);
            }
            return lista;
        }

    }//Class
}
