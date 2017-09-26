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
        public string Motivo { get; set; }

        public TMotivo(string Motivo)
        {
            this.Motivo = Motivo;
        }

        public TMotivo()
        {

        }

        public static List<TMotivo> listarTest()
        {
            List<TMotivo> lista = new List<TMotivo>();
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("SELECT * FROM Motivo"), conexion);
            OracleDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                TMotivo test = new TMotivo();
                test.Motivo = lector.GetString(0);
                lista.Add(test);
            }
            return lista;
        }



    }
}
