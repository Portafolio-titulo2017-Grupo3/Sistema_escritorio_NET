using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class Conexion
    {
        
        public static OracleConnection abrirConexion()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=db1.cztngvuqdqia.sa-east-1.rds.amazonaws.com:1521/ORADB;USER ID=MATIAS;PASSWORD=123456123");
            conn.Open();
            return conn;
        }

    }
}
