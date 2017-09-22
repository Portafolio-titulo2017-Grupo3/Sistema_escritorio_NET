using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OrionEscritorio
{
    class Conexion
    {
        public static OracleConnection abrirConexion()
        {
            OracleConnection conectar = new OracleConnection("Data Source=db1.cztngvuqdqia.sa-east-1.rds.amazonaws.com;User Id=matias;Password=123456123");
            conectar.Open();
            return conectar;
        }
    }
}
