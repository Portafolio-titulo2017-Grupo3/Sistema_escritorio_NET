using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using MySql.Data.MySqlClient;
//using System.Data.OracleClient;

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

        public static MySqlConnection abrirConexionmsql()
        {
            MySqlConnection conn = new MySqlConnection("server=myorion.ct8hgadd3koi.sa-east-1.rds.amazonaws.com;PORT=3306;database=orionFunDB;UID=crisOrion;pwd=123456123");
            conn.Open();
            return conn;
        }

    }
}
